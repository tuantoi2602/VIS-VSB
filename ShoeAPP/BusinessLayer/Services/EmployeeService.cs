using DataLayersss.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class EmployeeService
    {
        private static EmployeeService instance;
        public static EmployeeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeService();

                }
                return EmployeeService.instance;
            }
            private set => EmployeeService.instance = value;
        }

        public int customer_id { get; set; }

        public bool InsertEmployee(string name, string address, int telephone, string email)
        {

            return EmployeeDataMapper.Instance.InsertEmployee(name, address, telephone, email);
        }
        public bool UpdateEmployee(string name, string address, int telephone, string email, int employee_id)
        {

            return EmployeeDataMapper.Instance.UpdateEmployee(name, address, telephone, email, employee_id);
        }
        public bool DeleteEmployee(int employee_id)
        {

            return EmployeeDataMapper.Instance.DeleteEmployee(employee_id);
        }
        public List<DataLayersss.DTO.Employee> GetEmployees()
        {
            return EmployeeDataMapper.Instance.GetEmployeeList();
        }
    }
}
