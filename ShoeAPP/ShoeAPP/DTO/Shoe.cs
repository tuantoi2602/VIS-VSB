using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ShoeAPP.DataLayer.DTO
{
    public class Shoe
    {
        private int shoe_id;
        private string name;
        private int size;
        private string description;
        private int price;
        private int customer_id;
        private int brand_id;
        private int supplier_id;
        public Shoe(DataRow row)
        {
            this.shoe_id = (int)row["shoe_id"];
            this.name = row["name"].ToString();
            this.size = (int)row["size"];
            this.description = row["description"].ToString();
            this.price = (int)row["price"];
            this.customer_id = (int)row["customer_id"];
            this.brand_id = (int)row["brand_id"];
            this.supplier_id = (int)row["supplier_id"];

        }
        public Shoe(int shoe_id, string name, int size, string description, int price, int customer_id, int brand_id, int supplier_id)
        {
            this.shoe_id = shoe_id;
            this.name = name;
            this.size = size;
            this.description = description;
            this.price = price;
            this.customer_id = customer_id;
            this.brand_id = brand_id;
            this.supplier_id = supplier_id;
        }

        public int Shoe_id { get => shoe_id; set => shoe_id = value; }
        public string Name { get => name; set => name = value; }
        public int Size { get => size; set => size = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public int Customer_id { get => customer_id; set => customer_id = value; }
        public int Brand_id { get => brand_id; set => brand_id = value; }
        public int Supplier_id { get => supplier_id; set => supplier_id = value; }
    }
}
