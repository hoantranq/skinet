namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        private string Details { get; set; }

        public ApiException(int statusCode, string message = null, string details = null) : base(statusCode, message)
        {
            Details = details;
        }
    }
}