using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventaory_2._0.Models
{
    public class DetailModel
    {
        private int id;
        private int idProduct;
        private string codeProduct;
        private string nameProduct;
        private int idStore;
        private string nameStore;
        private int price;
        private int stock;

        // Properties & Basic Validate
        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "Detail - Id Product is required")]
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string CodeProduct { get => codeProduct; set => codeProduct = value; }

        [Required(ErrorMessage = "Detail - Id Store is required")]
        public int IdStore { get => idStore; set => idStore = value; }
        public string NameStore { get => nameStore; set => nameStore = value; }


        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        public int Price { get => price; set => price = value; }

        [DisplayName("Stock")]
        [Required(ErrorMessage = "Stock is required")]
        public int Stock { get => stock; set => stock = value; }
    }
}
