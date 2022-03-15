namespace CoreLayer.Utilits.Result
{
    public  class ErrorResult : Result
    {
        public ErrorResult(string Message) : base(false, Message)
        {

        }
        public ErrorResult() : base(Success: false)
        {
        }


    }
}
