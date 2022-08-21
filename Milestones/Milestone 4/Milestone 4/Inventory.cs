using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaster
{
    public class Inventory
    {
        public static List<Part> AllParts = new List<Part>();
        public static int CurrPartIndex { get; set; }
        public static Part CurrentPart { get; set; }
        public static Part CurrentAssocPart
        { get; set; }
        private static int nextPartID = 0;

        public static int GetNextPartID()
        {
            return nextPartID++;
        }
        // part methods
        public static Part FindPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.GetPartId() == partID)
                {
                    return part;
                }
            }
            return null;
        }
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }
        public static void EditPart(int partID, Part replacement)
        {
            Part oldPart = AllParts.Where(i => i.PartID == partID).First();
            var index = AllParts.IndexOf(oldPart);

            if (index != -1)
                AllParts[index] = replacement;

            oldPart = replacement;

        }
        public static bool DeletePart(Part part)
        {
            try
            {
                AllParts.Remove(part);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void UpdatePart(int partID, Part part)
        {
            Inventory.DeletePart(part);
            Inventory.AddPart(part);
        }
    }
}