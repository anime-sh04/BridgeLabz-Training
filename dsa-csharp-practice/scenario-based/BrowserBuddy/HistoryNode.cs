using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserBuddy
{
    internal class HistoryNode
    {
        public string Url;
        public HistoryNode Prev;
        public HistoryNode Next;

        public HistoryNode(string url)
        {
            Url = url;
        }
    }

}
