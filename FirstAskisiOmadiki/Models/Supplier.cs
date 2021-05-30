using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FirstAskisiOmadiki.Models.Custom_Validations;
using FluentValidation.Attributes;

namespace FirstAskisiOmadiki.Models
{
    [Validator(typeof(SupplierValidator))]
    public class Supplier
    {
        [Display(Name = "SupplierId")]
        public int SupplierId { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public Supplier()
        {
            Products = new HashSet<Product>();
        }
    }
}