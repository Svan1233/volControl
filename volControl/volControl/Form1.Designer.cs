namespace volControl
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
            this.btnVU = new System.Windows.Forms.Button();
            this.btnVD = new System.Windows.Forms.Button();
            this.slider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVU
            // 
            this.btnVU.Location = new System.Drawing.Point(394, 172);
            this.btnVU.Name = "btnVU";
            this.btnVU.Size = new System.Drawing.Size(75, 44);
            this.btnVU.TabIndex = 0;
            this.btnVU.Text = "Volume up";
            this.btnVU.UseVisualStyleBackColor = true;
            this.btnVU.Click += new System.EventHandler(this.btnVU_Click);
            // 
            // btnVD
            // 
            this.btnVD.Location = new System.Drawing.Point(222, 172);
            this.btnVD.Name = "btnVD";
            this.btnVD.Size = new System.Drawing.Size(75, 44);
            this.btnVD.TabIndex = 1;
            this.btnVD.Text = "Volume down";
            this.btnVD.UseVisualStyleBackColor = true;
            this.btnVD.Click += new System.EventHandler(this.btnVD_Click);
            // 
            // slider
            // 
            this.slider.Location = new System.Drawing.Point(96, 87);
            this.slider.Maximum = 100;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(534, 45);
            this.slider.TabIndex = 2;
            this.slider.Scroll += new System.EventHandler(this.slider_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.btnVD);
            this.Controls.Add(this.btnVU);
            this.Name = "Form1";
            this.Text = "Windows volume control";
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVU;
        private System.Windows.Forms.Button btnVD;
        private System.Windows.Forms.TrackBar slider;
    }
}

