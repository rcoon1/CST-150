using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaster
{
    //Ryan Coon
    //August 14, 2022
    //CST-150
    //This is my own work along with the help of stack overflow forums
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //add fill in parts
            Inventory.AddPart(new purchase("Load Sensor", 22.99, 74.54, 5, 2, 6, "Terex", "A14"));
            Inventory.AddPart(new purchase("Load Sensor", 22.99, 74.54, 5, 2, 6, "JLG", "B24"));
            Inventory.AddPart(new purchase("Load Sensor", 22.99, 74.54, 5, 2, 6, "JLG", "B5"));            
            Inventory.AddPart(new purchase("Load Sensor", 22.99, 74.54, 5, 2, 6, "Case", "F12"));
            Inventory.AddPart(new purchase("Load Sensor", 22.99, 74.54, 5, 2, 6, "Bobcat", "Z5"));
            Inventory.AddPart(new purchase("Load Sensor", 22.99, 74.54, 5, 2, 6, "Snorkel", "D45"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
