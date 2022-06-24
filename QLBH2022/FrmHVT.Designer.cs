
namespace QLBH2022
{
    partial class FrmHVT
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
            this.lblHT = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHT.Location = new System.Drawing.Point(62, 38);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(122, 29);
            this.lblHT.TabIndex = 0;
            this.lblHT.Text = "Họ và tên";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(62, 122);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(53, 29);
            this.lblH.TabIndex = 1;
            this.lblH.Text = "Họ ";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(62, 194);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(67, 29);
            this.lblD.TabIndex = 2;
            this.lblD.Text = "Đệm";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(62, 271);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(59, 29);
            this.lblT.TabIndex = 3;
            this.lblT.Text = "Tên";
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(231, 42);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(361, 26);
            this.txtHT.TabIndex = 5;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(231, 126);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(361, 26);
            this.txtH.TabIndex = 6;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(220, 212);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(361, 26);
            this.txtD.TabIndex = 7;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(220, 287);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(361, 26);
            this.txtT.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Tách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmHVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblHT);
            this.Name = "FrmHVT";
            this.Text = "FrmHVT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.Button button1;
    }
}