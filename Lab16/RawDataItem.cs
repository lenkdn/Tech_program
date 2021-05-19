using System;

namespace Lab16
{
    class RawDataItem
    {
        public String Name { get; set; }
        public String Group { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public float FinalPrice
        {
            get { return Price - (Price * Discount / 100); }
        }
    }
}
