using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.FxCop.Sdk;


namespace OpenGI.CodingStandards.Rules
{
    public class LocalVarialblesShouldBeCamelCased : BaseRule
    {
        public LocalVarialblesShouldBeCamelCased() :
            base("LocalVarialblesShouldBeCamelCased")
        {
            // System.Diagnostics.Debugger.Launch();
        }

        public override ProblemCollection Check(Member member)
        {
            Method method = member as Method;

            if (method == null)
                return null;
            
            if (method.Instructions == null || method.Instructions.Count  == 0)
                return null;
            LocalCollection locals = method.Locals;
            //LocalList locals = method.Instructions[0].Value as LocalList;

            if (locals == null)
                return null;


            foreach (var item in locals)
            {
                if (RuleUtilities.IsCompilerGenerated(item)) 
                    continue;
                string localVariableName = item.Name.Name;
                string camelLocalVariableName = localVariableName.ToCamelString();
                if (!item.Name.Name.Equals(camelLocalVariableName))
                {
                    this.Problems.Add(new Problem(this.GetResolution(), item.SourceContext));
                }

            }
             
            return Problems;
        }




    }
}
