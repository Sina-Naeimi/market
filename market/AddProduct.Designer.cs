
namespace market
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboId = new System.Windows.Forms.ComboBox();
            this.ComboName = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Combosubgp = new System.Windows.Forms.ComboBox();
            this.Combogp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Price_txt = new System.Windows.Forms.TextBox();
            this.Stock_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.محصول = new System.Windows.Forms.ColumnHeader();
            this.CHgp = new System.Windows.Forms.ColumnHeader();
            this.CHsubgp = new System.Windows.Forms.ColumnHeader();
            this.CHcount = new System.Windows.Forms.ColumnHeader();
            this.CHPrice = new System.Windows.Forms.ColumnHeader();
            this.CHDate = new System.Windows.Forms.ColumnHeader();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ComboId);
            this.groupBox1.Controls.Add(this.ComboName);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Combosubgp);
            this.groupBox1.Controls.Add(this.Combogp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Price_txt);
            this.groupBox1.Controls.Add(this.Stock_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(669, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // ComboId
            // 
            this.ComboId.FormattingEnabled = true;
            this.ComboId.Location = new System.Drawing.Point(319, 59);
            this.ComboId.Name = "ComboId";
            this.ComboId.Size = new System.Drawing.Size(151, 28);
            this.ComboId.TabIndex = 19;
            this.ComboId.SelectedIndexChanged += new System.EventHandler(this.ComboId_SelectedIndexChanged);
            // 
            // ComboName
            // 
            this.ComboName.FormattingEnabled = true;
            this.ComboName.Location = new System.Drawing.Point(319, 106);
            this.ComboName.Name = "ComboName";
            this.ComboName.Size = new System.Drawing.Size(151, 28);
            this.ComboName.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Location = new System.Drawing.Point(91, 293);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 53);
            this.button3.TabIndex = 17;
            this.button3.Text = "بروزرسانی";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(91, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 50);
            this.button2.TabIndex = 16;
            this.button2.Text = "حذف کالا";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(486, 380);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(95, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "تاریخ تولید:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.Honeydew;
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 380);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 27);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(91, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "ثبت کالا";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(509, 314);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(68, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "زیرگروه:";
            // 
            // Combosubgp
            // 
            this.Combosubgp.FormattingEnabled = true;
            this.Combosubgp.Location = new System.Drawing.Point(327, 314);
            this.Combosubgp.Name = "Combosubgp";
            this.Combosubgp.Size = new System.Drawing.Size(143, 28);
            this.Combosubgp.TabIndex = 11;
            // 
            // Combogp
            // 
            this.Combogp.FormattingEnabled = true;
            this.Combogp.Location = new System.Drawing.Point(319, 259);
            this.Combogp.Name = "Combogp";
            this.Combogp.Size = new System.Drawing.Size(151, 28);
            this.Combogp.TabIndex = 10;
            this.Combogp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(502, 106);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(69, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "نام کالا:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(509, 159);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "قیمت:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(521, 201);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(56, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "تعداد:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(520, 255);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(51, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "گروه:";
            // 
            // Price_txt
            // 
            this.Price_txt.Location = new System.Drawing.Point(345, 159);
            this.Price_txt.Name = "Price_txt";
            this.Price_txt.Size = new System.Drawing.Size(125, 27);
            this.Price_txt.TabIndex = 4;
            // 
            // Stock_txt
            // 
            this.Stock_txt.Location = new System.Drawing.Point(345, 203);
            this.Stock_txt.Name = "Stock_txt";
            this.Stock_txt.Size = new System.Drawing.Size(125, 27);
            this.Stock_txt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vazir", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(534, 59);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(37, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.محصول,
            this.CHPrice,
            this.CHcount,
            this.CHgp,
            this.CHsubgp,
            this.CHDate});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 29);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.Size = new System.Drawing.Size(629, 424);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // محصول
            // 
            this.محصول.Text = "محصول";
            this.محصول.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.محصول.Width = 100;
            // 
            // CHgp
            // 
            this.CHgp.DisplayIndex = 2;
            this.CHgp.Text = "گروه";
            this.CHgp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHgp.Width = 100;
            // 
            // CHsubgp
            // 
            this.CHsubgp.DisplayIndex = 3;
            this.CHsubgp.Text = "زیرگروه";
            this.CHsubgp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHsubgp.Width = 100;
            // 
            // CHcount
            // 
            this.CHcount.DisplayIndex = 4;
            this.CHcount.Text = "ظرفیت";
            this.CHcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHcount.Width = 100;
            // 
            // CHPrice
            // 
            this.CHPrice.DisplayIndex = 5;
            this.CHPrice.Text = "قیمت";
            this.CHPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHPrice.Width = 100;
            // 
            // CHDate
            // 
            this.CHDate.Text = "تاریخ";
            this.CHDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1156, 594);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "خروج";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 635);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Price_txt;
        private System.Windows.Forms.TextBox Stock_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Combosubgp;
        private System.Windows.Forms.ComboBox Combogp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader محصول;
        private System.Windows.Forms.ColumnHeader CHgp;
        private System.Windows.Forms.ColumnHeader CHsubgp;
        private System.Windows.Forms.ColumnHeader CHcount;
        private System.Windows.Forms.ColumnHeader CHPrice;
        private System.Windows.Forms.ColumnHeader CHDate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ComboId;
        private System.Windows.Forms.ComboBox ComboName;
        private System.Windows.Forms.Button button4;
    }
}