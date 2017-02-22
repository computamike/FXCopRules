using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenGI.CodingStandards
{
    public static class StringExtensions
    {

        public static string ToPascalstring(this string stringToPascalise)
        {
            // For namesapces, we split by '.'
            var sections = stringToPascalise.Split(".".ToCharArray());
            for (int section = 0; section <= sections.Length-1; section++)
            {
                StringBuilder sb = new System.Text.StringBuilder(sections[section]);
                sb[0] = char.ToUpper(sb[0]);
                sections[section] = sb.ToString();

            }
            return string.Join(".",sections);
            
             
        }





        public static string ToCamelString(this string stringToCamelise)
        {
            // how do we handle . delimited camel case?  is that even a thing?
                StringBuilder sb = new System.Text.StringBuilder(stringToCamelise);
                sb[0] = char.ToLowerInvariant(sb[0]);

            return sb.ToString();


        }

    }
}
