namespace CoreLayer.Utilits.Result
{
    public interface IResult
    {
        bool success { get; }
        string message { get; }
    }
}
