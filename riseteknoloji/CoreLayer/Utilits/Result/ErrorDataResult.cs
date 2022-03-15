﻿namespace CoreLayer.Utilits.Result
{
    public  class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T Data, string Message) : base(Data, Success: false, Message)
        {
        }
        public ErrorDataResult(T Data) : base(Data, Success: false)
        {
        }
        public ErrorDataResult(string Message) : base(Success: false, Message)
        {
        }
    }
}
