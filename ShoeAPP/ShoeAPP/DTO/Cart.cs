using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ShoeAPP.DataLayer.DTO
{
    public class Cart
    {
        private int cart_id;
        private int quantity;
        private Shoe shoe_id;
        public Cart(DataRow row)
        {
            this.cart_id = (int)row["cart_id"];
            this.quantity = (int)row["quantity"];
            this.shoe_id = (Shoe)row["shoe_id"];
        }
        public Cart(int cart_id, DateTime date, int quantity, Shoe shoe_id)
        {
            this.cart_id = cart_id;
            this.quantity = quantity;
            this.shoe_id = shoe_id;
        }

        public int Cart_id { get => cart_id; set => cart_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Shoe Shoe_id { get => shoe_id; set => shoe_id = value; }
    }
}
