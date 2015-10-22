using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTScript.Core
{
    /// <summary>
    /// The type of script to use.
    /// </summary>
    public enum ScriptType
    {
        /// <summary>
        /// @{ (Reverse (def a ($0)) (a)) @}
        /// @{ (For (def body (Lower x)) 1 10 (body)) @}
        /// </summary>
        Functional,

        /// <summary>
        /// {funname1 arg1 arg2 {funcname2 arg1}}
        /// {0}
        /// {ToLower {0}}
        /// {Substring {0} 0 {Add {Len {0}} -1}}
        /// {IndexOf {0} "Test"}
        /// </summary>
        Simple

    }
}
