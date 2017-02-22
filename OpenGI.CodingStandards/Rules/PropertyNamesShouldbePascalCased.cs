using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.FxCop.Sdk;

namespace OpenGI.CodingStandards.Rules
{
    public class PropertyNamesShouldbePascalCased : BaseRule
    {
        public PropertyNamesShouldbePascalCased():
            base("PropertyNamesShouldbePascalCased")
        {
                       // System.Diagnostics.Debugger.Launch();
        }

        public override ProblemCollection Check(Member member)
        {
            PropertyNode meth = member as PropertyNode;
            if (meth != null &&  meth.NodeType != NodeType.InstanceInitializer)
            {
                string pascalMethodName = meth.Name.Name.ToPascalstring();
                if (!meth.Name.Name.Equals(pascalMethodName))
                { 
                    this.Problems.Add(new Problem(this.GetResolution(), meth.SourceContext ));
                }
            }
            return Problems;
        }





    }
}
