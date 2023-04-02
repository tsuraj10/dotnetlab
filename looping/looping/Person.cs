using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace looping
{
    internal class Person
    {
        int NumberOfEyes;
        internal protected
            string HairColor { get; set; }
       internal protected
            int NumberOfEye { get { return NumberOfEyes; } set { NumberOfEyes = value; } }

    }
}
