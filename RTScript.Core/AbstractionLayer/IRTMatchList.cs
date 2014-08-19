using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RTScript.Core.AbstractionLayer
{
    /// <summary>
    /// Output of the Match step.
    /// </summary>
    public interface IRTMatchList
    {
        IRTMatch this[int index]
        {
            get;
        }

        int Count
        {
            get;
        }
    }
}
