namespace WebApiJsonException.Models
{
    public class ErrorModel
    {
        public string ErrorCode { get; set; }
        public string Description { get; set; }
        public string AdditionalInformation { get; set; }
    }
}
