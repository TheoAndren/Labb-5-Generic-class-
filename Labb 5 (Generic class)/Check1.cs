using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_5__Generic_class_
{
    public class Check1<unknownDatatype> : Check<T>
    {
        public bool ToCheck(unknownDatatype val1, unknownDatatype val2)
        {
            if (val1.Equals(val2))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
