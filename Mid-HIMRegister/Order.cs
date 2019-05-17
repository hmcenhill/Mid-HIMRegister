using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_HIMRegister
{
    public class Order
    {
        public static int LastOrder;
        
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public List<OrderLine> OrderList { get; set; }
        public PaymentType PaymentType { get; set; }
        public float SubTotalPrice { get; set; }
        public float GrandTotalPrice { get; set; }
        public float TaxRate { get; set; }

        public Order()
        {
            LastOrder++;
            OrderID = LastOrder;
            OrderList = new List<OrderLine>();
            OrderStatus = "Open";
            OrderDate = DateTime.Now;
        }
        public void AddItem(Product item, int qty)
        {
            OrderList.Add(new OrderLine(item, qty));
        }
        public void TotalBill(float tax)
        {
            TaxRate = tax;
            SubTotalPrice = 0f;
            foreach(var product in OrderList)
            {
                SubTotalPrice += (product.Item.Price * product.Qty);
            }
            GrandTotalPrice = SubTotalPrice * (1 + tax);
        }
        public void Pay(PaymentType ptype)
        {
            switch (ptype)
            {
                case PaymentType.Cash:
                    PayCash();
                    break;
                case PaymentType.Check:
                    PayCheck();
                    break;
                case PaymentType.Credit:
                    PayCredit();
                    break;
                default:
                    Console.WriteLine("Unknown payment type");
                    break;
            }
            CloseOrder();
        }
        private void PayCash()
        {

        }
        private void PayCheck()
        {

        }
        private void PayCredit()
        {

        }
        public void CloseOrder()
        {
            PrintReceipt();
            OrderStatus = "Closed";
        }
        public void PrintReceipt()
        {
            Console.WriteLine($"{OrderID}");
            foreach(var lineItem in OrderList)
            {
                Console.WriteLine($"{lineItem.Item.Description} - Qty: {lineItem.Qty}");
            }
            Console.WriteLine($"Subtotal: {SubTotalPrice}");
            Console.WriteLine($"Taxes:    {SubTotalPrice * TaxRate}");
            Console.WriteLine($"Subtotal: {GrandTotalPrice}");
            Console.WriteLine($"Order {OrderID}: Closed. Thank you for shopping.");
        }

    }
}
