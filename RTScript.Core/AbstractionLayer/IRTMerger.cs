using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTScript.Core.AbstractionLayer
{
    public interface IRTMerger
    {
        string Execute(string srcText, IRTEntry[] source);
    }
}
