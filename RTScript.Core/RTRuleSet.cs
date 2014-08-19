using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using RTScript.Core.Logic;

//Top level API classes are put in this namespace
namespace RTScript.Core
{
    /// <summary>
    /// This class expose the public interface of the core to a client.
    /// </summary>
    public class RTRuleSet
    {
        private const int NO_RULE_GIVEN = -1;

        private readonly string _srcText;
        private readonly RTRule[] _rules;
        private int _ruleIndex;
        private string _result;

        public RTRuleSet(string srcText, RTRuleData[] rulesData)
        {
            this._srcText = srcText;
            this._rules = new RTRule[rulesData.Length];
            for (int i = 0; i < this._rules.Length; i++)
            {
                this._rules[i] = new RTRule(rulesData[i]);
            }
            Reset();
        }

        public string SourceText
        {
            get { return _srcText; }
        }

        public string CurrentResult
        {
            get
            {
                return _result;
            }
        }

        /// <summary>
        /// Index of the next rule to execute, wrap to 0 when >= RuleCount
        /// </summary>
        public int NextRuleIndex
        {
            get { return _ruleIndex; }

            private set
            {
                if (_rules.Length == 0)
                {
                    _ruleIndex = NO_RULE_GIVEN; //no rule
                }

                if (value >= _rules.Length)
                {
                    _ruleIndex = 0; //wrap
                }
                else
                {
                    _ruleIndex = value;
                }
            }
        }

        public int RuleCount
        {
            get
            {
                return this._rules.Length;
            }
        }

        /// <summary>
        /// Apply one rule to the current result
        /// </summary>
        /// <returns>false if have run out of rules.</returns>
        public bool ExecuteNext()
        {
            if (NextRuleIndex == NO_RULE_GIVEN) return false;

            _result = this._rules[NextRuleIndex].Execute(_result);
            NextRuleIndex++;
            return NextRuleIndex != 0;
        }

        /// <summary>
        /// Apply all rules to the source string.
        /// </summary>
        /// <returns></returns>
        public string ExecuteAll()
        {
            while (true)
            {
                if (!ExecuteNext()) break;
            }

            return _result;
        }

        public void Reset()
        {
            NextRuleIndex = 0;
            _result = _srcText;
        }

    }
}
