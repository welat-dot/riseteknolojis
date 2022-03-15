﻿namespace CoreLayer.Utilits.Result
{
    public  class SuccessResult:Result
    {
        public SuccessResult(string Message) : base(true, Message)
        {
        }
        public SuccessResult() : base(true)
        {
        }
    }
}
