using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RTScript.Core.Logic
{
    public interface IRTMetadataFactory
    {
        RTMetadata GetMetadata(string name);
    }
}
