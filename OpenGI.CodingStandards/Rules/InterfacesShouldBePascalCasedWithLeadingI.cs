using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.FxCop.Sdk;


namespace OpenGI.CodingStandards.Rules
{
    public class InterfacesShouldBePascalCasedWithLeadingI : BaseRule
    {
        public InterfacesShouldBePascalCasedWithLeadingI() :
            base("InterfacesShouldBePascalCasedWithLeadingI")
        {
            // System.Diagnostics.Debugger.Launch();
        }

        public override ProblemCollection Check(TypeNode type)
        {
            InterfaceNode node = type as InterfaceNode;
            if (node != null)
            {
                StringBuilder sb = new System.Text.StringBuilder(node.Name.Name);
                sb[0] = char.ToUpper(sb[0]);
                sb[1] = char.ToUpper(sb[1]);
                var pascalInterfaceName = sb.ToString();
                
                if (!node.Name.Name.Equals(pascalInterfaceName))
                {
                    this.Problems.Add(new Problem(this.GetResolution(), node.SourceContext));
                }
            }

            
            return Problems;
        }



    }
}
