using DataLayer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataMapper
{
    public class ShoeDataMapper
    {
        private static ShoeDataMapper instance;

        public static ShoeDataMapper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShoeDataMapper();

                }
                return ShoeDataMapper.instance;
            }
            private set => ShoeDataMapper.instance = value;
        }

 
        public bool InsertShoe(string name, int size, string description, int price, int customer_id, int brand_id, int supplier_id)
        {
            //insert into shoe values ('Airmax 192',12,'Big size, full color',50,1,1,1);
            string query = string.Format("insert into shoe values ('{0}','{1}', '{2}', '{3}','{4}','{5}','{6}')",
            name, size, description, price, customer_id, brand_id, supplier_id);

            int r = DataConnection.Instance.ExecuteNonQuery(query);
            return r > 0;
        }
        public bool SelectShoe(int shoe_id, string name, int size, string description, int price, int customer_id, int brand_id, int supplier_id)
        {
            //insert into shoe values ('Airmax 192',12,'Big size, full color',50,1,1,1);
            string query = string.Format("select '{0}','{1}', '{2}', '{3}','{4}','{5}','{6}','{7}' from shoe ",
            shoe_id, name, size, description, price, customer_id, brand_id, supplier_id);

            int r = DataConnection.Instance.ExecuteNonQuery(query);
            return r > 0;
        }
        public bool UpdateShoe(string name, int size, string description, int price, int customer_id, int brand_id, int supplier_id, int shoe_id)
        {
            //update supplier set name = 'AMA', address ='Berlin', telephone = 774117538 where supplier_id = 2
            string query = string.Format("update shoe set name = '{0}', size ='{1}', description = '{2}', price ='{3}', customer_id='{4}',brand_id='{5}',supplier_id='{6}' where shoe_id ='{7}'", name, size, description, price, customer_id, brand_id, supplier_id, shoe_id);

            int r = DataConnection.Instance.ExecuteNonQuery(query);
            return r > 0;
        }

        public bool DeleteShoe(int shoe_id)
        {
            //delete * from shoe where supplier_id = 3
            //delete * from supplier where supplier_id = 3
            string query = string.Format("delete from shoe where shoe_id = '{0}'", shoe_id);
            int r = DataConnection.Instance.ExecuteNonQuery(query);

            return r > 0;
        }
        public List<Shoe> GetShoeList()
        {
            List<Shoe> shoes = new List<Shoe>();

            DataTable data = DataConnection.Instance.ExecuteQuery("SELECT * FROM Shoe");
            foreach (DataRow item in data.Rows)
            {
                Shoe shoe = new Shoe(item);
                shoes.Add(shoe);
            }
            return shoes;
        }
        public bool FindShoe(string name)
        {
            //select * from shoe where name like 'name%';
            string query = string.Format("select * from shoe where name like '{0}%' ", name);

            int r = DataConnection.Instance.ExecuteNonQuery(query);
            return r > 0;
        }
    }
}
