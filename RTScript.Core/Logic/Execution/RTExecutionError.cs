using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.AbstractionLayer;
using RTScript.Core.Logic.Expression;

namespace RTScript.Core.Logic.Execution
{
    public class RTExecutionError : RTParsingError
    {
        internal RTExecutionError(RTScope func, RTErrorCode errCode, string errMsg)
            : base(func.Creator.SourceStartIndex, func.Creator.SourceEndIndex, errCode, errMsg)
        {
            this.FunctionName = func.FunctionName;
        }

        public string FunctionName
        {
            get;
            private set;
        }
    }
}
