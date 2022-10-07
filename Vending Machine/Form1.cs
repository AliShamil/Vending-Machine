using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Vending_Machine
{
    public partial class Form1 : Form
    {
        private DirectoryInfo directory = new($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Vending Machine");
        public Form1()
        {
            InitializeComponent();
        }

        private void fillPanel(Panel panel, Product product)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Label lbl)
                    lbl.Text = product.Name;
                if (control is TextBox txt)
                    txt.Text = $"{product.Price} AZN";
                
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

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


            fillPanel(panel_Cola, list[0]);
            fillPanel(panel_Water, list[1]);
            fillPanel(panel_Baltika, list[2]);
            fillPanel(panel_Crax, list[3]);
            fillPanel(panel_Doritos, list[4]);
            fillPanel(panel_FuseTea, list[5]);
            fillPanel(panel_macCofe, list[6]);
            fillPanel(panel_Nestle, list[7]);
            fillPanel(panel_Lays, list[8]);
            fillPanel(panel_Oreo, list[9]);
            fillPanel(panel_Snickers, list[10]);
            fillPanel(panel_Twix, list[11]);


            rbCola.Tag = list[0];
            rb_Water.Tag = list[1];
            rb_Baltika.Tag = list[2];
            rb_Crax.Tag = list[3];
            rb_Doritos.Tag = list[4];
            rb_FuseTea.Tag = list[5];
            rb_macCofe.Tag = list[6];
            rb_Nestle.Tag = list[7];
            rb_Lays.Tag = list[8];
            rb_Oreo.Tag = list[9];
            rb_Snickers.Tag = list[10];
            rb_Twix.Tag = list[11];



            foreach (Control control in General_Panel.Controls)
            {
                if (control is RadioButton rb)
                {
                    if ((rb.Tag as Product).Count>0)
                        rb.Text = $@"{(rb.Tag as Product).Count.ToString()} units";
                    else if((rb.Tag as Product).Count==0)
                        rb.Text = "Out of Stock !";


                    if (((decimal)(rb.Tag as Product).Price)>numericUpDown1.Value)
                        rb.Enabled = false;
                
                    if(rb.Text == "Out of Stock !")
                        rb.Enabled = false;

                }
                
            }
            if(btn_buy.Tag is null)
                btn_buy.Enabled = false;


        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            var FindMoney = (sender as RoundButton).Text.Split(" ");

            double.TryParse(FindMoney[0].ToString(), out var money);
            if(numericUpDown1.Value + ((decimal)money) < numericUpDown1.Maximum)
                numericUpDown1.Value += ((decimal)money);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control c in General_Panel.Controls)
            {
                if(c is RadioButton rb1)
                {
                    if (((decimal)(rb1.Tag as Product).Price)<numericUpDown1.Value && rb1.Text != "Out of Stock !")
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

            btn_buy.Tag = (sender as RadioButton).Tag;
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
            foreach (Control c in General_Panel.Controls)
            {
                if(c is RadioButton rb && rb.Checked)
                {
                    CurrentProduct = rb.Tag as Product;
                    --(rb.Tag as Product).Count;
                }
            }

                        foreach (Control control in General_Panel.Controls)
            {
                if (control is RadioButton rb)
                {
                    if ((rb.Tag as Product).Count>0)
                        rb.Text = $@"{(rb.Tag as Product).Count.ToString()} units";
                    else if((rb.Tag as Product).Count==0)
                        rb.Text = "Out of Stock !";


                    if (((decimal)(rb.Tag as Product).Price)>numericUpDown1.Value)
                        rb.Enabled = false;
                
                    if(rb.Text == "Out of Stock !")
                    {
                        rb.Enabled = false;
                        rb.Checked = false;
                    }

                }
                
            }
            StringBuilder sb = new StringBuilder();

            sb.Append($@" Product Info
Name: {CurrentProduct.Name}
Price: {CurrentProduct.Price} AZN

Entered Money: {txt_enteredAmount.Text}
Leftover Money: {txt_Leftover.Text}

Operation Time: {DateTime.Now}");

            MessageBox.Show(sb.ToString());

            if (!directory.Exists)
                Directory.CreateDirectory(directory.FullName);

            
                File.WriteAllText($@"{directory.FullName}\Operations.json", JsonSerializer.Serialize(sb.ToString()));

        }
    }
}