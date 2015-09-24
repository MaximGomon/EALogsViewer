using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EALogsViewer
{
    [DataContract]
    public class Setting
    {
        public Setting()
        {
            LogPath = String.Empty;
            HistoryPath = String.Empty;
            LogFileName = String.Empty;
            BinaryFilesPath = String.Empty;
        }

        [DataMember]
        public string LogPath { get; set; }

        [DataMember]
        public bool IsLoadFullRequestText { get; set; }

        [DataMember]
        public string LogFileName { get; set; }

        [DataMember]
        public string HistoryPath { get; set; }

        [DataMember]
        public FileType FileType { get; set; }

        [DataMember]
        public string SystemLog { get; set; }

        [DataMember]
        public string BinaryFilesPath { get; set; }

        [DataMember]
        public bool IsSaveBinaryFiles { get; set; }

        public static bool SaveSetting(Setting setParam)
        {
            setParam.SystemLog = String.Empty;
            string filepath = Directory.GetCurrentDirectory() + @"\setting.xml";
            Stream stream = null;
            XmlTextWriter xmlTextWriter = null;
            bool successfull = false;
            try
            {
                stream = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                DataContractSerializer serializer = new DataContractSerializer(typeof(Setting));

                xmlTextWriter = new XmlTextWriter(stream, null) { Formatting = Formatting.Indented, Indentation = 4 };

                serializer.WriteObject(xmlTextWriter, setParam);

                xmlTextWriter.Close();
                stream.Close();

                successfull = true;
            }
            catch (Exception ex)
            {
                successfull = false;
            }
            finally
            {
                if (xmlTextWriter != null)
                {
                    xmlTextWriter.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return successfull;
        }

        public static Setting LoadSetting()
        {
            string path = Directory.GetCurrentDirectory() + @"\setting.xml";

            Setting setParam = new Setting();

            Stream stream = null;
            XmlDictionaryReader xmlTextReader = null;

            try
            {
                if (File.Exists(path))
                {
                    stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                    DataContractSerializer serializer = new DataContractSerializer(typeof(Setting));

                    xmlTextReader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas());
                    setParam = (Setting)serializer.ReadObject(xmlTextReader, true);

                    xmlTextReader.Close();
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (xmlTextReader != null)
                {
                    xmlTextReader.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
            return setParam;
        }
    }

    public enum FileType
    {
        Tiff,
        PDF
    }

    
}
