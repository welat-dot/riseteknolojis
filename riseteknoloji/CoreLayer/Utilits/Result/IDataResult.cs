namespace CoreLayer.Utilits.Result
{
    public  interface IDataResult<out T>:IResult
    {
        T data { get; }
    }
}
