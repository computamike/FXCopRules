using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.FxCop.Sdk;

namespace OpenGI.CodingStandards.Rules
{
    public class MethodParametersShouldbeCamelCasedRule : BaseRule
    {
        public MethodParametersShouldbeCamelCasedRule():
            base("MethodParametersShouldBeCamelCased")
        {
                       // System.Diagnostics.Debugger.Launch();
        }

        public override ProblemCollection Check(Member member)
        {
            Method meth = member as Method;
            if (meth != null &&  meth.NodeType != NodeType.InstanceInitializer)
            {
                string pascalMethodName = meth.Name.Name.ToPascalstring();
                if (ShouldCheck(meth))
                {
                    foreach (var param in meth.Parameters)
                    {
                        string paramName = param.Name.ToString();
                        string camelParam = paramName.ToCamelString();
                        if (!paramName.Equals(camelParam))
                        {
                            this.Problems.Add(new Problem(this.GetResolution(), meth.SourceContext ));
                        }
                    }
                }
            }
            return Problems;
        }


        /// <summary>
        /// Decides whether we should apply this rule to the given method.
        /// </summary>
        /// <param name="method">The method.</param>
        /// <returns>False if the method is null, non-public, an interface or abstract method, a public property setter; true otherwise.</returns>
        private static bool ShouldCheck(Method method)
        {
            if (method == null) { return false; }

            if (!method.IsPublic) { return false; }

            // this will catch methods that are defined as either abstract or interface methods
            if (method.IsAbstract) { return false; }

            if (method.IsAccessor) { return false; }


            return true;
        }


    }
}
