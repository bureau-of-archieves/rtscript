using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.AbstractionLayer;
using System.Text.RegularExpressions;

namespace RTScript.Core.DataModel
{
    internal class CaptureRTMatchList : BaseRTMatchList
    {
        public override void Append(Match match, int matchIndex)
        {
            int groupCount = match.Groups.Count;
            for (int i = 1; i < groupCount; i++)
            {
                CaptureRTMatch captureMatch = new CaptureRTMatch();
                captureMatch.Init(match, matchIndex, i);
                this._matches.Add(captureMatch);
            }
        }
    }
}
