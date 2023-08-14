using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreInventaory_2._0.Models
{
    public class ProductModel
    {
        private int id;
        private string code;
        private string name;
        private string description;
        private bool status;

        // Properties & Basic Validate
        public int Id { get => id; set => id = value; }

        [DisplayName("Product Code")]
        [Required(ErrorMessage = "Product - Code is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Product - Code must be between 3 and 20 characters")]
        public string Code { get => code; set => code = value; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product - Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product - Name must be between 3 and 50 characters")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Product Description")]
        [Required(ErrorMessage = "Product - Description is required")]
        [StringLength(500, MinimumLength = 0, ErrorMessage = "Product - Description must not exceed more than 500 characters")]
        public string Description { get => description; set => description = value; }

        public bool Status { set => status = value; }
    }
}
