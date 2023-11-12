using Newtonsoft.Json;

namespace HotelListing.API.Models
{
    public class GlobalException
    {
        public GlobalException(int statuscode, string message=null, string details=null)
        {
            this.Message = message;
            this.StatusCode = statuscode;   
            this.details = details; 
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string details { get; set; }

    }
}
