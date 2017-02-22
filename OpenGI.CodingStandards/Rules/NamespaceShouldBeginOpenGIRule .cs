using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.FxCop.Sdk;

namespace OpenGI.CodingStandards.Rules
{
    public class NamespaceShouldBeginOGIdRule : BaseRule
    {
        public NamespaceShouldBeginOGIdRule():
            base("NamespaceShouldBeginOGIRule")
        {
                       // System.Diagnostics.Debugger.Launch();
        }



        public override ProblemCollection Check(string namespaceName, TypeNodeCollection types)
        {

            if (namespaceName != "")
            {
                string pascalClassNameSpace = namespaceName.ToPascalstring();
                if (!pascalClassNameSpace.StartsWith("OpenGI.OpenTrader"))
                {
                    this.Problems.Add(new Problem(this.GetResolution(), namespaceName));
                }
            }

            return Problems;
        }
 
    
 

    }
}
