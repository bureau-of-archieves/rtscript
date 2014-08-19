using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using RTScript.Core.Logic.Execution;
using RTScript.Core.Logic.Expression;

namespace RTScript.Core
{
    public class RTExecutionException : ApplicationException, ISerializable
    {
        public RTExecutionException(IList<RTExecutionError> errors, string message)
            : base(message)
        {
            this.Errors = errors;
        }

        public IList<RTExecutionError> Errors
        {
            get;
            private set;
        }
    }
}
