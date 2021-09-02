using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GeneralStoreAPI.Models
{
    public class TransactionListItem
    {
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int NumberPurchased { get; set; }
        public decimal TotalCost { get; set; }
    }
}