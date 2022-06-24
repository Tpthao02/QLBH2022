
namespace QLBH2022
{
    partial class FormTienDien
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
            this.lbld = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.Location = new System.Drawing.Point(86, 79);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(100, 20);
            this.lbld.TabIndex = 0;
            this.lbld.Text = "Chi So Dau";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc.Location = new System.Drawing.Point(522, 96);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(103, 20);
            this.lblc.TabIndex = 1;
            this.lblc.Text = "Chi So Cuoi";
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(80, 134);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(115, 26);
            this.txtd.TabIndex = 2;
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(526, 134);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(115, 26);
            this.txtc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tong Tien Dien";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(281, 331);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(33, 20);
            this.lblKQ.TabIndex = 5;
            this.lblKQ.Text = "KQ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(301, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thuc Hien";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.lblc);
            this.Controls.Add(this.lbld);
            this.Name = "FormTienDien";
            this.Text = "FormTienDien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}