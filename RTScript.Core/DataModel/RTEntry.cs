using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.AbstractionLayer;

namespace RTScript.Core.DataModel
{
    internal class RTEntry : IRTEntry
    {
        public IRTMatch DataSource
        {
            get;
            set;
        }

        public string Result
        {
            get;
            set;
        }

        public int EntryIndex
        {
            get;
            set;
        }
       
    }
}
