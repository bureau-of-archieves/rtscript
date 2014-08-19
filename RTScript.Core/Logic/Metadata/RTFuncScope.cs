using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.Logic.Execution;
using RTScript.Core.Logic.Expression;

namespace RTScript.Core.Logic.Metadata
{
    public class RTFuncScope : RTMetadata
    {
        public RTFuncScope()
        {
            this.CanDefineVariable = true;
            this.HasReturnValue = false;
        }

        public override string FunctionName
        {
            get { return RTSysSymbols.SCOPE; }
        }

        public override object Execute(Execution.RTExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
