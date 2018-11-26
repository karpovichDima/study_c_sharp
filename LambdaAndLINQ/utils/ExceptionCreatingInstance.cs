using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaAndLINQ.utils
{
    class ExceptionCreatingInstance : Exception
    {
        public ExceptionCreatingInstance(string message) : base(message)
        {
        }
    }
}