using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CousinCalculatorLibrary
{
    public class InsufficientFamilyHistoryException : Exception
    {
        public InsufficientFamilyHistoryException(String errorMessage) :
            base(errorMessage)
        {
        }

    }
}
