using DataLayersss.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace DataLayersss
{
    public class XMLProvider
    {
        private static XMLProvider instance;

        public static XMLProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new XMLProvider();
                return XMLProvider.instance;
            }
            private set
            {
                XMLProvider.instance = value;
            }
        }
        private XmlDocument doc;

        public List<Manager> ReadManager()
        {
            List<Manager> managers = new List<Manager>();
            this.doc = new XmlDocument();
            string solutiondir = AppDomain.CurrentDomain.BaseDirectory + @"\Manager.xml";
            this.doc.Load(solutiondir);
            foreach (XmlNode coinNode in this.doc.SelectNodes("/Managers/Manager"))
            {

                XmlNode idNode = coinNode.SelectSingleNode("Id");
                XmlNode nameNode = coinNode.SelectSingleNode("Name");
                XmlNode addressNode = coinNode.SelectSingleNode("Address");
                XmlNode emailNode = coinNode.SelectSingleNode("Email");
                XmlNode telephoneNode = coinNode.SelectSingleNode("Telephone");
                int id = 0;
                string name = null;
                string address = null;
                string email = null;
                int telephone = 0;

                if (idNode != null)
                {
                    id = int.Parse(idNode.Attributes["value"].Value);
                }
                if (addressNode != null)
                {
                    address = addressNode.Attributes["value"].Value;
                }
                if (nameNode != null)
                {
                    name = nameNode.Attributes["value"].Value;
                }
                if (telephoneNode != null)
                {
                    telephone = int.Parse(telephoneNode.Attributes["value"].Value);
                }

                if (emailNode != null)
                {
                    email = emailNode.Attributes["value"].Value;
                }
                Manager manager = new Manager(id, name, address, email, telephone);

                managers.Add(manager);

            }
            return managers;
        }
    }
}
