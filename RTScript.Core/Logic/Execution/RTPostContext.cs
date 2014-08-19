using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.AbstractionLayer;
using RTScript.Core.Logic.Expression;
using RTScript.Core.Logic.Metadata;

namespace RTScript.Core.Logic.Execution
{
    internal class RTPostContext : RTExecutionContext
    {
        private IRTEntry[] _mergeInput;


        protected override void InitRootScope()
        {
            base.InitRootScope();

            CurrentScope.SetValueLocal(RTSysSymbols.MERGE_INPUT, _mergeInput);
            CurrentScope.SetValueLocal(RTSysSymbols.SOURCE_TEXT, _srcText);
        }

        public RTPostContext(string srcText, IRTEntry[] mergeInput, IRTMetadataFactory factory)
            : base(factory)
        {
            this._srcText = srcText;
            this._mergeInput = mergeInput;
        }



    }
}
