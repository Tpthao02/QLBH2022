
namespace QLBH2022
{
    partial class FormHVT
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
            this.lblht = new System.Windows.Forms.Label();
            this.lblh = new System.Windows.Forms.Label();
            this.lbld = new System.Windows.Forms.Label();
            this.lblt = new System.Windows.Forms.Label();
            this.txtht = new System.Windows.Forms.TextBox();
            this.txth = new System.Windows.Forms.TextBox();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txtt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblht
            // 
            this.lblht.AutoSize = true;
            this.lblht.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblht.Location = new System.Drawing.Point(81, 61);
            this.lblht.Name = "lblht";
            this.lblht.Size = new System.Drawing.Size(117, 25);
            this.lblht.TabIndex = 0;
            this.lblht.Text = "Ho va ten :";
            // 
            // lblh
            // 
            this.lblh.AutoSize = true;
            this.lblh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblh.Location = new System.Drawing.Point(81, 150);
            this.lblh.Name = "lblh";
            this.lblh.Size = new System.Drawing.Size(58, 25);
            this.lblh.TabIndex = 1;
            this.lblh.Text = "Ho  :";
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.Location = new System.Drawing.Point(81, 216);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(69, 25);
            this.lbld.TabIndex = 2;
            this.lbld.Text = "Dem :";
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt.Location = new System.Drawing.Point(81, 285);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(63, 25);
            this.lblt.TabIndex = 3;
            this.lblt.Text = "Ten :";
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(249, 62);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(309, 26);
            this.txtht.TabIndex = 4;
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(249, 151);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(309, 26);
            this.txth.TabIndex = 5;
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(249, 217);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(309, 26);
            this.txtd.TabIndex = 6;
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(249, 284);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(309, 26);
            this.txtt.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(314, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tach";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.txtht);
            this.Controls.Add(this.lblt);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.lblh);
            this.Controls.Add(this.lblht);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblht;
        private System.Windows.Forms.Label lblh;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.Button button1;
    }
}

