namespace IOOP_Group_Assignment
{
    partial class Checkout
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
            this.CheckOut_btn = new System.Windows.Forms.Button();
            this.paymBtn = new System.Windows.Forms.Button();
            this.labelBill = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paymTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckOut_btn
            // 
            this.CheckOut_btn.AutoSize = true;
            this.CheckOut_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.CheckOut_btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.CheckOut_btn.FlatAppearance.BorderSize = 0;
            this.CheckOut_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.CheckOut_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.CheckOut_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOut_btn.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOut_btn.ForeColor = System.Drawing.Color.White;
            this.CheckOut_btn.Location = new System.Drawing.Point(171, 354);
            this.CheckOut_btn.Margin = new System.Windows.Forms.Padding(2);
            this.CheckOut_btn.Name = "CheckOut_btn";
            this.CheckOut_btn.Size = new System.Drawing.Size(229, 32);
            this.CheckOut_btn.TabIndex = 17;
            this.CheckOut_btn.Text = "Check Out";
            this.CheckOut_btn.UseVisualStyleBackColor = false;
            this.CheckOut_btn.Click += new System.EventHandler(this.CheckOut_btn_Click_1);
            // 
            // paymBtn
            // 
            this.paymBtn.AutoSize = true;
            this.paymBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.paymBtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.paymBtn.FlatAppearance.BorderSize = 0;
            this.paymBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.paymBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.paymBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymBtn.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymBtn.ForeColor = System.Drawing.Color.White;
            this.paymBtn.Location = new System.Drawing.Point(445, 354);
            this.paymBtn.Margin = new System.Windows.Forms.Padding(2);
            this.paymBtn.Name = "paymBtn";
            this.paymBtn.Size = new System.Drawing.Size(229, 32);
            this.paymBtn.TabIndex = 18;
            this.paymBtn.Text = "Collect Payment";
            this.paymBtn.UseVisualStyleBackColor = false;
            this.paymBtn.Click += new System.EventHandler(this.paymBtn_Click_1);
            // 
            // labelBill
            // 
            this.labelBill.AutoSize = true;
            this.labelBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelBill.Location = new System.Drawing.Point(624, 306);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(0, 13);
            this.labelBill.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(281, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 29);
            this.label6.TabIndex = 79;
            this.label6.Text = "Check Out Customer";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // name_TextBox
            // 
            this.name_TextBox.Location = new System.Drawing.Point(445, 121);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(166, 20);
            this.name_TextBox.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(275, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "CustomerID";
            // 
            // paymTextbox
            // 
            this.paymTextbox.Location = new System.Drawing.Point(369, 255);
            this.paymTextbox.Name = "paymTextbox";
            this.paymTextbox.Size = new System.Drawing.Size(100, 20);
            this.paymTextbox.TabIndex = 84;
            this.paymTextbox.TextChanged += new System.EventHandler(this.paymTextbox_TextChanged);
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paymTextbox);
            this.Controls.Add(this.labelBill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.paymBtn);
            this.Controls.Add(this.CheckOut_btn);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckOut_btn;
        private System.Windows.Forms.Button paymBtn;
        private System.Windows.Forms.Label labelBill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paymTextbox;
    }
}