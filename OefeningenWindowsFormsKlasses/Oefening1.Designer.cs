namespace OefeningenWindowsFormsKlasses
{
    partial class Oefening1
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
            this.btnEinde = new System.Windows.Forms.Button();
            this.btnVerhoog = new System.Windows.Forms.Button();
            this.btnVerlaag = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEinde
            // 
            this.btnEinde.Location = new System.Drawing.Point(12, 128);
            this.btnEinde.Name = "btnEinde";
            this.btnEinde.Size = new System.Drawing.Size(131, 23);
            this.btnEinde.TabIndex = 0;
            this.btnEinde.Text = "Einde";
            this.btnEinde.UseVisualStyleBackColor = true;
            this.btnEinde.Click += new System.EventHandler(this.btnEinde_Click);
            // 
            // btnVerhoog
            // 
            this.btnVerhoog.Location = new System.Drawing.Point(12, 41);
            this.btnVerhoog.Name = "btnVerhoog";
            this.btnVerhoog.Size = new System.Drawing.Size(131, 23);
            this.btnVerhoog.TabIndex = 1;
            this.btnVerhoog.Text = "Verhoog teller met 1";
            this.btnVerhoog.UseVisualStyleBackColor = true;
            this.btnVerhoog.Click += new System.EventHandler(this.btnVerhoog_Click);
            // 
            // btnVerlaag
            // 
            this.btnVerlaag.Location = new System.Drawing.Point(12, 70);
            this.btnVerlaag.Name = "btnVerlaag";
            this.btnVerlaag.Size = new System.Drawing.Size(131, 23);
            this.btnVerlaag.TabIndex = 2;
            this.btnVerlaag.Text = "Verminder teller met 1";
            this.btnVerlaag.UseVisualStyleBackColor = true;
            this.btnVerlaag.Click += new System.EventHandler(this.btnVerlaag_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 99);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset teller naar 0";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLees
            // 
            this.btnLees.Location = new System.Drawing.Point(12, 12);
            this.btnLees.Name = "btnLees";
            this.btnLees.Size = new System.Drawing.Size(131, 23);
            this.btnLees.TabIndex = 4;
            this.btnLees.Text = "Lezen waarde teller";
            this.btnLees.UseVisualStyleBackColor = true;
            this.btnLees.Click += new System.EventHandler(this.btnLees_Click);
            // 
            // Oefening1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLees);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnVerlaag);
            this.Controls.Add(this.btnVerhoog);
            this.Controls.Add(this.btnEinde);
            this.Name = "Oefening1";
            this.Text = "Oefening1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEinde;
        private System.Windows.Forms.Button btnVerhoog;
        private System.Windows.Forms.Button btnVerlaag;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLees;
    }
}