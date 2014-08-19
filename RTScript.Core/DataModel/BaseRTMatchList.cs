using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using RTScript.Core.AbstractionLayer;

namespace RTScript.Core.DataModel
{
    internal abstract class BaseRTMatchList : IRTMatchList
    {
        protected IList<IRTMatch> _matches;

        protected BaseRTMatchList()
        {
            _matches = new List<IRTMatch>();
        }

        public abstract void Append(Match match, int matchIndex);

        public IRTMatch this[int index]
        {
            get { 
                return _matches[index];
            }
        }

        public int Count
        {
            get {
                return _matches.Count;
            }
        }
    }
}
