using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataMapper
{
    public class CustomerDataMapper
    {
        private static CustomerDataMapper instance;

        public static CustomerDataMapper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDataMapper();

                }
                return CustomerDataMapper.instance;
            }
            private set => CustomerDataMapper.instance = value;
        }


        public bool InsertCustomer(string name, string address, int telephone, string email)
        {
            string query = string.Format("insert into customer values ('{0}', '{1}', '{2}', '{3}'",
            name, address, telephone, email);

            int r = DataConnection.Instance.ExecuteNonQuery(query);
            return r > 0;
        }

        public bool UpdateCustomer(string name, string address, int telephone, string email)
        {
            //update supplier set name = 'AMA', address ='Berlin', telephone = 774117538 where supplier_id = 2
            string query = string.Format("update customer set name = '{0}', address = '{1}', telephone = '{2}', email = '{3}'", name, address, telephone, email);

            int r = DataConnection.Instance.ExecuteNonQuery(query);
            return r > 0;
        }

        public bool DeleteCustomer(int customer_id)
        {
            //delete * from shoe where supplier_id = 3
            //delete * from supplier where supplier_id = 3
            string query = string.Format("delete from shoe where customer_id = '{0}', customer_id))");
            int r = DataConnection.Instance.ExecuteNonQuery(query);

            query = string.Format("delete from customer where customer_id ='{0}', customer_id)");
            r = DataConnection.Instance.ExecuteNonQuery(query);

            return r > 0;
        }
    }
}
