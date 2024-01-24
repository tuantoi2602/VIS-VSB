using DataLayersss.DataMapper;
using DataLayersss.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class ManagerService
    {
        private static ManagerService instance;

        public static ManagerService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ManagerService();
                }
                return ManagerService.instance;
            }
            private set => ManagerService.instance = value;
        }

        public List<Manager> ReadDataManager()
        {
            return ManagerDataMapper.Instance.GetManagersList();
        }
    }
}

