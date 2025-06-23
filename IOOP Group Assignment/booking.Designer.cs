namespace IOOP_Group_Assignment
{
    partial class Booking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CusIDTextbox = new System.Windows.Forms.TextBox();
            this.BokingBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.data_Booking = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_Booking)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(263, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search For Bookings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(207, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Customer ID:";
            // 
            // CusIDTextbox
            // 
            this.CusIDTextbox.Location = new System.Drawing.Point(363, 97);
            this.CusIDTextbox.Name = "CusIDTextbox";
            this.CusIDTextbox.Size = new System.Drawing.Size(228, 20);
            this.CusIDTextbox.TabIndex = 22;
            // 
            // BokingBtn
            // 
            this.BokingBtn.AutoSize = true;
            this.BokingBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.BokingBtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BokingBtn.FlatAppearance.BorderSize = 0;
            this.BokingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.BokingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.BokingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BokingBtn.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BokingBtn.ForeColor = System.Drawing.Color.White;
            this.BokingBtn.Location = new System.Drawing.Point(276, 151);
            this.BokingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BokingBtn.Name = "BokingBtn";
            this.BokingBtn.Size = new System.Drawing.Size(229, 32);
            this.BokingBtn.TabIndex = 23;
            this.BokingBtn.Text = "Submit";
            this.BokingBtn.UseVisualStyleBackColor = false;
            this.BokingBtn.Click += new System.EventHandler(this.BokingBtn_Click_1);
            // 
            // data_Booking
            // 
            this.data_Booking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Booking.Location = new System.Drawing.Point(155, 200);
            this.data_Booking.Name = "data_Booking";
            this.data_Booking.Size = new System.Drawing.Size(505, 238);
            this.data_Booking.TabIndex = 25;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_Booking);
            this.Controls.Add(this.BokingBtn);
            this.Controls.Add(this.CusIDTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Booking";
            this.Text = "booking";
            this.Load += new System.EventHandler(this.booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Booking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CusIDTextbox;
        private System.Windows.Forms.Button BokingBtn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView data_Booking;
    }
}