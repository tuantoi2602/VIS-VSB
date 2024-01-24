using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeAPP.DataLayer.DTO
{
    public class Employee
    {
        private int employee_id;
        private string name;
        private string address;
        private int telephone;
        private string email;
        public Employee(DataRow row)
        {
            this.employee_id = (int)row["employee_id"];
            this.name = row["name"].ToString();
            this.address = row["address"].ToString();
            this.telephone = (int)row["telephone"];
            this.email = row["email"].ToString();
        }
        public Employee(int employee_id, string name, string address, int telephone, string email)
        {
            this.employee_id = employee_id;
            this.name = name;
            this.address = address;
            this.telephone = telephone;
            this.email = email;
        }

        public int Employee_id { get => employee_id; set => employee_id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public int Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
    }
}
