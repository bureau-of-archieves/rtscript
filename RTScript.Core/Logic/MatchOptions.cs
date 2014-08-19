using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RTScript.Core.Logic
{
    [Serializable]
    public class MatchOptions
    {
        public MatchOptions()
        {
            MatchType = Core.MatchType.Group; //default value
        }

        public RegexOptions RegexOptions
        {
            get;
            set;
        }

        public MatchType MatchType
        {
            get;
            set;
        }
    }
}
