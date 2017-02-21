using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.FxCop.Sdk;

namespace OpenGI.CodingStandards.Rules
{
    class NameSpaceIsPascalRule : BaseRule
    {
        public NameSpaceIsPascalRule():
            base("NameSpaceIsPascalRule")
        {
            //System.Diagnostics.Debugger.Launch();
        }


        public override void VisitClass(ClassNode classType)
        {
            
            Console.WriteLine("Visiting Class");
            string ClassNameSpace = classType.Namespace.Name;
            string pascalClassNameSpace = ClassNameSpace.ToPascalstring();
            if (!ClassNameSpace.Equals(pascalClassNameSpace))
            {
                this.Problems.Add(new Problem(this.GetResolution(), classType));
            }
            this.Problems.Add(new Problem(this.GetResolution(),"THIS IS OK..."));
            base.VisitClass(classType);
        }


 

    }
}
