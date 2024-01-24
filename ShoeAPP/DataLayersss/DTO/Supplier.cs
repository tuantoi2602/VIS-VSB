using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayersss.DTO
{
    public class Supplier
    {
        private int supplier_id;
        private string name;
        private string address;
        private int telephone;
        public Supplier(DataRow row)
        {
            this.supplier_id = (int)row["supplier_id"];
            this.name = row["name"].ToString();
            this.address = row["address"].ToString();
            this.telephone = (int)row["telephone"];

        }
        public Supplier(int supplier_id, string name, string address, int telephone)
        {
            this.supplier_id = supplier_id;
            this.name = name;
            this.address = address;
            this.telephone = telephone;
        }

        public int Supplier_id { get => supplier_id; set => supplier_id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Telephone { get => telephone; set => telephone = value; }
    }
}
