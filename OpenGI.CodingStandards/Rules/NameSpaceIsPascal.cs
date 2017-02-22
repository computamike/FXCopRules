using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.FxCop.Sdk;

namespace OpenGI.CodingStandards.Rules
{
    public class NamespaceShouldBePascalCasedRule : BaseRule
    {
        public NamespaceShouldBePascalCasedRule():
            base("NameSpaceIsPascalRule")
        {
                       // System.Diagnostics.Debugger.Launch();
        }



        public override ProblemCollection Check(string namespaceName, TypeNodeCollection types)
        {

            if (namespaceName != "")
            {
                string pascalClassNameSpace = namespaceName.ToPascalstring();
                if (!namespaceName.Equals(pascalClassNameSpace))
                {
                this.Problems.Add(new Problem(this.GetResolution(), namespaceName));
                }
            }

            return Problems;
        }
        public override ProblemCollection Check(Member member)
        {
            return base.Check(member);
        }


    }
}
