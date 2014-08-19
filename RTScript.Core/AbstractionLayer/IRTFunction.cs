using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.Logic.Execution;

namespace RTScript.Core.AbstractionLayer
{

    public interface IRTFunction : IRTExpression
    {
        string Name
        {
            get;
        }

        IList<object> Args
        {
            get;
        }

        int SourceStartIndex
        {
            get;
        }

        int SourceEndIndex
        {
            get;
        }

        RTMetadata Metadata
        {
            get;
        }

    }
}
