using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InventoryMaintenance
{
    /// <summary>
    /// Updated by: Nigel Mansell
    /// Date: 3/27/17
    /// This class takes in an xml file, reads it, and writes it.
    /// </summary>
    public static class InvItemDB
    {
        private const string Path = @"..\..\InventoryItems.xml";

        /// <summary>
        /// This method reads the xml file from the path and uses settings
        /// to look for whitespace and comments.
        /// </summary>
        /// <returns> the list </returns>
        public static List<InvItem> GetItems()
        {
            // creates the list
            List<InvItem> items = new List<InvItem>();

            // Reads the XML file into the List<InvItem> object.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            if (xmlIn.ReadToDescendant("Item"))
            {
                do
                {
                    InvItem item = new InvItem();
                    xmlIn.ReadStartElement("Item");
                    item.ItemNo =
                        xmlIn.ReadElementContentAsInt();
                    item.Description =
                        xmlIn.ReadElementContentAsString();
                    item.Price =
                        xmlIn.ReadElementContentAsDecimal();
                    items.Add(item);
                }
                while (xmlIn.ReadToNextSibling("Item"));
            }
            xmlIn.Close();
            return items;
        }

        /// <summary>
        /// This method writes the xml file using a path and uses indention.
        /// </summary>
        /// <param name="items"> the list</param>
        public static void SaveItems(List<InvItem> items)
        {
            // Writes the List<InvItems> object to an XML file.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Items");

            foreach (InvItem item in items)
            {
                xmlOut.WriteStartElement("Item");
                xmlOut.WriteElementString("ItemNo", Convert.ToString(item.ItemNo));
                xmlOut.WriteElementString("Description", item.Description);
                xmlOut.WriteElementString("Price", Convert.ToString(item.Price));
                xmlOut.WriteEndElement();
            }
            xmlOut.WriteEndElement();
            xmlOut.Close();

            
        }
    }
}
