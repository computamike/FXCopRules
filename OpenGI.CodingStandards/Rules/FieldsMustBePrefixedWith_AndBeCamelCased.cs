using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.FxCop.Sdk;


namespace OpenGI.CodingStandards.Rules
{
    public class FieldsMustBePrefixedWith_AndBeCamelCased : BaseRule
    {
        public FieldsMustBePrefixedWith_AndBeCamelCased() :
            base("FieldsMustBePrefixedWith_AndBeCamelCased")
        {
            // System.Diagnostics.Debugger.Launch();
        }

        // inspiration : http://www.binarycoder.net/fxcop/html/ex_classfieldnameprefixes.html
        public override ProblemCollection Check(Member member)
        {
            if (!(member.DeclaringType is ClassNode))
                return this.Problems;

            Field fld = member as Field;
            if (fld == null)
                return this.Problems;

            if (!fld.IsStatic &&  !fld.IsCompilerControlled && !fld.Name.Name.StartsWith("_", StringComparison.Ordinal) && !fld.IsCompilerControlled )
            {
                this.Problems.Add(new Problem(this.GetNamedResolution("Instance", fld.Name.Name)));
            }

            return this.Problems;
        }


    }
}
