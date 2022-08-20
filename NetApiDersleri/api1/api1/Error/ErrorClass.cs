namespace api1.Error
{
    public class ErrorClass
    {
        public int StatusCode { get; set; }
        public string Status { get; set; }
        public ErrorClass(int StatusCode)
        {
            switch (StatusCode)
            {
                case 400:
                    this.StatusCode = 400;
                    this.Status = "Bad Request";
                    break;
                case 401:
                    this.StatusCode = 401;
                    this.Status = "Authorized error";
                    break;
                case 404:
                    this.StatusCode = 404;
                    this.Status = "Resource Not Found";
                    break;
                case 500:
                    this.StatusCode = 500;
                    this.Status = "Server Error";
                    break;
                default:
                    this.StatusCode = 100;
                    this.Status = "Error ";
                    break;
            }

        }
    }
}
