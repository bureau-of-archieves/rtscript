using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RTScript.Core.Logic.Execution;

namespace RTScript.Core.Logic.Metadata
{
    public class PostMetadataFactory : BaseMetadataFactory, IRTMetadataFactory
    {
        protected override void Init()
        {
            base.Init();
            this.AddMetadata(new RTFuncMerge());
            //todo merge get, unmatchedbetween
        }
    }
}
