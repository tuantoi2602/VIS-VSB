using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ShoeAPP.DataLayer.DTO
{
    public class Guest
    {
        private Customer customer_id;
        private Employee employee_id;
        public Guest(DataRow row)
        {
            this.customer_id = (Customer)row["customer_id"];
            this.employee_id = (Employee)row["employee_id"];
        }
        public Guest(Customer customer_id, Employee employee_id)
        {
            this.customer_id = customer_id;
            this.employee_id = employee_id;
        }

        public Customer Customer_id { get => customer_id; set => customer_id = value; }
        public Employee Employee_id { get => employee_id; set => employee_id = value; }
    }
}
