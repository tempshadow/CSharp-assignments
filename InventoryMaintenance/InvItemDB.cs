using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryMaintenance
{
    /// <summary>
    /// Modified by Nigel Mansell
    /// Date: 3/26/17
    /// Reads in information from a text document, the writes if the user adds
    /// or deletes.
    /// </summary>
    public static class InvItemDB
    {
        private const string Path = @"C:\Users\nigel\Desktop\InventoryMaintenance\" + "InventoryItems.txt";
        /// <summary>
        /// This method uses a path to a file to be read. Reads a line based on
        /// a delimiter and stores in a list
        /// </summary>
        /// <returns> the item list </returns>
        public static List<InvItem> GetItems()
        {
            
            // create the list
            List<InvItem> items = new List<InvItem>();
            // StreamReader uses a file stream to open or create a file,
            // uses the path, and reads the file.
            StreamReader textIn =
                new StreamReader(
                    new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));
            // loops through and reads each line, checking for the delimiter,
            // and storing accordingly into the items list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                InvItem item = new InvItem();
                item.ItemNo = Convert.ToInt32(columns[0]);
                item.Description = columns[1];
                item.Price = Convert.ToDecimal(columns[2]);
                items.Add(item);
                
            }
            textIn.Close();
            return items;
        }

        /// <summary>
        /// This method use a path to a file and writes it using the items list
        /// </summary>
        /// <param name="items"></param>
        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to a text file.
            StreamWriter textOut =
                new StreamWriter(
                    new FileStream(Path, FileMode.Create, FileAccess.Write));
            foreach (InvItem item in items)
            {
                textOut.Write(item.ItemNo + "|");
                textOut.Write(item.Description + "|");
                textOut.WriteLine(item.Price);
            }
            textOut.Close();
        }
    }
}
