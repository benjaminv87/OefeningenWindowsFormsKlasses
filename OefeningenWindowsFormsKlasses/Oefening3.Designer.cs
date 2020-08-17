namespace OefeningenWindowsFormsKlasses
{
    partial class Oefening3
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
            this.lbLijst = new System.Windows.Forms.ListBox();
            this.cbVakken = new System.Windows.Forms.ComboBox();
            this.numPunten = new System.Windows.Forms.NumericUpDown();
            this.btnPuntenToevoegen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbVakNaam = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVakToevoegen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerwijderPunt = new System.Windows.Forms.Button();
            this.lblGemiddelde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPunten)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLijst
            // 
            this.lbLijst.FormattingEnabled = true;
            this.lbLijst.Location = new System.Drawing.Point(6, 72);
            this.lbLijst.Name = "lbLijst";
            this.lbLijst.Size = new System.Drawing.Size(135, 160);
            this.lbLijst.TabIndex = 0;
            this.lbLijst.SelectedIndexChanged += new System.EventHandler(this.lbLijst_SelectedIndexChanged);
            // 
            // cbVakken
            // 
            this.cbVakken.FormattingEnabled = true;
            this.cbVakken.Location = new System.Drawing.Point(6, 19);
            this.cbVakken.Name = "cbVakken";
            this.cbVakken.Size = new System.Drawing.Size(135, 21);
            this.cbVakken.TabIndex = 1;
            this.cbVakken.SelectedIndexChanged += new System.EventHandler(this.cbVakken_SelectedIndexChanged);
            // 
            // numPunten
            // 
            this.numPunten.Location = new System.Drawing.Point(6, 46);
            this.numPunten.Name = "numPunten";
            this.numPunten.Size = new System.Drawing.Size(100, 20);
            this.numPunten.TabIndex = 2;
            // 
            // btnPuntenToevoegen
            // 
            this.btnPuntenToevoegen.Location = new System.Drawing.Point(112, 46);
            this.btnPuntenToevoegen.Name = "btnPuntenToevoegen";
            this.btnPuntenToevoegen.Size = new System.Drawing.Size(29, 20);
            this.btnPuntenToevoegen.TabIndex = 3;
            this.btnPuntenToevoegen.Text = "=>";
            this.btnPuntenToevoegen.UseVisualStyleBackColor = true;
            this.btnPuntenToevoegen.Click += new System.EventHandler(this.btnPuntenToevoegen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rapport";
            // 
            // tbVakNaam
            // 
            this.tbVakNaam.Location = new System.Drawing.Point(6, 19);
            this.tbVakNaam.Name = "tbVakNaam";
            this.tbVakNaam.Size = new System.Drawing.Size(100, 20);
            this.tbVakNaam.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVakToevoegen);
            this.groupBox1.Controls.Add(this.tbVakNaam);
            this.groupBox1.Location = new System.Drawing.Point(15, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vak Toevoegen";
            // 
            // btnVakToevoegen
            // 
            this.btnVakToevoegen.Location = new System.Drawing.Point(112, 19);
            this.btnVakToevoegen.Name = "btnVakToevoegen";
            this.btnVakToevoegen.Size = new System.Drawing.Size(29, 20);
            this.btnVakToevoegen.TabIndex = 7;
            this.btnVakToevoegen.Text = "=>";
            this.btnVakToevoegen.UseVisualStyleBackColor = true;
            this.btnVakToevoegen.Click += new System.EventHandler(this.btnVakToevoegen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerwijderPunt);
            this.groupBox2.Controls.Add(this.lblGemiddelde);
            this.groupBox2.Controls.Add(this.cbVakken);
            this.groupBox2.Controls.Add(this.lbLijst);
            this.groupBox2.Controls.Add(this.numPunten);
            this.groupBox2.Controls.Add(this.btnPuntenToevoegen);
            this.groupBox2.Location = new System.Drawing.Point(15, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 290);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultaten";
            // 
            // btnVerwijderPunt
            // 
            this.btnVerwijderPunt.Location = new System.Drawing.Point(6, 237);
            this.btnVerwijderPunt.Name = "btnVerwijderPunt";
            this.btnVerwijderPunt.Size = new System.Drawing.Size(135, 23);
            this.btnVerwijderPunt.TabIndex = 5;
            this.btnVerwijderPunt.Text = "Verwijder geselecteerde";
            this.btnVerwijderPunt.UseVisualStyleBackColor = true;
            this.btnVerwijderPunt.Visible = false;
            this.btnVerwijderPunt.Click += new System.EventHandler(this.btnVerwijderPunt_Click);
            // 
            // lblGemiddelde
            // 
            this.lblGemiddelde.AutoSize = true;
            this.lblGemiddelde.Location = new System.Drawing.Point(6, 263);
            this.lblGemiddelde.Name = "lblGemiddelde";
            this.lblGemiddelde.Size = new System.Drawing.Size(69, 13);
            this.lblGemiddelde.TabIndex = 4;
            this.lblGemiddelde.Text = "Gemiddelde :";
            // 
            // Oefening3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Oefening3";
            this.Text = "Oefening3";
            ((System.ComponentModel.ISupportInitialize)(this.numPunten)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLijst;
        private System.Windows.Forms.ComboBox cbVakken;
        private System.Windows.Forms.NumericUpDown numPunten;
        private System.Windows.Forms.Button btnPuntenToevoegen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbVakNaam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVakToevoegen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGemiddelde;
        private System.Windows.Forms.Button btnVerwijderPunt;
    }
}