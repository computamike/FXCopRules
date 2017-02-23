using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace openGI.CodingStandards
{
    public class testBadNames
    {
        public void thisIsABadName()
        {
            string ThisIsABadVariable = "";
        }
    }
}

namespace thisNameSpaceViolatesOGI001_OGI002
{
    public class thisClassViolatesOGI006
    {
        public int thisPropertyViolatesOGI008 { get; set; }
        private string ThisPropertyViolatesOGI009;
        
        public void thismethodViolatesOGI003(string ThisMethodParameterViolatesOGI004)
        {
            string ThisVariableViolatesOGI005 = "";
        }
    }
}

namespace OpenGI.OpenTrader
{

    public interface ithisInterfaceViolatesOGI007
    {
        string doStuff();
    }
}