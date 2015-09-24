using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EALogsViewer
{
    public class LogItem
    {
        public LogItem()
        {
            LineNumber = 0;
            Method = String.Empty;
            Responce = String.Empty;
            RNK = String.Empty;
            DocExternalNumber = String.Empty;
            AgreementCode = String.Empty;
            AccountNumber = String.Empty;
            Base64String = String.Empty;
        }

        public string Base64String { get; set; }

        public int LineNumber { get; set; }

        public string Method { get; set; }

        public string Responce { get; set; }

        public string RNK { get; set; }

        public string DocExternalNumber { get; set; }

        public string AgreementCode { get; set; }

        public string AccountNumber { get; set; }

        public DateTime EventTime { get; set; }

        public DateTime AnswerTime { get; set; }

        public string FullText { get; set; }

        public string LinkerRnk { get; set; }
    }
}
