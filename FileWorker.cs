using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EALogsViewer
{
    public static class FileWorker
    {
        public static bool ConvertTextToLogData(string source, bool isCleandata, bool isLoadFullText, ref LogData result)
        {
            if (isCleandata)
                result = new LogData();
            //source = source.ToLower();
            try
            {
                List<string> splitSource = source.Split('\n').ToList();
                int splitSourceCount = splitSource.Count;

                for (int i = 0; i < splitSourceCount; i++)
                {
                    //int firstIndex = 0;
                    //int lastIndex = 0;
                    LogItem lgItem = new LogItem();

                    lgItem.LineNumber = i;

                    //получаем время вызова
                    lgItem.EventTime = GetEventTime(splitSource[i]);
                    lgItem.FullText += splitSource[i].Trim() + "\r\n";

                    i++;

                    //получаем имя метода и прочие поля
                    if (i < splitSourceCount)
                    {
                        lgItem.Method = GetMethodName(splitSource[i]);
                        lgItem.RNK = GetRNK(splitSource[i], lgItem.Method);

                        //if (lgItem.Method == ConfigurationManager.AppSettings["SetAgrMethod"])
                       // {
                            lgItem.AgreementCode = GetAgreementCode(splitSource[i]);
                       // }

                        lgItem.AccountNumber = GetAccountNumber(splitSource[i], lgItem.Method);

                        if (lgItem.Method == "SetDocumentData")
                        {
                            lgItem.DocExternalNumber = GetDocumentExternalId(splitSource[i]);
                            lgItem.LinkerRnk = GetDocumentLinkedRnk(splitSource[i]);
                        }

                        lgItem.Base64String = GetBase64String(splitSource[i]);

                        if (isLoadFullText)
                            lgItem.FullText += splitSource[i].Trim() + "\r\n";
                    }

                    i++;

                    //получаем время ответа
                    if (i < splitSourceCount)
                    {
                        lgItem.AnswerTime = GetEventTime(splitSource[i]);
                        if (isLoadFullText)
                            lgItem.FullText += splitSource[i].Trim() + "\r\n";
                    }

                    i++;

                    //получаем текст ответа
                    if (i < splitSourceCount)
                    {
                        if (!splitSource[i].StartsWith("Output"))
                        {
                            i = i-2;
                            result.Items.Add(lgItem);
                            continue;
                        }
                        lgItem.Responce = splitSource[i];

                        if (isLoadFullText)
                            lgItem.FullText += splitSource[i].Trim() + "\r\n";
                    }

                    if (lgItem.FullText.Trim().Length > 5 || !isLoadFullText)
                        result.Items.Add(lgItem);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static string GetBase64String(string source)
        {
            //string result = String.Empty;
            //string sPattern ="\\w{6}_\\w{4}\\S{2}\""; // @"\w{6}\S\w{4}\S{3}";
            //string nextsPattern = "\",\"l\\w{8}\"";
            string sPattern = "binary_data\\S{2}\".*\",\"l\\w{8}\"";

            string searchResult = Regex.Match(source, sPattern).Value;

            char[] binDataText = "binary_data\":\"".ToCharArray();
            char[] linkRnkText = "\",\"linkedrnk\"".ToCharArray();

            searchResult = searchResult.TrimStart(binDataText).TrimEnd(linkRnkText);
            //string last = Regex.Match(source, nextsPattern).Value;

            return searchResult;
        }

        private static string GetDocumentExternalId(string source)
        {
            string sPattern = "\\W{5}\\w{2}\\W{2}\\d+";
            string filterPattern = "\\d+";

            string idWithText = Regex.Match(source, sPattern).Value;

            string id = Regex.Match(idWithText, filterPattern).Value;

            return id;
        }

        private static string GetDocumentLinkedRnk(string source)
        {
            string sPattern = "linkedrnk\":\\w*";

            string rnkWithText = Regex.Match(source, sPattern).Value;

            string linkedRnk = rnkWithText.Split(':').LastOrDefault();//Regex.Match(idWithText, filterPattern).Value;

            return linkedRnk;
        }

        private static string GetAccountNumber(string source, string method)
        {
            string result = String.Empty;

            int firstIndex;
            int lastIndex = -1;

            firstIndex = source.IndexOf("\"account_number\":\"") + "\"account_number\":\"".Length;
            
            //if (method == ConfigurationManager.AppSettings["SetAgrMethod"])
            lastIndex = source.IndexOf("\",\"dvb_close");
            if (lastIndex == -1)
            {
                lastIndex = source.IndexOf("\",\"currency_code");
            }
            if (lastIndex == -1)
            {
                lastIndex = source.IndexOf("\",\"agr_date_close");
            }
            
            if (lastIndex > firstIndex && source.StartsWith("Input =") && lastIndex - firstIndex < 40)
            {
                string account = source.Substring(firstIndex, lastIndex - firstIndex).Trim();
                result = account;
            }

            return result;
        }

        private static string GetAgreementCode(string source)
        {
            string result = String.Empty;

            int firstIndex;
            int lastIndex;
            firstIndex = source.IndexOf("\"agr_code\":");
            
            if(firstIndex != -1)
                firstIndex += "\"agr_code\":".Length;

            lastIndex = source.IndexOf(",\"RNK") != -1 ? source.IndexOf(",\"RNK") : source.IndexOf(",\"rnk");

            if (firstIndex > 0)
            {
                if (lastIndex < firstIndex)
                {
                    lastIndex = source.IndexOf(",\"account_type") != -1 ? source.IndexOf(",\"account_type") : source.IndexOf(",\"account_type");
                }

                if (lastIndex > firstIndex && source.StartsWith("Input ="))
                {
                    string code = source.Substring(firstIndex, lastIndex - firstIndex).Trim('\"');
                    result = code;
                }
            }

            return result;
        }

        private static string GetRNK(string source, string method)
        {
            string sPattern = @"\W{2}\w{3}\W{2}\d+";
            string filterPattern = @"\d+";

            string rnkWithText = Regex.Match(source, sPattern).Value;
            string rnkNumber = Regex.Match(rnkWithText, filterPattern).Value; 

            return rnkNumber;
        }

        private static string GetMethodName(string source)
        {
            string result = String.Empty;

            int firstIndex;
            int lastIndex;
            firstIndex = source.IndexOf("\"method\":\"") + "\"method\":\"".Length;
            lastIndex = source.IndexOf("\",\"params");

            if (lastIndex > firstIndex && source.StartsWith("Input ="))
            {
                string method = source.Substring(firstIndex, lastIndex - firstIndex).Trim();
                result = method;
            }

            return result;
        }

        private static DateTime GetEventTime(string source)
        {
            DateTime result = new DateTime();

            string sysFormat = CultureInfo.CurrentCulture.DateTimeFormat.FullDateTimePattern;

            string dateFormat = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat.FullDateTimePattern;

            string sPattern = String.Empty;

            if(dateFormat != sysFormat)
                sPattern = @"\d+.\d+.\d+\s\d+:\d+:\d+";//@"\d+/\d+/\d+\s\d+:\d+:\d+\s\w{2}";
            else
                sPattern = @"\d+.\d+.\d+\s\d+:\d+:\d+ [A,P]M";

            string findTime = Regex.Match(source, sPattern).Value;
                
            DateTime eventTime = new DateTime();

            IFormatProvider theCultureInfo = CultureInfo.InvariantCulture;

            if (DateTime.TryParse(findTime, theCultureInfo, DateTimeStyles.None, out eventTime))
            {
                result = eventTime;
            }
            else if (DateTime.TryParse(findTime, out eventTime))
            {
                result = eventTime;
            }
            return result;
        }

        //private static DateTime GetAnswerTime(string source)
        //{
        //    DateTime result = new DateTime();

        //    result = GetEventTime(source);
        //    //int firstIndex;
        //    //int lastIndex;
        //    //firstIndex = source.IndexOf("at") + 2;
        //    //lastIndex = source.IndexOf(" : to");

        //    //if (lastIndex > firstIndex)
        //    //{
        //    //    string time = source.Substring(firstIndex, lastIndex - firstIndex).Trim();
        //    //    DateTime answerTime = new DateTime();

        //    //    IFormatProvider theCultureInfo = CultureInfo.InvariantCulture;

        //    //    if (DateTime.TryParse(time, theCultureInfo, DateTimeStyles.None, out answerTime))
        //    //    {
        //    //        result = answerTime;
        //    //    }

        //    //}

        //    return result;
        //}
    }
}
