using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.FxCop.Sdk;


namespace OpenGI.CodingStandards.Rules
{
    public class ClassNamesShouldBePascalBased: BaseRule
    {
        public ClassNamesShouldBePascalBased() :
            base("ClassNamesShouldBePascalBased")
        {
            // System.Diagnostics.Debugger.Launch();
        }

        public override ProblemCollection Check(TypeNode type)
        {
            ClassNode node = type as ClassNode;
            if(node != null)
            {
                string pascalMethodName = node.Name.Name.ToPascalstring();
                if (!node.Name.Name.Equals(pascalMethodName))
                {
                    this.Problems.Add(new Problem(this.GetResolution(), node.SourceContext));
                }
            }
            return Problems;
        }



    }
}
