using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ItemStore.Domain
{
    public class Item
    {
        [DisplayName("Item ID")]
        public string ID { get; set; }
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        [DisplayName("Category")]
        public string Category { get; set; }
        [DisplayName("Quantity")]
        public int Quantity { get; set; }
        [DisplayName("Unit Price")]
        public decimal Uprice { get; set; }
        private decimal _tprice;
        [DisplayName("Total Price")]
        public decimal Tprice { set { _tprice = Quantity * Uprice; } get { return _tprice; } }
    }
}
