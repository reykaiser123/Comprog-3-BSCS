using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void item_Click(object sender, EventArgs e)
        {

        }

        private void computeBT_Click(object sender, EventArgs e)
        {
            string item = itemTB.Text;
            double discount = double.Parse(discountTB.Text);
            double price = double.Parse(priceTB.Text);
            int quantity = int.Parse(quantityTB.Text);

            Item Item = new Item(item,price,quantity);
            DiscountedItem discountedItem = new DiscountedItem(item, price, quantity, discount);


            label6.Text = discountedItem.getTotalPrice().ToString();
            



        }

        private void submitBT_Click(object sender, EventArgs e)
        {
            string item = itemTB.Text;
            double discount = double.Parse(discountTB.Text);
            double price = double.Parse(priceTB.Text);
            int quantity = int.Parse(quantityTB.Text);
            double payment = double.Parse(paymentTB.Text);

            Item Item = new Item(item, price, quantity);
            DiscountedItem discountedItem = new DiscountedItem(Item.getname(), Item.getprice(), Item.getquantity(), discount);

            discountedItem.setPayment(payment);
            label8.Text = discountedItem.getChange().ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

    class Item
    {
        string item_name {  get; set; }
        double item_price { get; set; }
        int item_quantity { get; set; }
        double total_price { get; set; }

        public Item(string name, double price, int quantity)
        {
            item_name = name;
            item_price = price;
            item_quantity = quantity;
        }

        public double getTotalPrice()
        {
            return total_price = item_price * item_quantity;
        }

        public void setPayment(double ammount)
        {
            return;
        }

        public string getname()
        {
            return item_name;
        }

        public int getquantity()
        {
            return item_quantity;
        }

        public double getprice()
        {
            return item_price;
        }
    }

    class DiscountedItem : Item
    {
        double item_discount {  get; set; }
        double discounted_price { get; set; }
        double payment_amount {  get; set; }
        double change {  get; set; }

        public DiscountedItem(string name, double price, int quantity, double discount): base(name,price,quantity)
        {
            item_discount = discount;
           
        }

        public double getTotalPrice()
        {
            double total = base.getTotalPrice();
           return discounted_price = total - (total * (item_discount / 100)) ;
        }

        public void setPayment(double amount)
        {
            payment_amount = amount;
        }   

        public double getChange()
        {
            return change = payment_amount - getTotalPrice();
        }
    }
}
