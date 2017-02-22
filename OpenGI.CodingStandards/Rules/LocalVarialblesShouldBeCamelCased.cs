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

            //LocalList locals = method.Instructions[0].Value as LocalList;

            //if (locals == null)
            //    return null;

            //for (int i = 0; i < locals.Length; i++)
            //{
            //    Local local = locals[i];

            //    if (local.Type != SystemTypes.Boolean)
            //        continue;

            //    if (RuleUtilities.IsCompilerGenerated(local))
            //        continue;

            //    if (local.Name.Name.StartsWith("b"))
            //        continue;

            //    base.Problems.Add(new Problem(base.GetResolution(local.Name.Name), local));
            //}

            return Problems;
        }




    }
}
