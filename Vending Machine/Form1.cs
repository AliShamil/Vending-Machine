using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;


namespace Vending_Machine
{
    public partial class Form1 : Form
    {
        private DirectoryInfo directory = new($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Vending Machine");
        static string format = @"[{Timestamp:HH:mm:ss} {Level:u3}] {Message} {Exception} {MachineName} {NewLine}";
        public Form1()
        {
            InitializeComponent();

        }

        
        private void FillControl(ProductControl productComtrol, RadioButton rb, Product product)
        {
            productComtrol.lbl_product_name.Text = product.Name;
            productComtrol.txt_product_price.Text =  $"{product.Price} AZN";
            rb.Tag = product;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> list = new List<Product>()
            {
                new("Cola",25,1.8),
                new("Water",12,1),
                new("Baltika",2,2.2),
                new("Crax",6,0.8),
                new("Doritos",6,2.50),
                new("FuseTea",9,1.1),
                new("Mac Coffe",4,3),
                new("Nestle",14,2),
                new("Lays",3,2.7),
                new("Oreo",5,3.1),
                new("Snickers",0,0.9),
                new("Twix",22,0.9),
            };


    
            FillControl(productPlace1, rbP1, list[0]);
            FillControl(productPlace2, rbP2, list[1]);
            FillControl(productPlace3, rbP3, list[2]);
            FillControl(productPlace4, rbP4, list[3]);
            FillControl(productPlace5, rbP5, list[4]);
            FillControl(productPlace6, rbP6, list[5]);
            FillControl(productPlace7, rbP7, list[6]);
            FillControl(productPlace8, rbP8, list[7]);
            FillControl(productPlace9, rbP9, list[8]);
            FillControl(productPlace10, rbP10, list[9]);
            FillControl(productPlace11, rbP11, list[10]);
            FillControl(productPlace12, rbP12, list[11]);
            
  



            foreach (Control control in General_Panel.Controls)
            {
                if (control is RadioButton rb)
                {
                    if ((rb.Tag as Product).Count>0)
                        rb.Text = $@"{(rb.Tag as Product).Count.ToString()} units";
                    else if ((rb.Tag as Product).Count==0)
                        rb.Text = "Out of Stock !";


                    if (((decimal)(rb.Tag as Product).Price)>numericUpDown1.Value)
                        rb.Enabled = false;

                    if (rb.Text == "Out of Stock !")
                        rb.Enabled = false;

                }

            }
            if (btn_buy.Tag is null)
                btn_buy.Enabled = false;


        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var FindMoney = (sender as RoundButton)?.Text.Split(" ");

            double.TryParse(FindMoney[0].ToString(), out var money);
            if (numericUpDown1.Value + ((decimal)money) < numericUpDown1.Maximum)
                numericUpDown1.Value += ((decimal)money);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control c in General_Panel.Controls)
            {
                if (c is RadioButton rb1)
                {
                    if (((decimal)(rb1.Tag as Product).Price)<=numericUpDown1.Value && rb1.Text != "Out of Stock !")
                        rb1.Enabled = true;
                    else
                    {
                        rb1.Checked = false;
                        rb1.Enabled = false;
                    }
                }

                if (c is RadioButton rb && rb.Checked)
                    rb_CheckedChanged(rb, e);
            }
            txt_enteredAmount.Text = $"{numericUpDown1.Value} AZN";
        }


        private void rb_CheckedChanged(object sender, EventArgs e)
        {


            if ((sender as RadioButton).Checked)
            {

                btn_buy.Tag = (sender as RadioButton)?.Tag;
                btn_buy.Enabled = true;
                txt_Leftover.Text = $"{(numericUpDown1.Value - ((decimal)((sender as RadioButton).Tag as Product).Price)).ToString()} AZN";
            }
            else
            {
                btn_buy.Enabled = false;
                txt_Leftover.Text ="0.00 AZN";
            }
        }



        private void btn_buy_Click(object sender, EventArgs e)
        {
            Product CurrentProduct = null;
            Info info = new();
            foreach (Control c in General_Panel.Controls)
            {
                if (c is RadioButton rb && rb.Checked)
                {
                    CurrentProduct = rb.Tag as Product;
                    --(rb.Tag as Product).Count;
                }
            }

            foreach (Control control in General_Panel.Controls)
            {
                if (control is RadioButton rb)
                {
                    if ((rb.Tag as Product)?.Count>0)
                        rb.Text = $@"{(rb.Tag as Product)?.Count.ToString()} units";
                    else if ((rb.Tag as Product)?.Count==0)
                        rb.Text = "Out of Stock !";


                    if (((decimal)(rb.Tag as Product).Price)>numericUpDown1.Value)
                        rb.Enabled = false;

                    if (rb.Text == "Out of Stock !")
                    {
                        rb.Enabled = false;
                        rb.Checked = false;
                    }

                }

            }
            StringBuilder sb = new StringBuilder();

            sb.Append($@" Product Info
Name: {CurrentProduct?.Name}
Price: {CurrentProduct?.Price} AZN

Entered Money: {txt_enteredAmount.Text}
Leftover Money: {txt_Leftover.Text}

Operation Time: {DateTime.Now}");

            MessageBox.Show(sb.ToString());

            if (!directory.Exists)
                Directory.CreateDirectory(directory.FullName);
            if(CurrentProduct is not null)
            {

            info.Name = CurrentProduct?.Name;
            info.Price = CurrentProduct.Price;
            info.EnteredAmount = txt_enteredAmount.Text;
            info.Leftover = txt_Leftover.Text;
            info.OperationTime = DateTime.Now;
            }
            
            File.WriteAllText($@"{directory.FullName}\LastOperation.json", JsonSerializer.Serialize(info));
        }
    }
}