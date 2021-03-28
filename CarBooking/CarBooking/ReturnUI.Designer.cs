
namespace CarBooking
{
    partial class ReturnUI
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
            this.txtboxPersonNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturnCar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxDistance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxPersonNumber
            // 
            this.txtboxPersonNumber.Location = new System.Drawing.Point(57, 59);
            this.txtboxPersonNumber.Name = "txtboxPersonNumber";
            this.txtboxPersonNumber.Size = new System.Drawing.Size(100, 23);
            this.txtboxPersonNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personnummer";
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.Location = new System.Drawing.Point(57, 112);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(75, 23);
            this.btnReturnCar.TabIndex = 2;
            this.btnReturnCar.Text = "Återlämna";
            this.btnReturnCar.UseVisualStyleBackColor = true;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mätarställning";
            // 
            // txtboxDistance
            // 
            this.txtboxDistance.Location = new System.Drawing.Point(205, 59);
            this.txtboxDistance.Name = "txtboxDistance";
            this.txtboxDistance.Size = new System.Drawing.Size(100, 23);
            this.txtboxDistance.TabIndex = 3;
            // 
            // ReturnUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxDistance);
            this.Controls.Add(this.btnReturnCar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxPersonNumber);
            this.Name = "ReturnUI";
            this.Text = "ReturnUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxPersonNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxDistance;
        private System.Windows.Forms.TextBox txtbox;
    }
}