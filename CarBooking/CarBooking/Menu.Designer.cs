
namespace CarBooking
{
    partial class Menu
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
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.btnRentCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReturnCar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnReturnCar.Location = new System.Drawing.Point(226, 75);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(117, 43);
            this.btnReturnCar.TabIndex = 0;
            this.btnReturnCar.Text = "Återlämna bil";
            this.btnReturnCar.UseVisualStyleBackColor = false;
            this.btnReturnCar.Click += new System.EventHandler(this.returnCarbtn_Click);
            // 
            // btnRentCar
            // 
            this.btnRentCar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRentCar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnRentCar.Location = new System.Drawing.Point(63, 75);
            this.btnRentCar.Name = "btnRentCar";
            this.btnRentCar.Size = new System.Drawing.Size(117, 43);
            this.btnRentCar.TabIndex = 1;
            this.btnRentCar.Text = "Hyra bil";
            this.btnRentCar.UseVisualStyleBackColor = false;
            this.btnRentCar.Click += new System.EventHandler(this.rentCarbtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 211);
            this.Controls.Add(this.btnRentCar);
            this.Controls.Add(this.btnReturnCar);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meny";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button returnCarbtn;
        private System.Windows.Forms.Button btnRentCar;
        private System.Windows.Forms.Button btnReturnCar;
    }
}