using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using RTScript.Core.AbstractionLayer;
using RTScript.Core.DataModel;
using RTScript.Core.Logic.Execution;
using RTScript.Core.Logic.Expression;
using RTScript.Core.Logic.Metadata;

namespace RTScript.Core.Logic
{
    public class RTTemplate : IRTTemplate
    {
        private string _templateExpr;
        private TemplateOptions _options;
        private IRTInterpreter _interpreter;
        private RTParsingException _parsingException;

        public RTTemplate(string templateExpr, TemplateOptions options)
        {
            Contract.Requires(templateExpr != null);
            Contract.Requires(options != null);

            _templateExpr = templateExpr;
            _options = options;
        }

        private void Init()
        {
            if (_options != null)
            {
                RTParsingContext context = new RTParsingContext(_factory);
                if (_options.ScriptType == ScriptType.Functional)
                {
                    var exprList = new RTExpressionList();
                    exprList.Parse(_templateExpr, 0, context); //parse should not throw an exception
                    _interpreter = exprList;
                }
                else
                {
                    throw new NotImplementedException();
                }
                _options = null;
                _templateExpr = null;

                if (!_interpreter.CanExecute)
                {
                    _parsingException = new RTParsingException(context.Errors, ErrorMessages.Template_Parsing_Error);
                }
            }
            if (_parsingException != null) throw _parsingException;
        }

        public string Execute(IRTMatch data)
        {
            Init();

            RTExecutionContext context = new RTTemplateContext(_templateExpr, data, _factory);
            var result = _interpreter.Execute(context);
            if (context.HasError)
            {
                throw new RTExecutionException(context.Errors, ErrorMessages.Template_Execution_Error);
            }

            if (result == null)
            {
                return null;
            }
            else
            {
                return result.ToString();
            }
        }

        private static TemplateMetadataFactory _factory = new TemplateMetadataFactory(); //todo temp solution
    }
}
