using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.FxCop.Sdk;

namespace OpenGI.CodingStandards.Rules
{
    public class MethodNamesShouldbePascalCasedRule : BaseRule
    {
        public MethodNamesShouldbePascalCasedRule():
            base("MethodNamesShouldBePascalCased")
        {
                       // System.Diagnostics.Debugger.Launch();
        }

        public override ProblemCollection Check(Member member)
        {
            Method meth = member as Method;
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
