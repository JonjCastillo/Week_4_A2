using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SportsPro.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required (ErrorMessage = "Enter a Product Code")]
        public string? ProductCode { get; set; }

        [Required (ErrorMessage = "Enter a Product Name")]
        public string? Name { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        [Required (ErrorMessage = "Enter a Product Price")]
        [Range(0.01, 99999999.99, ErrorMessage = "Enter a positive price")]
        public decimal? Price { get; set; }

        //Add product date 
        [DataType(DataType.Date)]
        [Required (ErrorMessage = "Enter a Product Date")]
        public DateTime? ReleaseDate { get; set; }

        //public string Slug => 
           // ProductCode?.ToLower() + '-' + ProductId.ToString();
    }
}
