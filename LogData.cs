using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EALogsViewer
{
    public class LogData
    {
        public LogData()
        {
            Items = new List<LogItem>();
        }

        public List<LogItem> Items { get; set; }

        public bool IsDataLoad { get; set; }
    }
}
