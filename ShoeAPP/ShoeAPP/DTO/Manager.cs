using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeAPP.DataLayer.DTO
{
    public class Manager
    {
        private int manager_id;
        private string name;
        private string address;
        private string email;
        private int telephone;

        public Manager(DataRow row)
        {
            this.manager_id = (int)row["manager_id"];
            this.name = row["name"].ToString();
            this.address = row["address"].ToString();
            this.email = row["email"].ToString();
            this.telephone = (int)row["telephone"];
            
        }
        public Manager(int manager_id, string name, string address, string email, int telephone)
        {
            this.manager_id = manager_id;
            this.name = name;
            this.address = address;
            this.email = email;
            this.telephone = telephone;
        }

        public int Manager_id { get => manager_id; set => manager_id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public int Telephone { get => telephone; set => telephone = value; }
    }
}
