using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaster
{
    public abstract class Part
    {
        //set variables
        private int partID;
        private string name;
        private double cost;
        private double sellPrice;
        private int quantity;
        private int min;
        private int max;
        private string vendor;
        private string binLocation;
        //setter and getters
        public int PartID
        {
            get { return GetPartId(); }
            set { SetPartId(value); }
        }
        public string Name
        {
            get { return GetName(); }
            set { SetName(value); }
        }
        public double Cost
        {
            get { return GetCost(); }
            set { SetCost(value); }
        }
        public double SellPrice
        {
            get { return GetSellPrice(); }
            set { SetSellPrice(value); }
        }
        public int Quantity
        {
            get { return GetQuantity(); }
            set { SetQuantity(value); }
        }
        public int Min
        {
            get { return GetMin(); }
            set { SetMin(value); }
        }
        public int Max
        {
            get { return GetMax(); }
            set { SetMax(value); }
        }
        public string Vendor
        {
            get { return GetVendor(); }
            set { SetVendor(value); }
        }
        public string BinLocation
        {
            get { return GetBinLocation(); }
            set { SetBinLocation(value); }
        }
        public Part(string name, double cost, double sellPrice, int quantity, int min, int max, string vendor, string binLocation) : this(Inventory.GetNextPartID(), name, cost, sellPrice, quantity, min, max, vendor, binLocation)
        {

        }
        public Part(int partID, string name, double cost, double sellPrice, int quantity, int min, int max, string vendor, string binLocation)
        {
            PartID = partID;
            Name = name;
            Cost = cost;
            SellPrice = sellPrice;
            Quantity = quantity;
            Min = min;
            Max = max;
            Vendor = vendor;
            BinLocation = binLocation;
        }
        public void SetName(string name)
        { this.name = name; }
        public string GetName()
        { return name; }
        public void SetCost(double cost)
        {
            if (cost <= 0)
            {
                throw new Exception("Price entered is zero or less");
            }
            this.cost = cost;
        }
        public double GetCost()
        { return cost; }
        public void SetSellPrice(double sellPrice)
        {
            if (sellPrice <= 0)
            {
                throw new Exception("Price entered is zero or less");
            }
            this.sellPrice = sellPrice;
        }
        public double GetSellPrice()
        { return sellPrice; }
        public void SetQuantity(int quantity)
        { this.quantity = quantity; }
        public int GetQuantity()
        { return quantity; }
        public void SetMin(int min)
        { this.min = min; }
        public int GetMin()
        { return min; }
        public void SetMax(int max)
        {
            if (max < min)
            {
                throw new Exception("Max entered is less than Min");
            }
            this.max = max;
        }
        public int GetMax()
        { return max; }
        public void SetVendor(string vendor)
        { this.vendor = vendor; }
        public string GetVendor()
        { return vendor; }
        public void SetBinLocation(string binLocation)
        { this.binLocation = binLocation; }
        public string GetBinLocation()
        { return binLocation; }
        public void SetPartId(int partID)
        { this.partID = partID; }
        public int GetPartId()
        { return partID; }
    }
}
