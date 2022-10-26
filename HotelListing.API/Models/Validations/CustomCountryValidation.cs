using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Validations
{
    public class CustomCountryValidation: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var country = validationContext.ObjectInstance;
            if(value.ToString().Length <= 3)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Please enter countrycode which is less than 3 characters in length");
        }
    }
}
