using System;

namespace RTScript.Core.AbstractionLayer
{
    public interface IRTExpression
    {
        object Execute(RTScript.Core.Logic.Execution.RTExecutionContext context);
    }
}
