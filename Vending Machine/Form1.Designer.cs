namespace Vending_Machine
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbP1 = new System.Windows.Forms.RadioButton();
            this.rbP2 = new System.Windows.Forms.RadioButton();
            this.rbP3 = new System.Windows.Forms.RadioButton();
            this.rbP4 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.roundButton1 = new Vending_Machine.RoundButton();
            this.roundButton2 = new Vending_Machine.RoundButton();
            this.roundButton3 = new Vending_Machine.RoundButton();
            this.roundButton4 = new Vending_Machine.RoundButton();
            this.roundButton5 = new Vending_Machine.RoundButton();
            this.roundButton6 = new Vending_Machine.RoundButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_buy = new System.Windows.Forms.Button();
            this.txt_enteredAmount = new System.Windows.Forms.TextBox();
            this.txt_Leftover = new System.Windows.Forms.TextBox();
            this.General_Panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.productPlace11 = new Vending_Machine.ProductControl();
            this.productPlace12 = new Vending_Machine.ProductControl();
            this.productPlace9 = new Vending_Machine.ProductControl();
            this.productPlace10 = new Vending_Machine.ProductControl();
            this.rbP11 = new System.Windows.Forms.RadioButton();
            this.rbP9 = new System.Windows.Forms.RadioButton();
            this.rbP10 = new System.Windows.Forms.RadioButton();
            this.rbP12 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.productPlace7 = new Vending_Machine.ProductControl();
            this.productPlace8 = new Vending_Machine.ProductControl();
            this.productPlace5 = new Vending_Machine.ProductControl();
            this.productPlace6 = new Vending_Machine.ProductControl();
            this.rbP7 = new System.Windows.Forms.RadioButton();
            this.rbP5 = new System.Windows.Forms.RadioButton();
            this.rbP6 = new System.Windows.Forms.RadioButton();
            this.rbP8 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.productPlace3 = new Vending_Machine.ProductControl();
            this.productPlace4 = new Vending_Machine.ProductControl();
            this.productPlace1 = new Vending_Machine.ProductControl();
            this.productPlace2 = new Vending_Machine.ProductControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel13.SuspendLayout();
            this.General_Panel.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbP1
            // 
            this.rbP1.AutoSize = true;
            this.rbP1.Location = new System.Drawing.Point(9, 106);
            this.rbP1.Name = "rbP1";
            this.rbP1.Size = new System.Drawing.Size(14, 13);
            this.rbP1.TabIndex = 2;
            this.rbP1.TabStop = true;
            this.rbP1.Tag = "Cola";
            this.rbP1.UseVisualStyleBackColor = true;
            this.rbP1.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbP2
            // 
            this.rbP2.AutoSize = true;
            this.rbP2.Location = new System.Drawing.Point(119, 106);
            this.rbP2.Name = "rbP2";
            this.rbP2.Size = new System.Drawing.Size(14, 13);
            this.rbP2.TabIndex = 4;
            this.rbP2.TabStop = true;
            this.rbP2.Tag = "Lays";
            this.rbP2.UseVisualStyleBackColor = true;
            this.rbP2.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbP3
            // 
            this.rbP3.AutoSize = true;
            this.rbP3.Location = new System.Drawing.Point(233, 106);
            this.rbP3.Name = "rbP3";
            this.rbP3.Size = new System.Drawing.Size(14, 13);
            this.rbP3.TabIndex = 4;
            this.rbP3.TabStop = true;
            this.rbP3.UseVisualStyleBackColor = true;
            this.rbP3.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbP4
            // 
            this.rbP4.AutoSize = true;
            this.rbP4.Location = new System.Drawing.Point(355, 106);
            this.rbP4.Name = "rbP4";
            this.rbP4.Size = new System.Drawing.Size(14, 13);
            this.rbP4.TabIndex = 4;
            this.rbP4.TabStop = true;
            this.rbP4.UseVisualStyleBackColor = true;
            this.rbP4.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(530, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(259, 23);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // roundButton1
            // 
            this.roundButton1.Location = new System.Drawing.Point(530, 89);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(69, 62);
            this.roundButton1.TabIndex = 2;
            this.roundButton1.Text = "0,10 ₼";
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton2
            // 
            this.roundButton2.Location = new System.Drawing.Point(625, 90);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(69, 62);
            this.roundButton2.TabIndex = 3;
            this.roundButton2.Text = "0,20 ₼";
            this.roundButton2.UseVisualStyleBackColor = true;
            this.roundButton2.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton3
            // 
            this.roundButton3.Location = new System.Drawing.Point(720, 89);
            this.roundButton3.Name = "roundButton3";
            this.roundButton3.Size = new System.Drawing.Size(69, 62);
            this.roundButton3.TabIndex = 4;
            this.roundButton3.Text = "0,50 ₼";
            this.roundButton3.UseVisualStyleBackColor = true;
            this.roundButton3.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton4
            // 
            this.roundButton4.Location = new System.Drawing.Point(720, 175);
            this.roundButton4.Name = "roundButton4";
            this.roundButton4.Size = new System.Drawing.Size(69, 62);
            this.roundButton4.TabIndex = 7;
            this.roundButton4.Text = "10,00 ₼";
            this.roundButton4.UseVisualStyleBackColor = true;
            this.roundButton4.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton5
            // 
            this.roundButton5.Location = new System.Drawing.Point(625, 176);
            this.roundButton5.Name = "roundButton5";
            this.roundButton5.Size = new System.Drawing.Size(69, 62);
            this.roundButton5.TabIndex = 6;
            this.roundButton5.Text = "5,00 ₼";
            this.roundButton5.UseVisualStyleBackColor = true;
            this.roundButton5.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // roundButton6
            // 
            this.roundButton6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.roundButton6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundButton6.Location = new System.Drawing.Point(530, 175);
            this.roundButton6.Name = "roundButton6";
            this.roundButton6.Size = new System.Drawing.Size(69, 62);
            this.roundButton6.TabIndex = 5;
            this.roundButton6.Text = "1,00 ₼";
            this.roundButton6.UseVisualStyleBackColor = true;
            this.roundButton6.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(530, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "Amount Entered : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(530, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Leftover Money :";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.btn_buy);
            this.panel13.Location = new System.Drawing.Point(530, 392);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(259, 100);
            this.panel13.TabIndex = 13;
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(89, 16);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(75, 68);
            this.btn_buy.TabIndex = 0;
            this.btn_buy.Text = "Buy";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // txt_enteredAmount
            // 
            this.txt_enteredAmount.Location = new System.Drawing.Point(639, 269);
            this.txt_enteredAmount.Name = "txt_enteredAmount";
            this.txt_enteredAmount.ReadOnly = true;
            this.txt_enteredAmount.Size = new System.Drawing.Size(72, 23);
            this.txt_enteredAmount.TabIndex = 14;
            this.txt_enteredAmount.Text = "0.00 AZN";
            // 
            // txt_Leftover
            // 
            this.txt_Leftover.Location = new System.Drawing.Point(639, 321);
            this.txt_Leftover.Name = "txt_Leftover";
            this.txt_Leftover.ReadOnly = true;
            this.txt_Leftover.Size = new System.Drawing.Size(72, 23);
            this.txt_Leftover.TabIndex = 15;
            this.txt_Leftover.Text = "0.00 AZN";
            // 
            // General_Panel
            // 
            this.General_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.General_Panel.Controls.Add(this.tableLayoutPanel4);
            this.General_Panel.Controls.Add(this.rbP11);
            this.General_Panel.Controls.Add(this.rbP9);
            this.General_Panel.Controls.Add(this.rbP10);
            this.General_Panel.Controls.Add(this.rbP12);
            this.General_Panel.Controls.Add(this.tableLayoutPanel3);
            this.General_Panel.Controls.Add(this.rbP7);
            this.General_Panel.Controls.Add(this.rbP5);
            this.General_Panel.Controls.Add(this.rbP6);
            this.General_Panel.Controls.Add(this.rbP8);
            this.General_Panel.Controls.Add(this.tableLayoutPanel1);
            this.General_Panel.Controls.Add(this.rbP3);
            this.General_Panel.Controls.Add(this.rbP1);
            this.General_Panel.Controls.Add(this.rbP2);
            this.General_Panel.Controls.Add(this.rbP4);
            this.General_Panel.Location = new System.Drawing.Point(16, 12);
            this.General_Panel.Name = "General_Panel";
            this.General_Panel.Size = new System.Drawing.Size(463, 411);
            this.General_Panel.TabIndex = 17;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.54955F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45045F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel4.Controls.Add(this.productPlace11, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.productPlace12, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.productPlace9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.productPlace10, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(-1, 265);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(464, 100);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // productPlace11
            // 
            this.productPlace11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace11.Location = new System.Drawing.Point(232, 4);
            this.productPlace11.Name = "productPlace11";
            this.productPlace11.Size = new System.Drawing.Size(111, 92);
            this.productPlace11.TabIndex = 24;
            // 
            // productPlace12
            // 
            this.productPlace12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace12.Location = new System.Drawing.Point(350, 4);
            this.productPlace12.Name = "productPlace12";
            this.productPlace12.Size = new System.Drawing.Size(110, 92);
            this.productPlace12.TabIndex = 23;
            // 
            // productPlace9
            // 
            this.productPlace9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace9.Location = new System.Drawing.Point(4, 4);
            this.productPlace9.Name = "productPlace9";
            this.productPlace9.Size = new System.Drawing.Size(106, 92);
            this.productPlace9.TabIndex = 22;
            // 
            // productPlace10
            // 
            this.productPlace10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace10.Location = new System.Drawing.Point(117, 4);
            this.productPlace10.Name = "productPlace10";
            this.productPlace10.Size = new System.Drawing.Size(108, 92);
            this.productPlace10.TabIndex = 21;
            // 
            // rbP11
            // 
            this.rbP11.AutoSize = true;
            this.rbP11.Location = new System.Drawing.Point(236, 371);
            this.rbP11.Name = "rbP11";
            this.rbP11.Size = new System.Drawing.Size(14, 13);
            this.rbP11.TabIndex = 12;
            this.rbP11.TabStop = true;
            this.rbP11.UseVisualStyleBackColor = true;
            this.rbP11.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbP9
            // 
            this.rbP9.AutoSize = true;
            this.rbP9.Location = new System.Drawing.Point(12, 371);
            this.rbP9.Name = "rbP9";
            this.rbP9.Size = new System.Drawing.Size(14, 13);
            this.rbP9.TabIndex = 11;
            this.rbP9.TabStop = true;
            this.rbP9.UseVisualStyleBackColor = true;
            this.rbP9.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbP10
            // 
            this.rbP10.AutoSize = true;
            this.rbP10.Location = new System.Drawing.Point(122, 371);
            this.rbP10.Name = "rbP10";
            this.rbP10.Size = new System.Drawing.Size(14, 13);
            this.rbP10.TabIndex = 13;
            this.rbP10.TabStop = true;
            this.rbP10.UseVisualStyleBackColor = true;
            this.rbP10.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbP12
            // 
            this.rbP12.AutoSize = true;
            this.rbP12.Location = new System.Drawing.Point(358, 371);
            this.rbP12.Name = "rbP12";
            this.rbP12.Size = new System.Drawing.Size(14, 13);
            this.rbP12.TabIndex = 14;
            this.rbP12.TabStop = true;
            this.rbP12.UseVisualStyleBackColor = true;
            this.rbP12.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.54955F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45045F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel3.Controls.Add(this.productPlace7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.productPlace8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.productPlace5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.productPlace6, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 134);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(463, 100);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // productPlace7
            // 
            this.productPlace7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace7.Location = new System.Drawing.Point(231, 4);
            this.productPlace7.Name = "productPlace7";
            this.productPlace7.Size = new System.Drawing.Size(111, 92);
            this.productPlace7.TabIndex = 24;
            // 
            // productPlace8
            // 
            this.productPlace8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace8.Location = new System.Drawing.Point(349, 4);
            this.productPlace8.Name = "productPlace8";
            this.productPlace8.Size = new System.Drawing.Size(110, 92);
            this.productPlace8.TabIndex = 23;
            // 
            // productPlace5
            // 
            this.productPlace5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace5.Location = new System.Drawing.Point(4, 4);
            this.productPlace5.Name = "productPlace5";
            this.productPlace5.Size = new System.Drawing.Size(105, 92);
            this.productPlace5.TabIndex = 22;
            // 
            // productPlace6
            // 
            this.productPlace6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace6.Location = new System.Drawing.Point(116, 4);
            this.productPlace6.Name = "productPlace6";
            this.productPlace6.Size = new System.Drawing.Size(108, 92);
            this.productPlace6.TabIndex = 21;
            // 
            // rbP7
            // 
            this.rbP7.AutoSize = true;
            this.rbP7.Location = new System.Drawing.Point(233, 240);
            this.rbP7.Name = "rbP7";
            this.rbP7.Size = new System.Drawing.Size(14, 13);
            this.rbP7.TabIndex = 7;
            this.rbP7.TabStop = true;
            this.rbP7.UseVisualStyleBackColor = true;
            this.rbP7.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbP5
            // 
            this.rbP5.AutoSize = true;
            this.rbP5.Location = new System.Drawing.Point(9, 240);
            this.rbP5.Name = "rbP5";
            this.rbP5.Size = new System.Drawing.Size(14, 13);
            this.rbP5.TabIndex = 6;
            this.rbP5.TabStop = true;
            this.rbP5.UseVisualStyleBackColor = true;
            this.rbP5.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbP6
            // 
            this.rbP6.AutoSize = true;
            this.rbP6.Location = new System.Drawing.Point(119, 240);
            this.rbP6.Name = "rbP6";
            this.rbP6.Size = new System.Drawing.Size(14, 13);
            this.rbP6.TabIndex = 8;
            this.rbP6.TabStop = true;
            this.rbP6.UseVisualStyleBackColor = true;
            this.rbP6.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbP8
            // 
            this.rbP8.AutoSize = true;
            this.rbP8.Location = new System.Drawing.Point(355, 240);
            this.rbP8.Name = "rbP8";
            this.rbP8.Size = new System.Drawing.Size(14, 13);
            this.rbP8.TabIndex = 9;
            this.rbP8.TabStop = true;
            this.rbP8.UseVisualStyleBackColor = true;
            this.rbP8.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.54955F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45045F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Controls.Add(this.productPlace3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productPlace4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productPlace1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productPlace2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // productPlace3
            // 
            this.productPlace3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace3.Location = new System.Drawing.Point(229, 4);
            this.productPlace3.Name = "productPlace3";
            this.productPlace3.Size = new System.Drawing.Size(111, 92);
            this.productPlace3.TabIndex = 23;
            // 
            // productPlace4
            // 
            this.productPlace4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace4.Location = new System.Drawing.Point(347, 4);
            this.productPlace4.Name = "productPlace4";
            this.productPlace4.Size = new System.Drawing.Size(110, 92);
            this.productPlace4.TabIndex = 22;
            // 
            // productPlace1
            // 
            this.productPlace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace1.Location = new System.Drawing.Point(4, 4);
            this.productPlace1.Name = "productPlace1";
            this.productPlace1.Size = new System.Drawing.Size(104, 92);
            this.productPlace1.TabIndex = 21;
            // 
            // productPlace2
            // 
            this.productPlace2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productPlace2.Location = new System.Drawing.Point(115, 4);
            this.productPlace2.Name = "productPlace2";
            this.productPlace2.Size = new System.Drawing.Size(107, 92);
            this.productPlace2.TabIndex = 20;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.54955F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.45045F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.Controls.Add(this.panel5, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.textBox7);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(89, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(109, 94);
            this.panel5.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(18, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(72, 23);
            this.textBox7.TabIndex = 1;
            this.textBox7.Text = "0.00 AZN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // panel6
            // 
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.textBox8);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(-28, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(111, 94);
            this.panel6.TabIndex = 18;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(18, 46);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(72, 23);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "0.00 AZN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 522);
            this.Controls.Add(this.General_Panel);
            this.Controls.Add(this.txt_Leftover);
            this.Controls.Add(this.txt_enteredAmount);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.roundButton4);
            this.Controls.Add(this.roundButton5);
            this.Controls.Add(this.roundButton6);
            this.Controls.Add(this.roundButton3);
            this.Controls.Add(this.roundButton2);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel13.ResumeLayout(false);
            this.General_Panel.ResumeLayout(false);
            this.General_Panel.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton rbP1;
        private RadioButton rbP2;
        private RadioButton rbP3;
        private RadioButton rbP4;
        private NumericUpDown numericUpDown1;
        private RoundButton roundButton1;
        private RoundButton roundButton2;
        private RoundButton roundButton3;
        private RoundButton roundButton4;
        private RoundButton roundButton5;
        private RoundButton roundButton6;
        private Label label13;
        private Label label14;
        private Panel panel13;
        private Button btn_buy;
        private TextBox txt_enteredAmount;
        private TextBox txt_Leftover;
        private Panel General_Panel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton rbP11;
        private RadioButton rbP9;
        private RadioButton rbP10;
        private RadioButton rbP12;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton rbP7;
        private RadioButton rbP5;
        private RadioButton rbP6;
        private RadioButton rbP8;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel5;
        private TextBox textBox7;
        private Label label4;
        private Panel panel6;
        private TextBox textBox8;
        private Label label5;
        private ProductControl productPlace2;
        private ProductControl productPlace11;
        private ProductControl productPlace12;
        private ProductControl productPlace9;
        private ProductControl productPlace10;
        private ProductControl productPlace7;
        private ProductControl productPlace8;
        private ProductControl productPlace5;
        private ProductControl productPlace6;
        private ProductControl productPlace3;
        private ProductControl productPlace4;
        private ProductControl productPlace1;
    }
}