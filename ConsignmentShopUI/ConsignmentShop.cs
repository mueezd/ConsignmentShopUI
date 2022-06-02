using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsaignmentShopLibrary;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorsBinding = new BindingSource();
        private decimal storeProfit = 0;



        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            itemBinding.DataSource = store.Items;


            itemBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            listBoxItemList.DataSource = itemBinding;


            listBoxItemList.DisplayMember = "Display";
            listBoxItemList.ValueMember = "Display";


            cartBinding.DataSource = shoppingCartData;
            listBoxShoppingCart.DataSource = cartBinding;


            listBoxShoppingCart.DisplayMember = "Display";
            listBoxShoppingCart.ValueMember = "Display";

            vendorsBinding.DataSource = store.Vendors;
            listBoxVendor.DataSource = vendorsBinding;

            listBoxVendor.DisplayMember = "Display";
            listBoxVendor.ValueMember = "Display";
        }

        private void SetupData()
        {
            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Sue", LastName = "Jones" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "A book about a whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "A tale of twoo cities",
                Description = "A book about a revulaton",
                Price = 3.80M,
                Owner = store.Vendors[1]
            });

            store.Items.Add(new Item
            {
                Title = "Harry Potter Book1",
                Description = "A book about boy",
                Price = 7.20M,
                Owner = store.Vendors[0]
            });

            store.Items.Add(new Item
            {
                Title = "Pairats of the carrabian",
                Description = "Book abot pairats",
                Price = 9.50M,
                Owner = store.Vendors[1]
            });

            store.Name = "Seconds are Batter";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            // Figure out what is selected from the item list
            // Copy that item to the shopping cart
            // De we remove the item form the item list? - no

            Item selectedItem = (Item)listBoxItemList.SelectedItem;

            shoppingCartData.Add(selectedItem);

            cartBinding.ResetBindings(false);
        }

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            // Mark each item in the card as sold;
            // Clear the cart

            foreach(Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfit += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();

            itemBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();


            lblStoreProfitText.Text = String.Format("${0}",storeProfit);


            cartBinding.ResetBindings(false);
            itemBinding.ResetBindings(false);
            vendorsBinding.ResetBindings(false);
        }
    }
}
