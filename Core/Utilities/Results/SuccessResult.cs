using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        //base is upclass
        //base refer to Result
        //base(true, message) include two parameter so ctor's that two parameter in Result
        public SuccessResult(string message):base(true, message)
        {

        }
        public SuccessResult() : base(true)
        {

        }
    }
}
