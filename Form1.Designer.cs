namespace WinForm_GroceryStore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSubHeader = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox_Fruits = new System.Windows.Forms.PictureBox();
            this.lblSubHeader2 = new System.Windows.Forms.Label();
            this.pictureBox_Apple = new System.Windows.Forms.PictureBox();
            this.pictureBox_Orange = new System.Windows.Forms.PictureBox();
            this.pictureBox_Banana = new System.Windows.Forms.PictureBox();
            this.pictureBox_Peach = new System.Windows.Forms.PictureBox();
            this.pictureBox_Watermelon = new System.Windows.Forms.PictureBox();
            this.txtDisplay_Apple = new System.Windows.Forms.TextBox();
            this.txtDisplay_Banana = new System.Windows.Forms.TextBox();
            this.txtDisplay_Orange = new System.Windows.Forms.TextBox();
            this.txtDisplay_Peach = new System.Windows.Forms.TextBox();
            this.txtDisplay_Watermelon = new System.Windows.Forms.TextBox();
            this.lblQty_Apple = new System.Windows.Forms.Label();
            this.txtQty_Apple = new System.Windows.Forms.TextBox();
            this.btnAdd_Apple = new System.Windows.Forms.Button();
            this.lblQty_Banana = new System.Windows.Forms.Label();
            this.txtQty_Banana = new System.Windows.Forms.TextBox();
            this.btnAdd_Banana = new System.Windows.Forms.Button();
            this.lblQty_Orange = new System.Windows.Forms.Label();
            this.lblQty_Peach = new System.Windows.Forms.Label();
            this.lblQty_Watermelon = new System.Windows.Forms.Label();
            this.txtQty_Orange = new System.Windows.Forms.TextBox();
            this.txtQty_Peach = new System.Windows.Forms.TextBox();
            this.txtQty_Watermelon = new System.Windows.Forms.TextBox();
            this.btnAdd_Orange = new System.Windows.Forms.Button();
            this.btnAdd_Peach = new System.Windows.Forms.Button();
            this.btnAdd_Watermelon = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.fruitGrid = new System.Windows.Forms.DataGridView();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fruits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Apple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Banana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Peach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Watermelon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubHeader
            // 
            this.lblSubHeader.AutoSize = true;
            this.lblSubHeader.BackColor = System.Drawing.Color.ForestGreen;
            this.lblSubHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader.ForeColor = System.Drawing.Color.White;
            this.lblSubHeader.Location = new System.Drawing.Point(140, 127);
            this.lblSubHeader.Name = "lblSubHeader";
            this.lblSubHeader.Size = new System.Drawing.Size(127, 31);
            this.lblSubHeader.TabIndex = 1;
            this.lblSubHeader.Text = "MARKET";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHeader);
            this.groupBox1.Controls.Add(this.pictureBox_Fruits);
            this.groupBox1.Controls.Add(this.lblSubHeader);
            this.groupBox1.Location = new System.Drawing.Point(77, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1569, 207);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.ForestGreen;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(24, 48);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(381, 63);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "HALF FOODS";
            // 
            // pictureBox_Fruits
            // 
            this.pictureBox_Fruits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Fruits.BackgroundImage")));
            this.pictureBox_Fruits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Fruits.Location = new System.Drawing.Point(433, 12);
            this.pictureBox_Fruits.Name = "pictureBox_Fruits";
            this.pictureBox_Fruits.Size = new System.Drawing.Size(1136, 195);
            this.pictureBox_Fruits.TabIndex = 3;
            this.pictureBox_Fruits.TabStop = false;
            // 
            // lblSubHeader2
            // 
            this.lblSubHeader2.AutoSize = true;
            this.lblSubHeader2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeader2.Location = new System.Drawing.Point(69, 309);
            this.lblSubHeader2.Name = "lblSubHeader2";
            this.lblSubHeader2.Size = new System.Drawing.Size(340, 46);
            this.lblSubHeader2.TabIndex = 4;
            this.lblSubHeader2.Text = "Popular near you";
            // 
            // pictureBox_Apple
            // 
            this.pictureBox_Apple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Apple.BackgroundImage")));
            this.pictureBox_Apple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Apple.Location = new System.Drawing.Point(77, 385);
            this.pictureBox_Apple.Name = "pictureBox_Apple";
            this.pictureBox_Apple.Size = new System.Drawing.Size(241, 130);
            this.pictureBox_Apple.TabIndex = 5;
            this.pictureBox_Apple.TabStop = false;
            // 
            // pictureBox_Orange
            // 
            this.pictureBox_Orange.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Orange.BackgroundImage")));
            this.pictureBox_Orange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Orange.Location = new System.Drawing.Point(763, 385);
            this.pictureBox_Orange.Name = "pictureBox_Orange";
            this.pictureBox_Orange.Size = new System.Drawing.Size(241, 130);
            this.pictureBox_Orange.TabIndex = 6;
            this.pictureBox_Orange.TabStop = false;
            // 
            // pictureBox_Banana
            // 
            this.pictureBox_Banana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Banana.BackgroundImage")));
            this.pictureBox_Banana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Banana.Location = new System.Drawing.Point(410, 385);
            this.pictureBox_Banana.Name = "pictureBox_Banana";
            this.pictureBox_Banana.Size = new System.Drawing.Size(242, 130);
            this.pictureBox_Banana.TabIndex = 7;
            this.pictureBox_Banana.TabStop = false;
            // 
            // pictureBox_Peach
            // 
            this.pictureBox_Peach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Peach.BackgroundImage")));
            this.pictureBox_Peach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Peach.Location = new System.Drawing.Point(1101, 385);
            this.pictureBox_Peach.Name = "pictureBox_Peach";
            this.pictureBox_Peach.Size = new System.Drawing.Size(239, 130);
            this.pictureBox_Peach.TabIndex = 8;
            this.pictureBox_Peach.TabStop = false;
            // 
            // pictureBox_Watermelon
            // 
            this.pictureBox_Watermelon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Watermelon.BackgroundImage")));
            this.pictureBox_Watermelon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Watermelon.Location = new System.Drawing.Point(1407, 385);
            this.pictureBox_Watermelon.Name = "pictureBox_Watermelon";
            this.pictureBox_Watermelon.Size = new System.Drawing.Size(239, 130);
            this.pictureBox_Watermelon.TabIndex = 9;
            this.pictureBox_Watermelon.TabStop = false;
            // 
            // txtDisplay_Apple
            // 
            this.txtDisplay_Apple.Location = new System.Drawing.Point(77, 545);
            this.txtDisplay_Apple.Name = "txtDisplay_Apple";
            this.txtDisplay_Apple.Size = new System.Drawing.Size(241, 31);
            this.txtDisplay_Apple.TabIndex = 10;
            this.txtDisplay_Apple.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDisplay_Banana
            // 
            this.txtDisplay_Banana.Location = new System.Drawing.Point(410, 545);
            this.txtDisplay_Banana.Name = "txtDisplay_Banana";
            this.txtDisplay_Banana.Size = new System.Drawing.Size(241, 31);
            this.txtDisplay_Banana.TabIndex = 11;
            this.txtDisplay_Banana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDisplay_Orange
            // 
            this.txtDisplay_Orange.Location = new System.Drawing.Point(763, 545);
            this.txtDisplay_Orange.Name = "txtDisplay_Orange";
            this.txtDisplay_Orange.Size = new System.Drawing.Size(241, 31);
            this.txtDisplay_Orange.TabIndex = 12;
            this.txtDisplay_Orange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDisplay_Peach
            // 
            this.txtDisplay_Peach.Location = new System.Drawing.Point(1099, 545);
            this.txtDisplay_Peach.Name = "txtDisplay_Peach";
            this.txtDisplay_Peach.Size = new System.Drawing.Size(241, 31);
            this.txtDisplay_Peach.TabIndex = 13;
            this.txtDisplay_Peach.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDisplay_Watermelon
            // 
            this.txtDisplay_Watermelon.Location = new System.Drawing.Point(1405, 545);
            this.txtDisplay_Watermelon.Name = "txtDisplay_Watermelon";
            this.txtDisplay_Watermelon.Size = new System.Drawing.Size(241, 31);
            this.txtDisplay_Watermelon.TabIndex = 14;
            this.txtDisplay_Watermelon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQty_Apple
            // 
            this.lblQty_Apple.AutoSize = true;
            this.lblQty_Apple.BackColor = System.Drawing.Color.White;
            this.lblQty_Apple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty_Apple.Location = new System.Drawing.Point(72, 603);
            this.lblQty_Apple.Name = "lblQty_Apple";
            this.lblQty_Apple.Size = new System.Drawing.Size(106, 29);
            this.lblQty_Apple.TabIndex = 15;
            this.lblQty_Apple.Text = "Quantity:";
            // 
            // txtQty_Apple
            // 
            this.txtQty_Apple.Location = new System.Drawing.Point(214, 600);
            this.txtQty_Apple.Name = "txtQty_Apple";
            this.txtQty_Apple.Size = new System.Drawing.Size(100, 31);
            this.txtQty_Apple.TabIndex = 16;
            // 
            // btnAdd_Apple
            // 
            this.btnAdd_Apple.Location = new System.Drawing.Point(214, 655);
            this.btnAdd_Apple.Name = "btnAdd_Apple";
            this.btnAdd_Apple.Size = new System.Drawing.Size(104, 39);
            this.btnAdd_Apple.TabIndex = 17;
            this.btnAdd_Apple.Text = "Add";
            this.btnAdd_Apple.UseVisualStyleBackColor = true;
            this.btnAdd_Apple.Click += new System.EventHandler(this.btnAdd_Apple_Click);
            // 
            // lblQty_Banana
            // 
            this.lblQty_Banana.AutoSize = true;
            this.lblQty_Banana.BackColor = System.Drawing.Color.White;
            this.lblQty_Banana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty_Banana.Location = new System.Drawing.Point(405, 603);
            this.lblQty_Banana.Name = "lblQty_Banana";
            this.lblQty_Banana.Size = new System.Drawing.Size(106, 29);
            this.lblQty_Banana.TabIndex = 18;
            this.lblQty_Banana.Text = "Quantity:";
            // 
            // txtQty_Banana
            // 
            this.txtQty_Banana.Location = new System.Drawing.Point(551, 603);
            this.txtQty_Banana.Name = "txtQty_Banana";
            this.txtQty_Banana.Size = new System.Drawing.Size(100, 31);
            this.txtQty_Banana.TabIndex = 19;
            // 
            // btnAdd_Banana
            // 
            this.btnAdd_Banana.Location = new System.Drawing.Point(551, 655);
            this.btnAdd_Banana.Name = "btnAdd_Banana";
            this.btnAdd_Banana.Size = new System.Drawing.Size(104, 39);
            this.btnAdd_Banana.TabIndex = 20;
            this.btnAdd_Banana.Text = "Add";
            this.btnAdd_Banana.UseVisualStyleBackColor = true;
            this.btnAdd_Banana.Click += new System.EventHandler(this.btnAdd_Banana_Click);
            // 
            // lblQty_Orange
            // 
            this.lblQty_Orange.AutoSize = true;
            this.lblQty_Orange.BackColor = System.Drawing.Color.White;
            this.lblQty_Orange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty_Orange.Location = new System.Drawing.Point(767, 600);
            this.lblQty_Orange.Name = "lblQty_Orange";
            this.lblQty_Orange.Size = new System.Drawing.Size(106, 29);
            this.lblQty_Orange.TabIndex = 21;
            this.lblQty_Orange.Text = "Quantity:";
            // 
            // lblQty_Peach
            // 
            this.lblQty_Peach.AutoSize = true;
            this.lblQty_Peach.BackColor = System.Drawing.Color.White;
            this.lblQty_Peach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty_Peach.Location = new System.Drawing.Point(1096, 605);
            this.lblQty_Peach.Name = "lblQty_Peach";
            this.lblQty_Peach.Size = new System.Drawing.Size(106, 29);
            this.lblQty_Peach.TabIndex = 22;
            this.lblQty_Peach.Text = "Quantity:";
            // 
            // lblQty_Watermelon
            // 
            this.lblQty_Watermelon.AutoSize = true;
            this.lblQty_Watermelon.BackColor = System.Drawing.Color.White;
            this.lblQty_Watermelon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty_Watermelon.Location = new System.Drawing.Point(1402, 605);
            this.lblQty_Watermelon.Name = "lblQty_Watermelon";
            this.lblQty_Watermelon.Size = new System.Drawing.Size(106, 29);
            this.lblQty_Watermelon.TabIndex = 23;
            this.lblQty_Watermelon.Text = "Quantity:";
            // 
            // txtQty_Orange
            // 
            this.txtQty_Orange.Location = new System.Drawing.Point(904, 600);
            this.txtQty_Orange.Name = "txtQty_Orange";
            this.txtQty_Orange.Size = new System.Drawing.Size(100, 31);
            this.txtQty_Orange.TabIndex = 24;
            // 
            // txtQty_Peach
            // 
            this.txtQty_Peach.Location = new System.Drawing.Point(1240, 605);
            this.txtQty_Peach.Name = "txtQty_Peach";
            this.txtQty_Peach.Size = new System.Drawing.Size(100, 31);
            this.txtQty_Peach.TabIndex = 25;
            // 
            // txtQty_Watermelon
            // 
            this.txtQty_Watermelon.Location = new System.Drawing.Point(1546, 603);
            this.txtQty_Watermelon.Name = "txtQty_Watermelon";
            this.txtQty_Watermelon.Size = new System.Drawing.Size(100, 31);
            this.txtQty_Watermelon.TabIndex = 26;
            // 
            // btnAdd_Orange
            // 
            this.btnAdd_Orange.Location = new System.Drawing.Point(900, 655);
            this.btnAdd_Orange.Name = "btnAdd_Orange";
            this.btnAdd_Orange.Size = new System.Drawing.Size(104, 39);
            this.btnAdd_Orange.TabIndex = 27;
            this.btnAdd_Orange.Text = "Add";
            this.btnAdd_Orange.UseVisualStyleBackColor = true;
            this.btnAdd_Orange.Click += new System.EventHandler(this.btnAdd_Orange_Click);
            // 
            // btnAdd_Peach
            // 
            this.btnAdd_Peach.Location = new System.Drawing.Point(1240, 655);
            this.btnAdd_Peach.Name = "btnAdd_Peach";
            this.btnAdd_Peach.Size = new System.Drawing.Size(104, 39);
            this.btnAdd_Peach.TabIndex = 28;
            this.btnAdd_Peach.Text = "Add";
            this.btnAdd_Peach.UseVisualStyleBackColor = true;
            this.btnAdd_Peach.Click += new System.EventHandler(this.btnAdd_Peach_Click);
            // 
            // btnAdd_Watermelon
            // 
            this.btnAdd_Watermelon.Location = new System.Drawing.Point(1542, 655);
            this.btnAdd_Watermelon.Name = "btnAdd_Watermelon";
            this.btnAdd_Watermelon.Size = new System.Drawing.Size(104, 39);
            this.btnAdd_Watermelon.TabIndex = 29;
            this.btnAdd_Watermelon.Text = "Add";
            this.btnAdd_Watermelon.UseVisualStyleBackColor = true;
            this.btnAdd_Watermelon.Click += new System.EventHandler(this.btnAdd_Watermelon_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(500, 1348);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(165, 39);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // fruitGrid
            // 
            this.fruitGrid.ColumnHeadersHeight = 46;
            this.fruitGrid.Location = new System.Drawing.Point(500, 737);
            this.fruitGrid.Name = "fruitGrid";
            this.fruitGrid.RowHeadersWidth = 82;
            this.fruitGrid.RowTemplate.Height = 33;
            this.fruitGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fruitGrid.Size = new System.Drawing.Size(731, 582);
            this.fruitGrid.TabIndex = 31;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(1066, 1348);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(165, 39);
            this.btnCheckOut.TabIndex = 32;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1748, 1481);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.fruitGrid);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd_Watermelon);
            this.Controls.Add(this.btnAdd_Peach);
            this.Controls.Add(this.btnAdd_Orange);
            this.Controls.Add(this.txtQty_Watermelon);
            this.Controls.Add(this.txtQty_Peach);
            this.Controls.Add(this.txtQty_Orange);
            this.Controls.Add(this.lblQty_Watermelon);
            this.Controls.Add(this.lblQty_Peach);
            this.Controls.Add(this.lblQty_Orange);
            this.Controls.Add(this.btnAdd_Banana);
            this.Controls.Add(this.txtQty_Banana);
            this.Controls.Add(this.lblQty_Banana);
            this.Controls.Add(this.btnAdd_Apple);
            this.Controls.Add(this.txtQty_Apple);
            this.Controls.Add(this.lblQty_Apple);
            this.Controls.Add(this.txtDisplay_Watermelon);
            this.Controls.Add(this.txtDisplay_Peach);
            this.Controls.Add(this.txtDisplay_Orange);
            this.Controls.Add(this.txtDisplay_Banana);
            this.Controls.Add(this.txtDisplay_Apple);
            this.Controls.Add(this.pictureBox_Watermelon);
            this.Controls.Add(this.pictureBox_Peach);
            this.Controls.Add(this.pictureBox_Banana);
            this.Controls.Add(this.pictureBox_Orange);
            this.Controls.Add(this.pictureBox_Apple);
            this.Controls.Add(this.lblSubHeader2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Fruits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Apple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Banana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Peach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Watermelon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fruitGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSubHeader;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_Fruits;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSubHeader2;
        private System.Windows.Forms.PictureBox pictureBox_Apple;
        private System.Windows.Forms.PictureBox pictureBox_Orange;
        private System.Windows.Forms.PictureBox pictureBox_Banana;
        private System.Windows.Forms.PictureBox pictureBox_Peach;
        private System.Windows.Forms.PictureBox pictureBox_Watermelon;
        private System.Windows.Forms.TextBox txtDisplay_Apple;
        private System.Windows.Forms.TextBox txtDisplay_Banana;
        private System.Windows.Forms.TextBox txtDisplay_Orange;
        private System.Windows.Forms.TextBox txtDisplay_Peach;
        private System.Windows.Forms.TextBox txtDisplay_Watermelon;
        private System.Windows.Forms.Label lblQty_Apple;
        private System.Windows.Forms.TextBox txtQty_Apple;
        private System.Windows.Forms.Button btnAdd_Apple;
        private System.Windows.Forms.Label lblQty_Banana;
        private System.Windows.Forms.TextBox txtQty_Banana;
        private System.Windows.Forms.Button btnAdd_Banana;
        private System.Windows.Forms.Label lblQty_Orange;
        private System.Windows.Forms.Label lblQty_Peach;
        private System.Windows.Forms.Label lblQty_Watermelon;
        private System.Windows.Forms.TextBox txtQty_Orange;
        private System.Windows.Forms.TextBox txtQty_Peach;
        private System.Windows.Forms.TextBox txtQty_Watermelon;
        private System.Windows.Forms.Button btnAdd_Orange;
        private System.Windows.Forms.Button btnAdd_Peach;
        private System.Windows.Forms.Button btnAdd_Watermelon;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView fruitGrid;
        private System.Windows.Forms.Button btnCheckOut;
    }
}

