using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class CallLog
    {
        public string PhoneNumber;
        public string Message;
        public DateTime Timestamp;

        public CallLog(string phone,string message)
        {
            PhoneNumber = phone;
            Message =message;
            Timestamp= DateTime.Now;
        }

        public void Display()
        {
            Console.WriteLine(Timestamp+" "+PhoneNumber+" : "+Message);
        }
    }
}
