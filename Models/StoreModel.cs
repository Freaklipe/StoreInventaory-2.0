using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreInventaory_2._0.Models
{
    public class StoreModel
    {
        private int id;
        private string name;
        private string address;
        private string description;
        private bool status;

        // Properties & Basic Validate
        public int Id { get => id; set => id = value; }

        [DisplayName("Store Name")]
        [Required(ErrorMessage = "Store - Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Store - Name must be between 3 and 20 characters")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Store Address")]
        [Required(ErrorMessage = "Store - Address is required")]
        [StringLength(150, MinimumLength = 10, ErrorMessage = "Store - Address must be between 10 and 150 characters")]
        public string Address { get => address; set => address = value; }

        [DisplayName("Store Description")]
        [Required(ErrorMessage = "Store - Description is required")]
        [StringLength(500, MinimumLength = 0, ErrorMessage = "Store - Description must not exceed more than 500 characters")]
        public string Description { get => description; set => description = value; }

        public bool Status { set => status = value; }
    }
}
