namespace overview
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
            this.gpsize = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rblarge = new System.Windows.Forms.RadioButton();
            this.rbmedium = new System.Windows.Forms.RadioButton();
            this.rbsmall = new System.Windows.Forms.RadioButton();
            this.gpToppings = new System.Windows.Forms.GroupBox();
            this.chgreenpepers = new System.Windows.Forms.CheckBox();
            this.cholives = new System.Windows.Forms.CheckBox();
            this.chonion = new System.Windows.Forms.CheckBox();
            this.chtomatoos = new System.Windows.Forms.CheckBox();
            this.chmusrooms = new System.Windows.Forms.CheckBox();
            this.chextrachees = new System.Windows.Forms.CheckBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.gpCrust = new System.Windows.Forms.GroupBox();
            this.rbthin = new System.Windows.Forms.RadioButton();
            this.rbthink = new System.Windows.Forms.RadioButton();
            this.gpwheretoeat = new System.Windows.Forms.GroupBox();
            this.rbout = new System.Windows.Forms.RadioButton();
            this.rbeatin = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gpordersummary = new System.Windows.Forms.GroupBox();
            this.lblwheretoeat = new System.Windows.Forms.Label();
            this.lblcrust = new System.Windows.Forms.Label();
            this.lbltoppings = new System.Windows.Forms.Label();
            this.lblsizepizza = new System.Windows.Forms.Label();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblwhere = new System.Windows.Forms.Label();
            this.lblcrusttype = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbltopping = new System.Windows.Forms.Label();
            this.lblsize = new System.Windows.Forms.Label();
            this.gpsize.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpToppings.SuspendLayout();
            this.gpCrust.SuspendLayout();
            this.gpwheretoeat.SuspendLayout();
            this.gpordersummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpsize
            // 
            this.gpsize.Controls.Add(this.groupBox3);
            this.gpsize.Controls.Add(this.rblarge);
            this.gpsize.Controls.Add(this.rbmedium);
            this.gpsize.Controls.Add(this.rbsmall);
            this.gpsize.Location = new System.Drawing.Point(47, 65);
            this.gpsize.Name = "gpsize";
            this.gpsize.Size = new System.Drawing.Size(103, 142);
            this.gpsize.TabIndex = 0;
            this.gpsize.TabStop = false;
            this.gpsize.Text = "size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(8, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(103, 109);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "size";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 108);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Large";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(14, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Smal";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rblarge
            // 
            this.rblarge.AutoSize = true;
            this.rblarge.Location = new System.Drawing.Point(14, 108);
            this.rblarge.Name = "rblarge";
            this.rblarge.Size = new System.Drawing.Size(52, 17);
            this.rblarge.TabIndex = 3;
            this.rblarge.TabStop = true;
            this.rblarge.Tag = "40";
            this.rblarge.Text = "Large";
            this.rblarge.UseVisualStyleBackColor = true;
            this.rblarge.CheckedChanged += new System.EventHandler(this.rblarge_CheckedChanged);
            // 
            // rbmedium
            // 
            this.rbmedium.AutoSize = true;
            this.rbmedium.Location = new System.Drawing.Point(14, 72);
            this.rbmedium.Name = "rbmedium";
            this.rbmedium.Size = new System.Drawing.Size(61, 17);
            this.rbmedium.TabIndex = 1;
            this.rbmedium.TabStop = true;
            this.rbmedium.Tag = "30";
            this.rbmedium.Text = "Medium";
            this.rbmedium.UseVisualStyleBackColor = true;
            this.rbmedium.CheckedChanged += new System.EventHandler(this.rbmedium_CheckedChanged);
            // 
            // rbsmall
            // 
            this.rbsmall.AutoSize = true;
            this.rbsmall.Location = new System.Drawing.Point(14, 32);
            this.rbsmall.Name = "rbsmall";
            this.rbsmall.Size = new System.Drawing.Size(47, 17);
            this.rbsmall.TabIndex = 0;
            this.rbsmall.TabStop = true;
            this.rbsmall.Tag = "20";
            this.rbsmall.Text = "Smal";
            this.rbsmall.UseVisualStyleBackColor = true;
            this.rbsmall.CheckedChanged += new System.EventHandler(this.rbsmall_CheckedChanged);
            // 
            // gpToppings
            // 
            this.gpToppings.Controls.Add(this.chgreenpepers);
            this.gpToppings.Controls.Add(this.cholives);
            this.gpToppings.Controls.Add(this.chonion);
            this.gpToppings.Controls.Add(this.chtomatoos);
            this.gpToppings.Controls.Add(this.chmusrooms);
            this.gpToppings.Controls.Add(this.chextrachees);
            this.gpToppings.Location = new System.Drawing.Point(254, 65);
            this.gpToppings.Name = "gpToppings";
            this.gpToppings.Size = new System.Drawing.Size(285, 142);
            this.gpToppings.TabIndex = 1;
            this.gpToppings.TabStop = false;
            this.gpToppings.Text = "Toppings";
            // 
            // chgreenpepers
            // 
            this.chgreenpepers.AutoSize = true;
            this.chgreenpepers.Location = new System.Drawing.Point(120, 110);
            this.chgreenpepers.Name = "chgreenpepers";
            this.chgreenpepers.Size = new System.Drawing.Size(97, 17);
            this.chgreenpepers.TabIndex = 6;
            this.chgreenpepers.Tag = "5";
            this.chgreenpepers.Text = "Green Peppers";
            this.chgreenpepers.UseVisualStyleBackColor = true;
            this.chgreenpepers.CheckedChanged += new System.EventHandler(this.chgreenpepers_CheckedChanged);
            // 
            // cholives
            // 
            this.cholives.AutoSize = true;
            this.cholives.Location = new System.Drawing.Point(120, 63);
            this.cholives.Name = "cholives";
            this.cholives.Size = new System.Drawing.Size(55, 17);
            this.cholives.TabIndex = 5;
            this.cholives.Tag = "5";
            this.cholives.Text = "Olives";
            this.cholives.UseVisualStyleBackColor = true;
            this.cholives.CheckedChanged += new System.EventHandler(this.cholives_CheckedChanged);
            // 
            // chonion
            // 
            this.chonion.AutoSize = true;
            this.chonion.Location = new System.Drawing.Point(120, 23);
            this.chonion.Name = "chonion";
            this.chonion.Size = new System.Drawing.Size(54, 17);
            this.chonion.TabIndex = 4;
            this.chonion.Tag = "5";
            this.chonion.Text = "Onion";
            this.chonion.UseVisualStyleBackColor = true;
            this.chonion.CheckedChanged += new System.EventHandler(this.chonion_CheckedChanged);
            // 
            // chtomatoos
            // 
            this.chtomatoos.AutoSize = true;
            this.chtomatoos.Location = new System.Drawing.Point(21, 110);
            this.chtomatoos.Name = "chtomatoos";
            this.chtomatoos.Size = new System.Drawing.Size(73, 17);
            this.chtomatoos.TabIndex = 2;
            this.chtomatoos.Tag = "5";
            this.chtomatoos.Text = "Tomatoos";
            this.chtomatoos.UseVisualStyleBackColor = true;
            this.chtomatoos.CheckedChanged += new System.EventHandler(this.chtomatoos_CheckedChanged);
            // 
            // chmusrooms
            // 
            this.chmusrooms.AutoSize = true;
            this.chmusrooms.Location = new System.Drawing.Point(21, 63);
            this.chmusrooms.Name = "chmusrooms";
            this.chmusrooms.Size = new System.Drawing.Size(80, 17);
            this.chmusrooms.TabIndex = 1;
            this.chmusrooms.Tag = "5";
            this.chmusrooms.Text = "Mushrooms";
            this.chmusrooms.UseVisualStyleBackColor = true;
            this.chmusrooms.CheckedChanged += new System.EventHandler(this.chmusrooms_CheckedChanged);
            // 
            // chextrachees
            // 
            this.chextrachees.AutoSize = true;
            this.chextrachees.Location = new System.Drawing.Point(21, 22);
            this.chextrachees.Name = "chextrachees";
            this.chextrachees.Size = new System.Drawing.Size(85, 17);
            this.chextrachees.TabIndex = 0;
            this.chextrachees.Tag = "5";
            this.chextrachees.Text = "Extra Chees";
            this.chextrachees.UseVisualStyleBackColor = true;
            this.chextrachees.CheckedChanged += new System.EventHandler(this.chextrachees_CheckedChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(238, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(301, 36);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "MAKE YOUR PIZZA";
            // 
            // gpCrust
            // 
            this.gpCrust.Controls.Add(this.rbthin);
            this.gpCrust.Controls.Add(this.rbthink);
            this.gpCrust.Location = new System.Drawing.Point(47, 225);
            this.gpCrust.Name = "gpCrust";
            this.gpCrust.Size = new System.Drawing.Size(83, 89);
            this.gpCrust.TabIndex = 3;
            this.gpCrust.TabStop = false;
            this.gpCrust.Text = "Crust Type";
            // 
            // rbthin
            // 
            this.rbthin.AutoSize = true;
            this.rbthin.Location = new System.Drawing.Point(14, 19);
            this.rbthin.Name = "rbthin";
            this.rbthin.Size = new System.Drawing.Size(74, 17);
            this.rbthin.TabIndex = 2;
            this.rbthin.TabStop = true;
            this.rbthin.Tag = "0";
            this.rbthin.Text = "Thin Crust";
            this.rbthin.UseVisualStyleBackColor = true;
            this.rbthin.CheckedChanged += new System.EventHandler(this.rbthin_CheckedChanged);
            // 
            // rbthink
            // 
            this.rbthink.AutoSize = true;
            this.rbthink.Location = new System.Drawing.Point(14, 55);
            this.rbthink.Name = "rbthink";
            this.rbthink.Size = new System.Drawing.Size(79, 17);
            this.rbthink.TabIndex = 1;
            this.rbthink.TabStop = true;
            this.rbthink.Tag = "10";
            this.rbthink.Text = "Think Crust";
            this.rbthink.UseVisualStyleBackColor = true;
            this.rbthink.CheckedChanged += new System.EventHandler(this.rbthink_CheckedChanged);
            // 
            // gpwheretoeat
            // 
            this.gpwheretoeat.Controls.Add(this.rbout);
            this.gpwheretoeat.Controls.Add(this.rbeatin);
            this.gpwheretoeat.Location = new System.Drawing.Point(299, 225);
            this.gpwheretoeat.Name = "gpwheretoeat";
            this.gpwheretoeat.Size = new System.Drawing.Size(184, 60);
            this.gpwheretoeat.TabIndex = 4;
            this.gpwheretoeat.TabStop = false;
            this.gpwheretoeat.Text = "Where To Eat";
            // 
            // rbout
            // 
            this.rbout.AutoSize = true;
            this.rbout.Location = new System.Drawing.Point(105, 30);
            this.rbout.Name = "rbout";
            this.rbout.Size = new System.Drawing.Size(69, 17);
            this.rbout.TabIndex = 3;
            this.rbout.TabStop = true;
            this.rbout.Text = "Take Out";
            this.rbout.UseVisualStyleBackColor = true;
            this.rbout.CheckedChanged += new System.EventHandler(this.rbout_CheckedChanged);
            // 
            // rbeatin
            // 
            this.rbeatin.AutoSize = true;
            this.rbeatin.Location = new System.Drawing.Point(6, 30);
            this.rbeatin.Name = "rbeatin";
            this.rbeatin.Size = new System.Drawing.Size(52, 17);
            this.rbeatin.TabIndex = 2;
            this.rbeatin.TabStop = true;
            this.rbeatin.Text = "Eat in";
            this.rbeatin.UseVisualStyleBackColor = true;
            this.rbeatin.CheckedChanged += new System.EventHandler(this.rbeatin_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(275, 297);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(85, 37);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(404, 297);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(85, 37);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // gpordersummary
            // 
            this.gpordersummary.Controls.Add(this.lblwheretoeat);
            this.gpordersummary.Controls.Add(this.lblcrust);
            this.gpordersummary.Controls.Add(this.lbltoppings);
            this.gpordersummary.Controls.Add(this.lblsizepizza);
            this.gpordersummary.Controls.Add(this.lbltotalprice);
            this.gpordersummary.Controls.Add(this.lbltotal);
            this.gpordersummary.Controls.Add(this.lblwhere);
            this.gpordersummary.Controls.Add(this.lblcrusttype);
            this.gpordersummary.Controls.Add(this.label4);
            this.gpordersummary.Controls.Add(this.lbltopping);
            this.gpordersummary.Controls.Add(this.lblsize);
            this.gpordersummary.Location = new System.Drawing.Point(564, 43);
            this.gpordersummary.Name = "gpordersummary";
            this.gpordersummary.Size = new System.Drawing.Size(336, 291);
            this.gpordersummary.TabIndex = 7;
            this.gpordersummary.TabStop = false;
            this.gpordersummary.Text = "Order Summary";
            // 
            // lblwheretoeat
            // 
            this.lblwheretoeat.AutoSize = true;
            this.lblwheretoeat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwheretoeat.Location = new System.Drawing.Point(113, 199);
            this.lblwheretoeat.Name = "lblwheretoeat";
            this.lblwheretoeat.Size = new System.Drawing.Size(39, 16);
            this.lblwheretoeat.TabIndex = 10;
            this.lblwheretoeat.Text = "Eat in";
            // 
            // lblcrust
            // 
            this.lblcrust.AutoSize = true;
            this.lblcrust.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrust.Location = new System.Drawing.Point(113, 135);
            this.lblcrust.Name = "lblcrust";
            this.lblcrust.Size = new System.Drawing.Size(72, 16);
            this.lblcrust.TabIndex = 9;
            this.lblcrust.Text = "Think Crust";
            // 
            // lbltoppings
            // 
            this.lbltoppings.AutoSize = true;
            this.lbltoppings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoppings.Location = new System.Drawing.Point(38, 100);
            this.lbltoppings.Name = "lbltoppings";
            this.lbltoppings.Size = new System.Drawing.Size(78, 16);
            this.lbltoppings.TabIndex = 8;
            this.lbltoppings.Text = "No Toppings";
            // 
            // lblsizepizza
            // 
            this.lblsizepizza.AutoSize = true;
            this.lblsizepizza.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsizepizza.Location = new System.Drawing.Point(59, 31);
            this.lblsizepizza.Name = "lblsizepizza";
            this.lblsizepizza.Size = new System.Drawing.Size(52, 16);
            this.lblsizepizza.TabIndex = 7;
            this.lblsizepizza.Text = "Medium";
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.AutoSize = true;
            this.lbltotalprice.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.ForeColor = System.Drawing.Color.Green;
            this.lbltotalprice.Location = new System.Drawing.Point(90, 241);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(71, 44);
            this.lbltotalprice.TabIndex = 6;
            this.lbltotalprice.Text = "$0";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltotal.Location = new System.Drawing.Point(12, 221);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(104, 19);
            this.lbltotal.TabIndex = 5;
            this.lbltotal.Text = "Total Price:";
            // 
            // lblwhere
            // 
            this.lblwhere.AutoSize = true;
            this.lblwhere.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwhere.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblwhere.Location = new System.Drawing.Point(12, 169);
            this.lblwhere.Name = "lblwhere";
            this.lblwhere.Size = new System.Drawing.Size(122, 19);
            this.lblwhere.TabIndex = 4;
            this.lblwhere.Text = "Where to Eat:";
            // 
            // lblcrusttype
            // 
            this.lblcrusttype.AutoSize = true;
            this.lblcrusttype.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrusttype.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcrusttype.Location = new System.Drawing.Point(12, 132);
            this.lblcrusttype.Name = "lblcrusttype";
            this.lblcrusttype.Size = new System.Drawing.Size(103, 19);
            this.lblcrusttype.TabIndex = 3;
            this.lblcrusttype.Text = "Crust Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 19);
            this.label4.TabIndex = 2;
            // 
            // lbltopping
            // 
            this.lbltopping.AutoSize = true;
            this.lbltopping.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltopping.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltopping.Location = new System.Drawing.Point(6, 68);
            this.lbltopping.Name = "lbltopping";
            this.lbltopping.Size = new System.Drawing.Size(89, 19);
            this.lbltopping.TabIndex = 1;
            this.lbltopping.Text = "Toppings:";
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsize.Location = new System.Drawing.Point(6, 27);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(49, 19);
            this.lblsize.TabIndex = 0;
            this.lblsize.Text = "Size:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.gpordersummary);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gpwheretoeat);
            this.Controls.Add(this.gpCrust);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.gpToppings);
            this.Controls.Add(this.gpsize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpsize.ResumeLayout(false);
            this.gpsize.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpToppings.ResumeLayout(false);
            this.gpToppings.PerformLayout();
            this.gpCrust.ResumeLayout(false);
            this.gpCrust.PerformLayout();
            this.gpwheretoeat.ResumeLayout(false);
            this.gpwheretoeat.PerformLayout();
            this.gpordersummary.ResumeLayout(false);
            this.gpordersummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpsize;
        private System.Windows.Forms.RadioButton rblarge;
        private System.Windows.Forms.RadioButton rbmedium;
        private System.Windows.Forms.RadioButton rbsmall;
        private System.Windows.Forms.GroupBox gpToppings;
        private System.Windows.Forms.CheckBox chgreenpepers;
        private System.Windows.Forms.CheckBox cholives;
        private System.Windows.Forms.CheckBox chonion;
        private System.Windows.Forms.CheckBox chtomatoos;
        private System.Windows.Forms.CheckBox chmusrooms;
        private System.Windows.Forms.CheckBox chextrachees;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox gpCrust;
        private System.Windows.Forms.RadioButton rbthin;
        private System.Windows.Forms.RadioButton rbthink;
        private System.Windows.Forms.GroupBox gpwheretoeat;
        private System.Windows.Forms.RadioButton rbout;
        private System.Windows.Forms.RadioButton rbeatin;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox gpordersummary;
        private System.Windows.Forms.Label lblcrusttype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltopping;
        private System.Windows.Forms.Label lblsize;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblwhere;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Label lblsizepizza;
        private System.Windows.Forms.Label lblwheretoeat;
        private System.Windows.Forms.Label lblcrust;
        private System.Windows.Forms.Label lbltoppings;
    }
}

