using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.Logic.Execution;
using RTScript.Core.Logic.Expression;

namespace RTScript.Core.Logic.Metadata
{
    public class RTLibFuncAdd : RTLibMetadata
    {
        public RTLibFuncAdd()
        {
            this.HandlesScope = true;
        }

        public override string FunctionName
        {
            get { return RTSysSymbols.ADD; }
        }


        protected override object Execute(IList<object> args)
        {
            double sum = 0;
            for (int i = 0; i < args.Count; i++)
            {
                double? val = RTConverter.Singleton.ToNumber(args[i]);
                if (val.HasValue)
                {
                    sum += val.Value;
                }
                else
                {
                    return double.NaN;
                }
            }
            return sum;
        }
    }
}
