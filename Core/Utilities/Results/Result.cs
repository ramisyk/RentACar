using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // getter are readonly / can't set normally bu it can in ctor
        // this(success) -> run ctor with one parameter in this class
        // this refer to Result class and one parameter in there 
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
