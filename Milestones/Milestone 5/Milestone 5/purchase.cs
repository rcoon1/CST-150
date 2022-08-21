namespace InventoryMaster
{
    internal class purchase : Part
    {
        public purchase(string name, double cost, double sellPrice, int quantity, int min, int max, string vendor, string binLocation) : base(name, cost, sellPrice, quantity, min, max, vendor, binLocation)
        {
        }
    }
}