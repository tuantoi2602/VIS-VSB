using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayersss.DTO
{
    public class Payment
    {
        private Cart cart_id;
        private string type;
        public Payment(DataRow row)
        {
            this.cart_id = (Cart)row["cart_id"];
            this.type = row["type"].ToString();

        }
        public Payment(Cart cart_id, string type)
        {
            this.cart_id = cart_id;
            this.type = type;
        }

        public Cart Cart_id { get => cart_id; set => cart_id = value; }
        public string Type { get => type; set => type = value; }
    }
}
