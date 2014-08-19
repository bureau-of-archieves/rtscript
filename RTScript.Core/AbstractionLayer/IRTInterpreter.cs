using System;
using RTScript.Core.Logic.Execution;

namespace RTScript.Core.AbstractionLayer
{
    public interface IRTInterpreter
    {
        bool CanExecute
        {
            get;
        }

        object Execute(RTExecutionContext context);
    }
}
