using System;
using System.Collections.Generic;
using System.Text;

namespace Speller
{
    public class NegativeIntegerException : Exception
    {
        public override string Message => "can not spell negative numbers"; 
    }
}
