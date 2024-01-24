using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayersss.DTO
{
    public class Customer
    {
        private int customer_id;
        private string name;
        private string address;
        private int telephone;
        private string email;
        public Customer(DataRow row)
        {
            this.customer_id = (int)row["customer_id"];
            this.name = row["name"].ToString();
            this.address = row["address"].ToString();
            this.telephone = (int)row["telephone"];
            this.email = row["email"].ToString();
        }
        public Customer(int customer_id, string name, string address, int telephone, string email)
        {
            this.customer_id = customer_id;
            this.name = name;
            this.address = address;
            this.telephone = telephone;
            this.email = email;
        }

        public int Customer_id { get => customer_id; set => customer_id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
    }
}
