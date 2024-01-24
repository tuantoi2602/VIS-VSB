using DataLayersss.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayersss.DataMapper
{
    public class EmployeeDataMapper
    {
        private static EmployeeDataMapper instance;

        public static EmployeeDataMapper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeDataMapper();

                }
                return EmployeeDataMapper.instance;
            }
            private set => EmployeeDataMapper.instance = value;
        }
        public bool InsertEmployee(string name, string address, int telephone, string email)
        {
            //insert into employee values ('Long','Tokyo',0931824102,'longlanh@gmail.com');
            string query = string.Format("insert into employee values ('{0}','{1}', '{2}', '{3}')",
            name, address, telephone, email);

            int r = DataConnection.Instance.ExecuteNonQuery(query);
            return r > 0;
        }
        public bool UpdateEmployee(string name, string address, int telephone, string email, int employee_id)
        {
            //update supplier set name = 'AMA', address ='Berlin', telephone = 774117538 where supplier_id = 2
            string query = string.Format("update employee set name = '{0}', address ='{1}', telephone = '{2}', email ='{3}' where employee_id ='{4}'", name, address, telephone, email,employee_id);

            int r = DataConnection.Instance.ExecuteNonQuery(query);
            return r > 0;
        }
        public bool DeleteEmployee(int employee_id)
        {
            //delete * from shoe where supplier_id = 3
            //delete * from supplier where supplier_id = 3
            string query = string.Format("delete from employee where employee_id = '{0}'", employee_id);
            int r = DataConnection.Instance.ExecuteNonQuery(query);

            return r > 0;
        }
        public List<Employee> GetEmployeeList()
        {
            List<Employee> employees = new List<Employee>();

            DataTable data = DataConnection.Instance.ExecuteQuery("SELECT * FROM Employee");
            foreach (DataRow item in data.Rows)
            {
                Employee employee = new Employee(item);
                employees.Add(employee);
            }
            return employees;
        }
    }
}
