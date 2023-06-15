using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.Validations
{
    public class PrimerLetraMayusAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            
            string palabra = value.ToString();
            if (palabra[0].ToString() == palabra[0].ToString().ToUpper())
            {

                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Primera letra debe ser mayuscula");
            }
        }
       
        
    }
}
