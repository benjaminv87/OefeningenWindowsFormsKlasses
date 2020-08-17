namespace OefeningenWindowsFormsKlasses
{
    partial class Oefening2
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
            this.btnVolumeVerhoog = new System.Windows.Forms.Button();
            this.btnZenderVerhoog = new System.Windows.Forms.Button();
            this.btnVolumeVerlaag = new System.Windows.Forms.Button();
            this.btnZenderVerlaag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZender = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnStelZenderIn = new System.Windows.Forms.Button();
            this.numZender = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numZender)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolumeVerhoog
            // 
            this.btnVolumeVerhoog.Location = new System.Drawing.Point(132, 102);
            this.btnVolumeVerhoog.Name = "btnVolumeVerhoog";
            this.btnVolumeVerhoog.Size = new System.Drawing.Size(39, 23);
            this.btnVolumeVerhoog.TabIndex = 0;
            this.btnVolumeVerhoog.Text = "+";
            this.btnVolumeVerhoog.UseVisualStyleBackColor = true;
            this.btnVolumeVerhoog.Click += new System.EventHandler(this.btnVolumeVerhoog_Click);
            // 
            // btnZenderVerhoog
            // 
            this.btnZenderVerhoog.Location = new System.Drawing.Point(26, 102);
            this.btnZenderVerhoog.Name = "btnZenderVerhoog";
            this.btnZenderVerhoog.Size = new System.Drawing.Size(38, 23);
            this.btnZenderVerhoog.TabIndex = 1;
            this.btnZenderVerhoog.Text = "+";
            this.btnZenderVerhoog.UseVisualStyleBackColor = true;
            this.btnZenderVerhoog.Click += new System.EventHandler(this.btnZenderVerhoog_Click);
            // 
            // btnVolumeVerlaag
            // 
            this.btnVolumeVerlaag.Location = new System.Drawing.Point(132, 144);
            this.btnVolumeVerlaag.Name = "btnVolumeVerlaag";
            this.btnVolumeVerlaag.Size = new System.Drawing.Size(39, 23);
            this.btnVolumeVerlaag.TabIndex = 2;
            this.btnVolumeVerlaag.Text = "-";
            this.btnVolumeVerlaag.UseVisualStyleBackColor = true;
            this.btnVolumeVerlaag.Click += new System.EventHandler(this.btnVolumeVerlaag_Click);
            // 
            // btnZenderVerlaag
            // 
            this.btnZenderVerlaag.Location = new System.Drawing.Point(26, 144);
            this.btnZenderVerlaag.Name = "btnZenderVerlaag";
            this.btnZenderVerlaag.Size = new System.Drawing.Size(38, 23);
            this.btnZenderVerlaag.TabIndex = 3;
            this.btnZenderVerlaag.Text = "-";
            this.btnZenderVerlaag.UseVisualStyleBackColor = true;
            this.btnZenderVerlaag.Click += new System.EventHandler(this.btnZenderVerlaag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Volume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Zender";
            // 
            // lblZender
            // 
            this.lblZender.AutoSize = true;
            this.lblZender.Location = new System.Drawing.Point(23, 31);
            this.lblZender.Name = "lblZender";
            this.lblZender.Size = new System.Drawing.Size(35, 13);
            this.lblZender.TabIndex = 9;
            this.lblZender.Text = "label4";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(129, 31);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(35, 13);
            this.lblVolume.TabIndex = 10;
            this.lblVolume.Text = "label4";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(129, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 13);
            this.label.TabIndex = 5;
            this.label.Text = "Volume";
            // 
            // btnStelZenderIn
            // 
            this.btnStelZenderIn.Location = new System.Drawing.Point(91, 186);
            this.btnStelZenderIn.Name = "btnStelZenderIn";
            this.btnStelZenderIn.Size = new System.Drawing.Size(37, 20);
            this.btnStelZenderIn.TabIndex = 12;
            this.btnStelZenderIn.Text = "=>";
            this.btnStelZenderIn.UseVisualStyleBackColor = true;
            this.btnStelZenderIn.Click += new System.EventHandler(this.btnStelZenderIn_Click);
            // 
            // numZender
            // 
            this.numZender.Location = new System.Drawing.Point(26, 186);
            this.numZender.Name = "numZender";
            this.numZender.Size = new System.Drawing.Size(59, 20);
            this.numZender.TabIndex = 13;
            // 
            // Oefening2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 213);
            this.Controls.Add(this.numZender);
            this.Controls.Add(this.btnStelZenderIn);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblZender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnZenderVerlaag);
            this.Controls.Add(this.btnVolumeVerlaag);
            this.Controls.Add(this.btnZenderVerhoog);
            this.Controls.Add(this.btnVolumeVerhoog);
            this.Name = "Oefening2";
            this.Text = "Oefening2";
            this.Load += new System.EventHandler(this.Oefening2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numZender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolumeVerhoog;
        private System.Windows.Forms.Button btnZenderVerhoog;
        private System.Windows.Forms.Button btnVolumeVerlaag;
        private System.Windows.Forms.Button btnZenderVerlaag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblZender;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnStelZenderIn;
        private System.Windows.Forms.NumericUpDown numZender;
    }
}