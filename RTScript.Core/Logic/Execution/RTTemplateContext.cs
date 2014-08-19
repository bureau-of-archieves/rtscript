using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.AbstractionLayer;
using RTScript.Core.Logic.Expression;

namespace RTScript.Core.Logic.Execution
{
    public class RTTemplateContext : RTExecutionContext
    {
        private readonly IRTMatch _matchInput;

        public RTTemplateContext(string srcText, IRTMatch data, IRTMetadataFactory factory)
            : base(factory)
        {
            this._srcText = srcText;
            this._matchInput = data;
        }


        protected override void InitRootScope()
        {
            base.InitRootScope();

            CurrentScope.SetValueLocal(RTSysSymbols.MATCH_INPUT, _matchInput);
        }
    }
}
