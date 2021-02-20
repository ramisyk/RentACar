using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //for void methods
    public interface IResult
    {
        bool Success { get; } //method's state -> done or not
        string Message { get; } //method's message -> what happened
    }
}
