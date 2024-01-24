using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayersss.DTO
{
    public class Brand
    {
        private int brand_id;
        private string name;
        public Brand(DataRow row)
        {
            this.brand_id = (int)row["brand_id"];
            this.name = row["name"].ToString();

        }
        public Brand(int brand_id, string name)
        {
            this.brand_id = brand_id;
            this.name = name;
        }

        public int Brand_id { get => brand_id; set => brand_id = value; }
        public string Name { get => name; set => name = value; }
    }
}
