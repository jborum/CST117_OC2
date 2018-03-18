namespace Programming_Project_2
{
    partial class frmProgrammingProject2
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
            this.listChips = new System.Windows.Forms.ListBox();
            this.groupCheckboxes = new System.Windows.Forms.GroupBox();
            this.checkCheese = new System.Windows.Forms.CheckBox();
            this.checkTomato = new System.Windows.Forms.CheckBox();
            this.checkLettuce = new System.Windows.Forms.CheckBox();
            this.groupRadio = new System.Windows.Forms.GroupBox();
            this.radioRoastBeef = new System.Windows.Forms.RadioButton();
            this.radioTurkey = new System.Windows.Forms.RadioButton();
            this.radioHam = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picBottomBun = new System.Windows.Forms.PictureBox();
            this.picChips = new System.Windows.Forms.PictureBox();
            this.picMeat = new System.Windows.Forms.PictureBox();
            this.picTomato = new System.Windows.Forms.PictureBox();
            this.picLettuce = new System.Windows.Forms.PictureBox();
            this.picCheese = new System.Windows.Forms.PictureBox();
            this.picTopBun = new System.Windows.Forms.PictureBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupCheckboxes.SuspendLayout();
            this.groupRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomBun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChips)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTomato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLettuce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopBun)).BeginInit();
            this.SuspendLayout();
            // 
            // listChips
            // 
            this.listChips.FormattingEnabled = true;
            this.listChips.ItemHeight = 20;
            this.listChips.Items.AddRange(new object[] {
            "Doritos",
            "Cheetos",
            "Lays"});
            this.listChips.Location = new System.Drawing.Point(26, 407);
            this.listChips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listChips.Name = "listChips";
            this.listChips.Size = new System.Drawing.Size(421, 124);
            this.listChips.TabIndex = 6;
            this.listChips.SelectedIndexChanged += new System.EventHandler(this.listChips_SelectedIndexChanged);
            // 
            // groupCheckboxes
            // 
            this.groupCheckboxes.Controls.Add(this.checkCheese);
            this.groupCheckboxes.Controls.Add(this.checkTomato);
            this.groupCheckboxes.Controls.Add(this.checkLettuce);
            this.groupCheckboxes.Location = new System.Drawing.Point(235, 154);
            this.groupCheckboxes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupCheckboxes.Name = "groupCheckboxes";
            this.groupCheckboxes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupCheckboxes.Size = new System.Drawing.Size(218, 215);
            this.groupCheckboxes.TabIndex = 9;
            this.groupCheckboxes.TabStop = false;
            this.groupCheckboxes.Text = "Choose Extras";
            // 
            // checkCheese
            // 
            this.checkCheese.AutoSize = true;
            this.checkCheese.Location = new System.Drawing.Point(36, 160);
            this.checkCheese.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkCheese.Name = "checkCheese";
            this.checkCheese.Size = new System.Drawing.Size(90, 24);
            this.checkCheese.TabIndex = 8;
            this.checkCheese.Text = "Cheese";
            this.checkCheese.UseVisualStyleBackColor = true;
            this.checkCheese.CheckedChanged += new System.EventHandler(this.checkCheese_CheckedChanged);
            // 
            // checkTomato
            // 
            this.checkTomato.AutoSize = true;
            this.checkTomato.Location = new System.Drawing.Point(36, 103);
            this.checkTomato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkTomato.Name = "checkTomato";
            this.checkTomato.Size = new System.Drawing.Size(89, 24);
            this.checkTomato.TabIndex = 7;
            this.checkTomato.Text = "Tomato";
            this.checkTomato.UseVisualStyleBackColor = true;
            this.checkTomato.CheckedChanged += new System.EventHandler(this.checkTomato_CheckedChanged);
            // 
            // checkLettuce
            // 
            this.checkLettuce.AutoSize = true;
            this.checkLettuce.Location = new System.Drawing.Point(36, 46);
            this.checkLettuce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkLettuce.Name = "checkLettuce";
            this.checkLettuce.Size = new System.Drawing.Size(89, 24);
            this.checkLettuce.TabIndex = 6;
            this.checkLettuce.Text = "Lettuce";
            this.checkLettuce.UseVisualStyleBackColor = true;
            this.checkLettuce.CheckedChanged += new System.EventHandler(this.checkLettuce_CheckedChanged);
            // 
            // groupRadio
            // 
            this.groupRadio.Controls.Add(this.radioRoastBeef);
            this.groupRadio.Controls.Add(this.radioTurkey);
            this.groupRadio.Controls.Add(this.radioHam);
            this.groupRadio.Location = new System.Drawing.Point(26, 154);
            this.groupRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupRadio.Name = "groupRadio";
            this.groupRadio.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupRadio.Size = new System.Drawing.Size(181, 215);
            this.groupRadio.TabIndex = 0;
            this.groupRadio.TabStop = false;
            this.groupRadio.Text = "Meat Selection";
            // 
            // radioRoastBeef
            // 
            this.radioRoastBeef.AutoSize = true;
            this.radioRoastBeef.Location = new System.Drawing.Point(36, 160);
            this.radioRoastBeef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioRoastBeef.Name = "radioRoastBeef";
            this.radioRoastBeef.Size = new System.Drawing.Size(115, 24);
            this.radioRoastBeef.TabIndex = 5;
            this.radioRoastBeef.TabStop = true;
            this.radioRoastBeef.Text = "Roast Beef";
            this.radioRoastBeef.UseVisualStyleBackColor = true;
            this.radioRoastBeef.CheckedChanged += new System.EventHandler(this.radioRoastBeef_CheckedChanged);
            // 
            // radioTurkey
            // 
            this.radioTurkey.AutoSize = true;
            this.radioTurkey.Location = new System.Drawing.Point(36, 103);
            this.radioTurkey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTurkey.Name = "radioTurkey";
            this.radioTurkey.Size = new System.Drawing.Size(81, 24);
            this.radioTurkey.TabIndex = 4;
            this.radioTurkey.TabStop = true;
            this.radioTurkey.Text = "Turkey";
            this.radioTurkey.UseVisualStyleBackColor = true;
            this.radioTurkey.CheckedChanged += new System.EventHandler(this.radioTurkey_CheckedChanged);
            // 
            // radioHam
            // 
            this.radioHam.AutoSize = true;
            this.radioHam.Location = new System.Drawing.Point(36, 46);
            this.radioHam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioHam.Name = "radioHam";
            this.radioHam.Size = new System.Drawing.Size(68, 24);
            this.radioHam.TabIndex = 3;
            this.radioHam.TabStop = true;
            this.radioHam.Text = "Ham";
            this.radioHam.UseVisualStyleBackColor = true;
            this.radioHam.CheckedChanged += new System.EventHandler(this.radioHam_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(24, 549);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(423, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Choose Chips";
            // 
            // picBottomBun
            // 
            this.picBottomBun.Image = global::Programming_Project_2.Properties.Resources.bottombun;
            this.picBottomBun.InitialImage = null;
            this.picBottomBun.Location = new System.Drawing.Point(500, 503);
            this.picBottomBun.Name = "picBottomBun";
            this.picBottomBun.Size = new System.Drawing.Size(216, 81);
            this.picBottomBun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBottomBun.TabIndex = 20;
            this.picBottomBun.TabStop = false;
            // 
            // picChips
            // 
            this.picChips.Location = new System.Drawing.Point(767, 234);
            this.picChips.Name = "picChips";
            this.picChips.Size = new System.Drawing.Size(210, 251);
            this.picChips.TabIndex = 18;
            this.picChips.TabStop = false;
            // 
            // picMeat
            // 
            this.picMeat.Location = new System.Drawing.Point(465, 430);
            this.picMeat.Name = "picMeat";
            this.picMeat.Size = new System.Drawing.Size(279, 70);
            this.picMeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMeat.TabIndex = 17;
            this.picMeat.TabStop = false;
            // 
            // picTomato
            // 
            this.picTomato.Location = new System.Drawing.Point(500, 365);
            this.picTomato.Name = "picTomato";
            this.picTomato.Size = new System.Drawing.Size(216, 66);
            this.picTomato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTomato.TabIndex = 16;
            this.picTomato.TabStop = false;
            // 
            // picLettuce
            // 
            this.picLettuce.Location = new System.Drawing.Point(500, 299);
            this.picLettuce.Name = "picLettuce";
            this.picLettuce.Size = new System.Drawing.Size(216, 70);
            this.picLettuce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLettuce.TabIndex = 15;
            this.picLettuce.TabStop = false;
            // 
            // picCheese
            // 
            this.picCheese.Location = new System.Drawing.Point(500, 234);
            this.picCheese.Name = "picCheese";
            this.picCheese.Size = new System.Drawing.Size(216, 73);
            this.picCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheese.TabIndex = 14;
            this.picCheese.TabStop = false;
            // 
            // picTopBun
            // 
            this.picTopBun.Image = global::Programming_Project_2.Properties.Resources.topbun;
            this.picTopBun.Location = new System.Drawing.Point(500, 152);
            this.picTopBun.Name = "picTopBun";
            this.picTopBun.Size = new System.Drawing.Size(216, 85);
            this.picTopBun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopBun.TabIndex = 13;
            this.picTopBun.TabStop = false;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(171, 679);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(806, 26);
            this.txtImagePath.TabIndex = 26;
            this.txtImagePath.Text = "C:\\\\Users\\\\JasonBorum\\\\Dropbox (Ardebili & Borum)\\\\_GrandCanyonUniversity\\\\04_CST" +
    "117\\\\02_Assignments\\\\Week2\\\\Images\\\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Image Path";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(235, 28);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(218, 26);
            this.txtQuantity.TabIndex = 28;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Enter Number of Meals";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(767, 28);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 26);
            this.txtPrice.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total Price";
            // 
            // frmProgrammingProject2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 720);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBottomBun);
            this.Controls.Add(this.picChips);
            this.Controls.Add(this.picMeat);
            this.Controls.Add(this.picTomato);
            this.Controls.Add(this.picLettuce);
            this.Controls.Add(this.picCheese);
            this.Controls.Add(this.picTopBun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupRadio);
            this.Controls.Add(this.groupCheckboxes);
            this.Controls.Add(this.listChips);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmProgrammingProject2";
            this.Text = "Programming Project 2";
            this.Load += new System.EventHandler(this.frmProgrammingProject2_Load);
            this.groupCheckboxes.ResumeLayout(false);
            this.groupCheckboxes.PerformLayout();
            this.groupRadio.ResumeLayout(false);
            this.groupRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomBun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChips)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTomato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLettuce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopBun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listChips;
        private System.Windows.Forms.GroupBox groupCheckboxes;
        private System.Windows.Forms.GroupBox groupRadio;
        private System.Windows.Forms.CheckBox checkCheese;
        private System.Windows.Forms.CheckBox checkTomato;
        private System.Windows.Forms.CheckBox checkLettuce;
        private System.Windows.Forms.RadioButton radioRoastBeef;
        private System.Windows.Forms.RadioButton radioTurkey;
        private System.Windows.Forms.RadioButton radioHam;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picTopBun;
        private System.Windows.Forms.PictureBox picCheese;
        private System.Windows.Forms.PictureBox picLettuce;
        private System.Windows.Forms.PictureBox picTomato;
        private System.Windows.Forms.PictureBox picMeat;
        private System.Windows.Forms.PictureBox picBottomBun;
        private System.Windows.Forms.PictureBox picChips;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
    }
}

