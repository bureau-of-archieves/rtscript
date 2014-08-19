using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.AbstractionLayer;
using RTScript.Core.Logic.Execution;
using RTScript.Core.Logic.Expression;

namespace RTScript.Core.Logic.Metadata
{
    class RTFuncItemCount : RTMetadata
    {
        public RTFuncItemCount()
        {
 
            this.CanDefineVariable = false;
            this.HasReturnValue = true;

        }

        public override string FunctionName
        {
            get
            {
                return RTSysSymbols.ITEM_COUNT;
            }
        }

        public override object Execute(Execution.RTExecutionContext context)
        {
            RTScope root = context.RootScope;
            IRTMatch match = root.GetValueLocal(RTSysSymbols.MATCH_INPUT) as IRTMatch;
            return match.Count;
        }
    }
}
