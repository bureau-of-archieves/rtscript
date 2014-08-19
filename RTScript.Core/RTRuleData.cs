using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace RTScript.Core
{
    [Serializable]
    public class RTRuleData
    {
        public RTRuleData(string matchExpr, string templateExpr, string postExpr, RuleOptions options)
        {
            this.MatchExpression = matchExpr;
            this.TemplateExpression = templateExpr;
            this.PostExpression = postExpr;
            this.RuleOptions = options;
        }

        public string MatchExpression
        {
            get;
            private set;
        }

        public string TemplateExpression
        {
            get;
            private set;
        }

        public string PostExpression
        {
            get;
            private set;
        }

        public RuleOptions RuleOptions
        {
            get;
            private set;
        }
    }
}
