using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.FxCop.Sdk;

namespace OpenGI.CodingStandards
{
    public abstract class BaseRule : BaseIntrospectionRule
    {
        protected BaseRule(string name)
            : base(
                  name,"OpenGI.CodingStandards.Rules",
                  typeof(BaseRule).Assembly)
        {

        }

    }
}
