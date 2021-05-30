using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Web.Services.Description;

namespace FirstAskisiOmadiki.Models.Custom_Validations
{
    public class MyValidationMethods
    {
        public static ValidationResult ValidateBeginsWithCapital(string value, ValidationContext context)
        {
            if (value is null) return new ValidationResult(string.Format("Required"), new List<string> { context.MemberName });

            if (Char.IsUpper(value , 0))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(string.Format($"Not capital {context.MemberName}"),new List<string> { context.MemberName });
        }

        public static ValidationResult ValidatePriceRange(int value, ValidationContext context)
        {
            if (value>0)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(string.Format($"Invalid {context.MemberName}"), new List<string> { context.MemberName });
        }
        
        public static ValidationResult ValidateDate( DateTime? value , ValidationContext context)
        {

            if (value < DateTime.Now)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(string.Format($"Invalid date time , please try again!"), new List<string> { context.MemberName });
        }
        
    }
}