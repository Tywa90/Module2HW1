namespace LoggerApp.Code
{
    internal class Result
    {
        public Result()
        {
        }

        public Result(bool status)
        {
            Status = status;
        }

        public Result(bool status, string message)
        {
            Status = status;
            Message = message;
        }

        public bool Status { get; set; }
        public string Message { get; set; }
    }
}
