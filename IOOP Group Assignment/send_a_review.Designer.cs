namespace IOOP_Group_Assignment
{
    partial class send_a_review
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcomment = new System.Windows.Forms.TextBox();
            this.numUpDown_rating = new System.Windows.Forms.NumericUpDown();
            this.btnsend_a_review = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_rating)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rate:";
            // 
            // txtcomment
            // 
            this.txtcomment.Location = new System.Drawing.Point(63, 145);
            this.txtcomment.Margin = new System.Windows.Forms.Padding(4);
            this.txtcomment.Multiline = true;
            this.txtcomment.Name = "txtcomment";
            this.txtcomment.Size = new System.Drawing.Size(655, 221);
            this.txtcomment.TabIndex = 3;
            this.txtcomment.TextChanged += new System.EventHandler(this.txtcomment_TextChanged);
            // 
            // numUpDown_rating
            // 
            this.numUpDown_rating.Location = new System.Drawing.Point(598, 45);
            this.numUpDown_rating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown_rating.Name = "numUpDown_rating";
            this.numUpDown_rating.Size = new System.Drawing.Size(120, 22);
            this.numUpDown_rating.TabIndex = 4;
            this.numUpDown_rating.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnsend_a_review
            // 
            this.btnsend_a_review.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnsend_a_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend_a_review.ForeColor = System.Drawing.Color.Transparent;
            this.btnsend_a_review.Location = new System.Drawing.Point(586, 373);
            this.btnsend_a_review.Name = "btnsend_a_review";
            this.btnsend_a_review.Size = new System.Drawing.Size(154, 59);
            this.btnsend_a_review.TabIndex = 5;
            this.btnsend_a_review.Text = "send a review ";
            this.btnsend_a_review.UseVisualStyleBackColor = false;
            this.btnsend_a_review.Click += new System.EventHandler(this.btnsend_a_review_Click);
            // 
            // send_a_review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.btnsend_a_review);
            this.Controls.Add(this.numUpDown_rating);
            this.Controls.Add(this.txtcomment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "send_a_review";
            this.Text = "send_a_review";
            this.Load += new System.EventHandler(this.send_a_review_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcomment;
        private System.Windows.Forms.NumericUpDown numUpDown_rating;
        private System.Windows.Forms.Button btnsend_a_review;
    }
}