using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_GroceryStore
{
    public partial class Form1 : Form
    {
        Fruits Fruits = new Fruits();
        FruitsInfo FruitsInfo = new FruitsInfo();
        BindingList<Fruits> FruitList;
        float subTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize FruitList
            FruitList = new BindingList<Fruits>();

            // assign StringBuilder objects to display
            txtDisplay_Apple.Text = FruitsInfo.AppleInfo();
            txtDisplay_Banana.Text = FruitsInfo.BananaInfo();
            txtDisplay_Orange.Text = FruitsInfo.OrangeInfo();
            txtDisplay_Peach.Text = FruitsInfo.PeachInfo();
            txtDisplay_Watermelon.Text = FruitsInfo.WatermelonInfo();

            // set the list as data source for grid
            fruitGrid.DataSource = FruitList;
        }

        private void btnAdd_Apple_Click(object sender, EventArgs e)
        {
            // instantiate apple object
            Fruits apple = new Fruits();
            int quantity = Int32.Parse(txtQty_Apple.Text);
            float price = quantity * 1.99f;

            apple.Name = "Apple";
            apple.Quantity = quantity;
            apple.Price = price.ToString("C");

            // add to list
            FruitList.Add(apple);

            // display message box
            MessageBox.Show("Item(s) successfully added!");

            // clear data fields
            txtQty_Apple.Clear();

            // add current price to subtotal and appleTotal
            subTotal += price;
        }

        private void btnAdd_Banana_Click(object sender, EventArgs e)
        {
            // instantiate banana object
            Fruits banana = new Fruits();
            int quantity = Int32.Parse(txtQty_Banana.Text);
            float price = quantity * 2.49f;

            banana.Name = "Banana";
            banana.Quantity = quantity;
            banana.Price = price.ToString("C");

            // add to list
            FruitList.Add(banana);

            // display message box
            MessageBox.Show("Item(s) successfully added!");

            // clear data fields
            txtQty_Banana.Clear();

            // add current price to subtotal
            subTotal += price;
        }

        private void btnAdd_Orange_Click(object sender, EventArgs e)
        {
            // instantiate orange object
            Fruits orange = new Fruits();
            int quantity = Int32.Parse(txtQty_Orange.Text);
            float price = quantity * 0.99f;

            orange.Name = "Orange";
            orange.Quantity = quantity;
            orange.Price = price.ToString("C");

            // add to list
            FruitList.Add(orange);

            // display message box
            MessageBox.Show("Item(s) successfully added!");

            // clear data fields
            txtQty_Orange.Clear();

            // add current price to subtotal
            subTotal += price;
        }

        private void btnAdd_Peach_Click(object sender, EventArgs e)
        {
            // instantiate peach object
            Fruits peach = new Fruits();
            int quantity = Int32.Parse(txtQty_Peach.Text);
            float price = quantity * 1.29f;

            peach.Name = "Peach";
            peach.Quantity = quantity;
            peach.Price = price.ToString("C");

            // add to list
            FruitList.Add(peach);

            // display message box
            MessageBox.Show("Item(s) successfully added!");

            // clear data fields
            txtQty_Peach.Clear();

            // add current price to subtotal
            subTotal += price;
        }

        private void btnAdd_Watermelon_Click(object sender, EventArgs e)
        {
            // instantiate watermelon object
            Fruits watermelon = new Fruits();
            int quantity = Int32.Parse(txtQty_Watermelon.Text);
            float price = quantity * 3.99f;

            watermelon.Name = "Watermelon";
            watermelon.Quantity = quantity;
            watermelon.Price = price.ToString("C");

            // add to list
            FruitList.Add(watermelon);

            // display message box
            MessageBox.Show("Item(s) successfully added!");

            // clear data fields
            txtQty_Watermelon.Clear();

            // add current price to subtotal
            subTotal += price;
        }

        // delete items in cart
        private void btnRemove_Click(object sender, EventArgs e)
        {
            // remove selected grid
            FruitList.RemoveAt(fruitGrid.CurrentRow.Index);

            // display confirmation message
            MessageBox.Show("Item successfully removed!");

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

            float tax = subTotal * .10f;

            DialogResult result = MessageBox.Show($"Subtotal: \t{subTotal}\n" + $"Tax: \t\t{tax}\n" +
             $"Total: \t\t{subTotal + tax}", "Submit Order", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes) 
            {
                FruitList = new BindingList<Fruits>();

                MessageBox.Show("Transaction complete!");

                fruitGrid.DataSource = FruitList;
            }
            else
            {
                MessageBox.Show("Cancelled.");
            }
        }
    }
}
