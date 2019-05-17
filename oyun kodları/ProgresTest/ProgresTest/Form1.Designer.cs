namespace ProgresTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOyuncu1 = new System.Windows.Forms.Button();
            this.btnOyuncu2 = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.xoxTimeBar1 = new ProgresTest.XoxTimeBar();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOyuncu1
            // 
            this.btnOyuncu1.Location = new System.Drawing.Point(58, 93);
            this.btnOyuncu1.Name = "btnOyuncu1";
            this.btnOyuncu1.Size = new System.Drawing.Size(75, 23);
            this.btnOyuncu1.TabIndex = 1;
            this.btnOyuncu1.Text = "< Oyuncu1";
            this.btnOyuncu1.UseVisualStyleBackColor = true;
            this.btnOyuncu1.Click += new System.EventHandler(this.btnOyuncu1_Click);
            // 
            // btnOyuncu2
            // 
            this.btnOyuncu2.Location = new System.Drawing.Point(454, 93);
            this.btnOyuncu2.Name = "btnOyuncu2";
            this.btnOyuncu2.Size = new System.Drawing.Size(75, 23);
            this.btnOyuncu2.TabIndex = 1;
            this.btnOyuncu2.Text = "Oyuncu2 >";
            this.btnOyuncu2.UseVisualStyleBackColor = true;
            this.btnOyuncu2.Click += new System.EventHandler(this.btnOyuncu2_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(261, 93);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // xoxTimeBar1
            // 
            this.xoxTimeBar1.BackColor = System.Drawing.SystemColors.Control;
            this.xoxTimeBar1.BlueValue = 5;
            this.xoxTimeBar1.Location = new System.Drawing.Point(91, 25);
            this.xoxTimeBar1.Margin = new System.Windows.Forms.Padding(2);
            this.xoxTimeBar1.Name = "xoxTimeBar1";
            this.xoxTimeBar1.RedValue = 5;
            this.xoxTimeBar1.Size = new System.Drawing.Size(425, 34);
            this.xoxTimeBar1.TabIndex = 0;
            this.xoxTimeBar1.Text = "xoxTimeBar1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 213);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnOyuncu2);
            this.Controls.Add(this.btnOyuncu1);
            this.Controls.Add(this.xoxTimeBar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private XoxTimeBar xoxTimeBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnOyuncu1;
        private System.Windows.Forms.Button btnOyuncu2;
        private System.Windows.Forms.Button btnBaslat;
    }
}

