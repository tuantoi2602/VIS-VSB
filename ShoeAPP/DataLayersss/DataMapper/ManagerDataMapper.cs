using DataLayersss.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayersss.DataMapper
{
    public class ManagerDataMapper
    {
        private static ManagerDataMapper instance;

        public static ManagerDataMapper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManagerDataMapper();

                }
                return ManagerDataMapper.instance;
            }
            private set => ManagerDataMapper.instance = value;
        }
        public List<Manager> GetManagersList()
        {
            return XMLProvider.Instance.ReadManager();
        }
    }
}
