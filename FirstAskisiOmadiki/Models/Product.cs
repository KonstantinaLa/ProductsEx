using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FirstAskisiOmadiki.Models.Custom_Validations;

namespace FirstAskisiOmadiki.Models
{
    public class Product
    {
        public int ProductId { get; set; }
       
        [CustomValidation(typeof(MyValidationMethods), "ValidateBeginsWithCapital")]
        [Required(), MaxLength(20, ErrorMessage ="Must be less than 20 char"), MinLength(2, ErrorMessage = "More than two")]
        public string Title { get; set; }

        [Display(Name = "Expired"), Required()]
        public bool IsExpired { get; set; }

        [CustomValidation(typeof(MyValidationMethods), "ValidateDate")]
        [Display(Name = "Date Modified"), Required()]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateModified { get; set; }

        [Required()]
        [CustomValidation(typeof(MyValidationMethods), "ValidatePriceRange")]
        public int Price { get; set; }

    }
}