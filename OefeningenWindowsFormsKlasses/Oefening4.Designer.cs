namespace OefeningenWindowsFormsKlasses
{
    partial class Oefening4
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
            this.Lengte = new System.Windows.Forms.Label();
            this.Breedte = new System.Windows.Forms.Label();
            this.Hoogte = new System.Windows.Forms.Label();
            this.numLengte = new System.Windows.Forms.NumericUpDown();
            this.numBreedte = new System.Windows.Forms.NumericUpDown();
            this.numHoogte = new System.Windows.Forms.NumericUpDown();
            this.lblInhoud = new System.Windows.Forms.Label();
            this.btnBerekenInhoud = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLengte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreedte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoogte)).BeginInit();
            this.SuspendLayout();
            // 
            // Lengte
            // 
            this.Lengte.AutoSize = true;
            this.Lengte.Location = new System.Drawing.Point(41, 22);
            this.Lengte.Name = "Lengte";
            this.Lengte.Size = new System.Drawing.Size(40, 13);
            this.Lengte.TabIndex = 0;
            this.Lengte.Text = "Lengte";
            // 
            // Breedte
            // 
            this.Breedte.AutoSize = true;
            this.Breedte.Location = new System.Drawing.Point(37, 48);
            this.Breedte.Name = "Breedte";
            this.Breedte.Size = new System.Drawing.Size(44, 13);
            this.Breedte.TabIndex = 1;
            this.Breedte.Text = "Breedte";
            // 
            // Hoogte
            // 
            this.Hoogte.AutoSize = true;
            this.Hoogte.Location = new System.Drawing.Point(37, 76);
            this.Hoogte.Name = "Hoogte";
            this.Hoogte.Size = new System.Drawing.Size(42, 13);
            this.Hoogte.TabIndex = 2;
            this.Hoogte.Text = "Hoogte";
            // 
            // numLengte
            // 
            this.numLengte.DecimalPlaces = 2;
            this.numLengte.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numLengte.Location = new System.Drawing.Point(124, 22);
            this.numLengte.Name = "numLengte";
            this.numLengte.Size = new System.Drawing.Size(120, 20);
            this.numLengte.TabIndex = 3;
            // 
            // numBreedte
            // 
            this.numBreedte.DecimalPlaces = 2;
            this.numBreedte.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBreedte.Location = new System.Drawing.Point(124, 48);
            this.numBreedte.Name = "numBreedte";
            this.numBreedte.Size = new System.Drawing.Size(120, 20);
            this.numBreedte.TabIndex = 4;
            // 
            // numHoogte
            // 
            this.numHoogte.DecimalPlaces = 2;
            this.numHoogte.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numHoogte.Location = new System.Drawing.Point(124, 74);
            this.numHoogte.Name = "numHoogte";
            this.numHoogte.Size = new System.Drawing.Size(120, 20);
            this.numHoogte.TabIndex = 5;
            // 
            // lblInhoud
            // 
            this.lblInhoud.AutoSize = true;
            this.lblInhoud.Location = new System.Drawing.Point(12, 136);
            this.lblInhoud.Name = "lblInhoud";
            this.lblInhoud.Size = new System.Drawing.Size(69, 13);
            this.lblInhoud.TabIndex = 6;
            this.lblInhoud.Text = "Label Inhoud";
            // 
            // btnBerekenInhoud
            // 
            this.btnBerekenInhoud.Location = new System.Drawing.Point(80, 100);
            this.btnBerekenInhoud.Name = "btnBerekenInhoud";
            this.btnBerekenInhoud.Size = new System.Drawing.Size(120, 23);
            this.btnBerekenInhoud.TabIndex = 7;
            this.btnBerekenInhoud.Text = "Bereken Inhoud";
            this.btnBerekenInhoud.UseVisualStyleBackColor = true;
            this.btnBerekenInhoud.Click += new System.EventHandler(this.btnBerekenInhoud_Click);
            // 
            // Oefening4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 163);
            this.Controls.Add(this.btnBerekenInhoud);
            this.Controls.Add(this.lblInhoud);
            this.Controls.Add(this.numHoogte);
            this.Controls.Add(this.numBreedte);
            this.Controls.Add(this.numLengte);
            this.Controls.Add(this.Hoogte);
            this.Controls.Add(this.Breedte);
            this.Controls.Add(this.Lengte);
            this.Name = "Oefening4";
            this.Text = "Oefening4";
            this.Load += new System.EventHandler(this.Oefening4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLengte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBreedte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHoogte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lengte;
        private System.Windows.Forms.Label Breedte;
        private System.Windows.Forms.Label Hoogte;
        private System.Windows.Forms.NumericUpDown numLengte;
        private System.Windows.Forms.NumericUpDown numBreedte;
        private System.Windows.Forms.NumericUpDown numHoogte;
        private System.Windows.Forms.Label lblInhoud;
        private System.Windows.Forms.Button btnBerekenInhoud;
    }
}