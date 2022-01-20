using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using Engine;

namespace Log
{
    class PrintLog
    {
        public string type { get; set; }
        public string text { get; set; }
        public string ex { get; set; }

        public PrintLog(string _type, string _text, string _ex)
        {
            this.type = _type;
            this.text = _text;
            this.ex = _ex;

            Engine.Utils.drawTopLeftString(this.type + " " + this.text);
        }
    }
}

