using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
    internal class CallLogManager
    {
        private CallLog[] logs;
        private int count;

        public CallLogManager(int size)
        {
            logs = new CallLog[size];
            count = 0;
        }

        public void AddCallLog(string phone, string message)
        {
            if (count < logs.Length)
            {
                logs[count++] = new CallLog(phone, message);
            }
            else
            {
                Console.WriteLine("Log storage full!");
            }
        }

        public void SearchByKeyword(string keyword)
        {
            Console.WriteLine("Searching for "+keyword);
            foreach (CallLog log in logs)
            {
                if (log != null && log.Message.Contains(keyword))
                {
                    log.Display();
                }
            }
        }

        public void FilterByTime(DateTime start,DateTime end)
        {
            Console.WriteLine("Logs between "+start+" and "+end);
            foreach (CallLog log in logs)
            {
                if (log !=null && log.Timestamp>= start && log.Timestamp <= end)
                {
                    log.Display();
                }
            }
        }
    }
}
