using Newtonsoft.Json;

namespace HotelListing.API.Models
{
    public class GlobalException
    {
        public GlobalException(int statuscode, string message)
        {
            this.Message = message;
            this.StatusCode = statuscode;   
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }

    }
}
