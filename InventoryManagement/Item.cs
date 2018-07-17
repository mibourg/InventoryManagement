using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    class Item
    {
        private string _name;
        private double _price;
        private int _supply;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public int Supply
        {
            get
            {
                return _supply;
            }
            set
            {
                _supply = value;
            }
        }

        public Item(string name, double price, int supply)
        {
            _name = name;
            _price = price;
            _supply = supply;
        }
    }
}
