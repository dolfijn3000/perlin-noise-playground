namespace PerlinNoisePlayGround
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.scaleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seedText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.octaveText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.persistanceText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lacunarityText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(219, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scaleText
            // 
            this.scaleText.Location = new System.Drawing.Point(12, 58);
            this.scaleText.Name = "scaleText";
            this.scaleText.Size = new System.Drawing.Size(100, 20);
            this.scaleText.TabIndex = 2;
            this.scaleText.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "scale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "seed";
            // 
            // seedText
            // 
            this.seedText.Location = new System.Drawing.Point(12, 96);
            this.seedText.Name = "seedText";
            this.seedText.Size = new System.Drawing.Size(100, 20);
            this.seedText.TabIndex = 4;
            this.seedText.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "octaves";
            // 
            // octaveText
            // 
            this.octaveText.Location = new System.Drawing.Point(12, 138);
            this.octaveText.Name = "octaveText";
            this.octaveText.Size = new System.Drawing.Size(100, 20);
            this.octaveText.TabIndex = 6;
            this.octaveText.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "persistance";
            // 
            // persistanceText
            // 
            this.persistanceText.Location = new System.Drawing.Point(12, 178);
            this.persistanceText.Name = "persistanceText";
            this.persistanceText.Size = new System.Drawing.Size(100, 20);
            this.persistanceText.TabIndex = 8;
            this.persistanceText.Text = "0.5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "lacunarity";
            // 
            // lacunarityText
            // 
            this.lacunarityText.Location = new System.Drawing.Point(12, 216);
            this.lacunarityText.Name = "lacunarityText";
            this.lacunarityText.Size = new System.Drawing.Size(100, 20);
            this.lacunarityText.TabIndex = 10;
            this.lacunarityText.Text = "1.87";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lacunarityText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.persistanceText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.octaveText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seedText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scaleText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox scaleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seedText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox octaveText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox persistanceText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lacunarityText;
    }
}

