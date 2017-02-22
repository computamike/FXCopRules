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

namespace badNameSpace
{
    public class testBadNames
    {
        
        public void thisIsABadName(string ThisIsBAd)
        {
            string ThisIsABadVariable = "";
        }
    }
}