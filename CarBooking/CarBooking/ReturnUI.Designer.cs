
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtboxPersonNumber
            // 
            this.txtboxPersonNumber.Location = new System.Drawing.Point(33, 54);
            this.txtboxPersonNumber.Name = "txtboxPersonNumber";
            this.txtboxPersonNumber.Size = new System.Drawing.Size(136, 23);
            this.txtboxPersonNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personnummer";
            // 
            // btnReturnCar
            // 
            this.btnReturnCar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReturnCar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnReturnCar.Location = new System.Drawing.Point(235, 101);
            this.btnReturnCar.Name = "btnReturnCar";
            this.btnReturnCar.Size = new System.Drawing.Size(117, 43);
            this.btnReturnCar.TabIndex = 2;
            this.btnReturnCar.Text = "Återlämna";
            this.btnReturnCar.UseVisualStyleBackColor = false;
            this.btnReturnCar.Click += new System.EventHandler(this.btnReturnCar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mätarställning";
            // 
            // txtboxDistance
            // 
            this.txtboxDistance.Location = new System.Drawing.Point(33, 116);
            this.txtboxDistance.Name = "txtboxDistance";
            this.txtboxDistance.Size = new System.Drawing.Size(136, 23);
            this.txtboxDistance.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnReturnCar);
            this.groupBox1.Controls.Add(this.txtboxPersonNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtboxDistance);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 188);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Återlämna bil";
            // 
            // ReturnUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 211);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReturnUI";
            this.Text = "ReturnUI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxPersonNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturnCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxDistance;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}