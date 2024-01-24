using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayersss.DataMapper
{
    public class SupplierDataMapper
    {
        private static SupplierDataMapper instance;

        public static SupplierDataMapper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SupplierDataMapper();

                }
                return SupplierDataMapper.instance;
            }
            private set => SupplierDataMapper.instance = value;
        }


        public bool InsertSupplier(string name, string address, int telephone)
        {
            string query = string.Format("insert into supplier values ('{0}', '{1}', '{2}'",
            name, address, telephone);

            int r = DataConnection.Instance.ExecuteNonQuery(query);
            return r > 0;
        }

        public bool UpdateSupplier(string name, string address, int telephone)
        {
            //update supplier set name = 'AMA', address ='Berlin', telephone = 774117538 where supplier_id = 2
            string query = string.Format("update supplier set name = '{0}', address = '{1}', telephone = '{2}'",name, address, telephone);

            int r = DataConnection.Instance.ExecuteNonQuery(query);
            return r > 0;
        }

        public bool DeleteSupplier(int supplier_id)
        {
            //delete * from shoe where supplier_id = 3
            //delete * from supplier where supplier_id = 3
            string query = string.Format("delete from shoe where supplier_id = '{0}', supplier_id))");
            int r = DataConnection.Instance.ExecuteNonQuery(query);

            query = string.Format("delete from supplier where supplier_id ='{0}', supplier_id)");
            r = DataConnection.Instance.ExecuteNonQuery(query);

            return r > 0;
        }

    }
}
