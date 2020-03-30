using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace XML
{
    class Menu
    {
        private string path = @"E:\Folder\Data.xml";
        XDocument xmlDocument;

        public void Fill() {
            xmlDocument = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XComment("This is a test comment"),
            new XElement("Accounts", from contacts in Accounts.GetAllSContacts()
                                     select new XElement("Contact", new XAttribute("Id", contacts.Id),
                                     new XElement("Name", contacts.Name),
                                     new XElement("Login", contacts.Login),
                                     new XElement("Password", contacts.Password),
                                     new XElement("Date", contacts.Date))));
            xmlDocument.Save(path);
        }

        public void Show() {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNodeList elemList = doc.GetElementsByTagName("Name");
            for (int i = 0; i < elemList.Count; i++)
            {
                Console.Write($"Name of account{i + 1}: ");
                Console.WriteLine(elemList[i].InnerXml);
            }
        }      
          public void Add()
        {
            xmlDocument.Element("Accounts").Add(
                 new XElement("Contact", new XAttribute("Id", 2),
                                         new XElement("Name", "Bill"),
                                         new XElement("Lodin", "Bilon"),
                                         new XElement("Password", "1233djsf43"),
                                         new XElement("Data", "03.03.2020")));
            xmlDocument.Save(path);
        }
 
        public void Remove()
        {
            Console.WriteLine("Enter id for delete :");
            string val = Console.ReadLine();
            xmlDocument.Root.Elements().Where(x => x.Attribute("Id").Value == val).Remove();
            xmlDocument.Save(path);
        }

        public void ImportHtml()
        {
            Console.WriteLine("IMPORT XLS-FILE in HTML:");
            XDocument xmlDocument = XDocument.Load(path);
            XDocument result = new XDocument(new XElement("table", new XAttribute("border", 2),
                new XElement("thead",
                    new XElement("tr",
                        new XElement("th", "Id"),
                        new XElement("th", "Name"),
                        new XElement("th", "Login"),
                        new XElement("th", "Password"),
                        new XElement("th", "Date"))),
                             new XElement("tbody",
                             from account in xmlDocument.Descendants("Accounts")
                             select new XElement("tr",
                             new XElement("td", account.Attribute("Id").Value),
                             new XElement("td", account.Element("Name").Value),
                             new XElement("td", account.Element("Login").Value),
                             new XElement("td", account.Element("Password").Value),
                             new XElement("td", account.Element("Date").Value)))));
            result.Save(@"E:\Folder\index.html");
        }

        public void Valid() {
            XmlSchemaSet schema = new XmlSchemaSet();
            string schemaPath = @"D:\шаг\C#\XML\XML\XMLSchema.xsd";
            schema.Add("", schemaPath);
            XDocument xmlDocument5 = XDocument.Load(path);

            bool valid = false;

            xmlDocument5.Validate(schema, (s, e) =>
            {
                Console.WriteLine(e.Message);
                valid = true;
            });

            if (!valid)
            {
              
                Console.WriteLine("Validation success!");
            }
            else
            {
                Console.WriteLine("Validation failed!");
            }
        }
    }
}
