using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.AbstractionLayer;

namespace RTScript.Core.DataModel
{
    internal class GroupRTMatchList : BaseRTMatchList
    {
        public override void Append(System.Text.RegularExpressions.Match match, int matchIndex)
        {
            var groupMatch = new GroupRTMatch();
            groupMatch.Init(match, matchIndex);
            this._matches.Add(groupMatch); 
        }
    }
}
