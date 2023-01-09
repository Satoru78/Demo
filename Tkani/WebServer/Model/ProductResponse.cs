using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkani.Model;

namespace WebServer.Model
{
    class ProductResponse
    {
        public ProductResponse(Product product)
        {
            this.ID = product.ID;
            this.Articul = product.Articul;
            this.Title = product.Title;
            this.Unit = product.Unit;
            this.Count = product.Count;
            this.Discount = product.Discount;
            this.Manufacturer = product.Manufacturer;
            this.Supplier = product.Supplier;
            this.IDProductCategory = product.IDProductCategory;
            this.QuantitiInStock = product.QuantitiInStock;
            this.Description = product.Description;
            this.Image = product.Image;
        }

        public ProductResponse() { }
        public int ID { get; set; }
        public string Articul { get; set; }
        public string Title { get; set; }
        public string Unit { get; set; }
        public decimal Count { get; set; }
        public int Discount { get; set; }
        public string Manufacturer { get; set; }
        public string Supplier { get; set; }
        public int IDProductCategory { get; set; }
        public int QuantitiInStock { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
