using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayersss.DataMapper;

namespace BusinessLayer.Services
{
    public class ShoeService
    {
        private static ShoeService instance;
        public static ShoeService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ShoeService();

                }
                return ShoeService.instance;
            }
            private set => ShoeService.instance = value;
        }

        public int customer_id { get; set; }

        public bool InsertShoe(string name, int size, string description, int price, int customer_id, int brand_id, int supplier_id)
        {

            return ShoeDataMapper.Instance.InsertShoe(name, size, description, price, customer_id, brand_id, supplier_id);
        }
        public bool UpdateShoe(string name, int size, string description, int price, int customer_id, int brand_id, int supplier_id, int shoe_id)
        {

            return ShoeDataMapper.Instance.UpdateShoe(name, size, description, price, customer_id, brand_id, supplier_id, shoe_id);
        }
        public bool SelectShoe(int shoe_id, string name, int size, string description, int price, int customer_id, int brand_id, int supplier_id)
        {

            return ShoeDataMapper.Instance.SelectShoe(shoe_id, name, size, description, price, customer_id, brand_id, supplier_id);
        }
        public bool DeleteShoe(int shoe_id)
        {

            return ShoeDataMapper.Instance.DeleteShoe(shoe_id);
        }
        public List<DataLayersss.DTO.Shoe> GetShoeList()
        {
            return ShoeDataMapper.Instance.GetShoeList();
        }
        public bool FindShoe(string name)
        {
            return ShoeDataMapper.Instance.FindShoe(name);
        }
    }
}
