namespace IOOP_Group_Assignment
{
    partial class DeleteCustomer
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
            this.CustomerID_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteCustomer_Btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerID_TextBox
            // 
            this.CustomerID_TextBox.Location = new System.Drawing.Point(400, 171);
            this.CustomerID_TextBox.Name = "CustomerID_TextBox";
            this.CustomerID_TextBox.Size = new System.Drawing.Size(166, 20);
            this.CustomerID_TextBox.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(234, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 109;
            this.label4.Text = "Customer ID:";
            // 
            // DeleteCustomer_Btn
            // 
            this.DeleteCustomer_Btn.AutoSize = true;
            this.DeleteCustomer_Btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.DeleteCustomer_Btn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DeleteCustomer_Btn.FlatAppearance.BorderSize = 0;
            this.DeleteCustomer_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.DeleteCustomer_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteCustomer_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCustomer_Btn.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCustomer_Btn.ForeColor = System.Drawing.Color.White;
            this.DeleteCustomer_Btn.Location = new System.Drawing.Point(285, 247);
            this.DeleteCustomer_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteCustomer_Btn.Name = "DeleteCustomer_Btn";
            this.DeleteCustomer_Btn.Size = new System.Drawing.Size(229, 32);
            this.DeleteCustomer_Btn.TabIndex = 108;
            this.DeleteCustomer_Btn.Text = "Delete Customer";
            this.DeleteCustomer_Btn.UseVisualStyleBackColor = false;
            this.DeleteCustomer_Btn.Click += new System.EventHandler(this.DeleteCustomer_Btn_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(288, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 29);
            this.label6.TabIndex = 111;
            this.label6.Text = "Delete Customer";
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CustomerID_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeleteCustomer_Btn);
            this.Name = "DeleteCustomer";
            this.Text = "DeleteCustomer";
            this.Load += new System.EventHandler(this.DeleteCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerID_TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DeleteCustomer_Btn;
        private System.Windows.Forms.Label label6;
    }
}