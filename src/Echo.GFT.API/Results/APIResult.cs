namespace Echo.GFT.API.Results
{
    public class APIResult
    {
        public bool Success { get; private set; }
        public object Data { get; private set; }
        public string Message { get; private set; }

        public APIResult(bool success, object data, string message)
        {
            Success = success;
            Data = data;
            Message = message;
        }
    }
}
