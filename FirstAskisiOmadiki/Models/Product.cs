using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FirstAskisiOmadiki.Models.Custom_Validations;
using FluentValidation.Attributes;

namespace FirstAskisiOmadiki.Models
{
    [Validator(typeof(ProductValidator))]
    public class Product
    {
        public Product()
        {
            Suppliers = new HashSet<Supplier>();
        }

        public int ProductId { get; set; }

        [CustomValidation(typeof(MyValidationMethods), "ValidateBeginsWithCapital")]
        public string Title { get; set; }

        [Display(Name = "Expired")]
        public bool IsExpired { get; set; }

        [CustomValidation(typeof(MyValidationMethods), "ValidateDate")]
        [Display(Name = "Date Modified")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateModified { get; set; }
        
        [CustomValidation(typeof(MyValidationMethods), "ValidatePriceRange")]
        public int Price { get; set; }

        public virtual ICollection<Supplier> Suppliers {get; set; }
    }
}