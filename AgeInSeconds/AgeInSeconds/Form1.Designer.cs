namespace AgeInSeconds
{
    partial class AgerForm
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
            this.Seconds = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.DateTimePicker();
            this.symbol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Seconds
            // 
            this.Seconds.Location = new System.Drawing.Point(243, 12);
            this.Seconds.Name = "Seconds";
            this.Seconds.Size = new System.Drawing.Size(152, 20);
            this.Seconds.TabIndex = 0;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(12, 12);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(200, 20);
            this.Age.TabIndex = 1;
            this.Age.ValueChanged += new System.EventHandler(this.Age_ValueChanged);
            // 
            // symbol
            // 
            this.symbol.AutoSize = true;
            this.symbol.Location = new System.Drawing.Point(221, 15);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(16, 13);
            this.symbol.TabIndex = 2;
            this.symbol.Text = "△";
            // 
            // AgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 42);
            this.Controls.Add(this.symbol);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Seconds);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgerForm";
            this.ShowIcon = false;
            this.Text = "Ager";
            this.Load += new System.EventHandler(this.AgerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Seconds;
        private System.Windows.Forms.DateTimePicker Age;
        private System.Windows.Forms.Label symbol;
    }
}

