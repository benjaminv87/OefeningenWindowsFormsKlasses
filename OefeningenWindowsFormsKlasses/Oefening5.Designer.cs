namespace OefeningenWindowsFormsKlasses
{
    partial class Oefening5
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
            this.gbMaakKlas = new System.Windows.Forms.GroupBox();
            this.btnKlasAnnuleren = new System.Windows.Forms.Button();
            this.btnKlasToevoegen = new System.Windows.Forms.Button();
            this.tbKlasJaar = new System.Windows.Forms.TextBox();
            this.tbKlasNaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMaakLeerling = new System.Windows.Forms.GroupBox();
            this.btnLeerlingAnnuleren = new System.Windows.Forms.Button();
            this.btnVoegLeerlingToe = new System.Windows.Forms.Button();
            this.lblKlasLeerling = new System.Windows.Forms.Label();
            this.cbKlasLeerling = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.rbVrouw = new System.Windows.Forms.RadioButton();
            this.tbLeerlingNaam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbKlas = new System.Windows.Forms.ComboBox();
            this.lbLeerlingen = new System.Windows.Forms.ListBox();
            this.btnMaakKlas = new System.Windows.Forms.Button();
            this.btnMaakLeerling = new System.Windows.Forms.Button();
            this.gbMaakKlas.SuspendLayout();
            this.gbMaakLeerling.SuspendLayout();
            this.gbGeslacht.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMaakKlas
            // 
            this.gbMaakKlas.Controls.Add(this.btnKlasAnnuleren);
            this.gbMaakKlas.Controls.Add(this.btnKlasToevoegen);
            this.gbMaakKlas.Controls.Add(this.tbKlasJaar);
            this.gbMaakKlas.Controls.Add(this.tbKlasNaam);
            this.gbMaakKlas.Controls.Add(this.label2);
            this.gbMaakKlas.Controls.Add(this.label1);
            this.gbMaakKlas.Location = new System.Drawing.Point(18, 37);
            this.gbMaakKlas.Name = "gbMaakKlas";
            this.gbMaakKlas.Size = new System.Drawing.Size(200, 147);
            this.gbMaakKlas.TabIndex = 1;
            this.gbMaakKlas.TabStop = false;
            this.gbMaakKlas.Text = "Klas Aanmaken";
            // 
            // btnKlasAnnuleren
            // 
            this.btnKlasAnnuleren.Location = new System.Drawing.Point(108, 118);
            this.btnKlasAnnuleren.Name = "btnKlasAnnuleren";
            this.btnKlasAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.btnKlasAnnuleren.TabIndex = 13;
            this.btnKlasAnnuleren.Text = "Annuleren";
            this.btnKlasAnnuleren.UseVisualStyleBackColor = true;
            this.btnKlasAnnuleren.Click += new System.EventHandler(this.btnKlasAnnuleren_Click);
            // 
            // btnKlasToevoegen
            // 
            this.btnKlasToevoegen.Location = new System.Drawing.Point(6, 118);
            this.btnKlasToevoegen.Name = "btnKlasToevoegen";
            this.btnKlasToevoegen.Size = new System.Drawing.Size(79, 23);
            this.btnKlasToevoegen.TabIndex = 13;
            this.btnKlasToevoegen.Text = "Voeg Toe";
            this.btnKlasToevoegen.UseVisualStyleBackColor = true;
            this.btnKlasToevoegen.Click += new System.EventHandler(this.btnKlasToevoegen_Click);
            // 
            // tbKlasJaar
            // 
            this.tbKlasJaar.Location = new System.Drawing.Point(39, 57);
            this.tbKlasJaar.Name = "tbKlasJaar";
            this.tbKlasJaar.Size = new System.Drawing.Size(144, 20);
            this.tbKlasJaar.TabIndex = 5;
            // 
            // tbKlasNaam
            // 
            this.tbKlasNaam.Location = new System.Drawing.Point(39, 31);
            this.tbKlasNaam.Name = "tbKlasNaam";
            this.tbKlasNaam.Size = new System.Drawing.Size(144, 20);
            this.tbKlasNaam.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jaar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klas";
            // 
            // gbMaakLeerling
            // 
            this.gbMaakLeerling.Controls.Add(this.btnLeerlingAnnuleren);
            this.gbMaakLeerling.Controls.Add(this.btnVoegLeerlingToe);
            this.gbMaakLeerling.Controls.Add(this.lblKlasLeerling);
            this.gbMaakLeerling.Controls.Add(this.cbKlasLeerling);
            this.gbMaakLeerling.Controls.Add(this.dateTimePicker1);
            this.gbMaakLeerling.Controls.Add(this.gbGeslacht);
            this.gbMaakLeerling.Controls.Add(this.tbLeerlingNaam);
            this.gbMaakLeerling.Controls.Add(this.label5);
            this.gbMaakLeerling.Controls.Add(this.label4);
            this.gbMaakLeerling.Controls.Add(this.label3);
            this.gbMaakLeerling.Location = new System.Drawing.Point(218, 37);
            this.gbMaakLeerling.Name = "gbMaakLeerling";
            this.gbMaakLeerling.Size = new System.Drawing.Size(217, 210);
            this.gbMaakLeerling.TabIndex = 0;
            this.gbMaakLeerling.TabStop = false;
            this.gbMaakLeerling.Text = "Leerling Aanmaken";
            // 
            // btnLeerlingAnnuleren
            // 
            this.btnLeerlingAnnuleren.Location = new System.Drawing.Point(128, 180);
            this.btnLeerlingAnnuleren.Name = "btnLeerlingAnnuleren";
            this.btnLeerlingAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.btnLeerlingAnnuleren.TabIndex = 4;
            this.btnLeerlingAnnuleren.Text = "Annuleren";
            this.btnLeerlingAnnuleren.UseVisualStyleBackColor = true;
            this.btnLeerlingAnnuleren.Click += new System.EventHandler(this.btnLeerlingAnnuleren_Click);
            // 
            // btnVoegLeerlingToe
            // 
            this.btnVoegLeerlingToe.Location = new System.Drawing.Point(18, 180);
            this.btnVoegLeerlingToe.Name = "btnVoegLeerlingToe";
            this.btnVoegLeerlingToe.Size = new System.Drawing.Size(79, 23);
            this.btnVoegLeerlingToe.TabIndex = 12;
            this.btnVoegLeerlingToe.Text = "Voeg Toe";
            this.btnVoegLeerlingToe.UseVisualStyleBackColor = true;
            this.btnVoegLeerlingToe.Click += new System.EventHandler(this.btnVoegLeerlingToe_Click);
            // 
            // lblKlasLeerling
            // 
            this.lblKlasLeerling.AutoSize = true;
            this.lblKlasLeerling.Location = new System.Drawing.Point(6, 156);
            this.lblKlasLeerling.Name = "lblKlasLeerling";
            this.lblKlasLeerling.Size = new System.Drawing.Size(27, 13);
            this.lblKlasLeerling.TabIndex = 11;
            this.lblKlasLeerling.Text = "Klas";
            // 
            // cbKlasLeerling
            // 
            this.cbKlasLeerling.FormattingEnabled = true;
            this.cbKlasLeerling.Location = new System.Drawing.Point(61, 153);
            this.cbKlasLeerling.Name = "cbKlasLeerling";
            this.cbKlasLeerling.Size = new System.Drawing.Size(148, 21);
            this.cbKlasLeerling.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbGeslacht.Controls.Add(this.rbMan);
            this.gbGeslacht.Controls.Add(this.rbVrouw);
            this.gbGeslacht.Location = new System.Drawing.Point(61, 57);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(129, 41);
            this.gbGeslacht.TabIndex = 8;
            this.gbGeslacht.TabStop = false;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbMan.Location = new System.Drawing.Point(67, 19);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(46, 17);
            this.rbMan.TabIndex = 7;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Man";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // rbVrouw
            // 
            this.rbVrouw.AutoSize = true;
            this.rbVrouw.Location = new System.Drawing.Point(6, 19);
            this.rbVrouw.Name = "rbVrouw";
            this.rbVrouw.Size = new System.Drawing.Size(55, 17);
            this.rbVrouw.TabIndex = 6;
            this.rbVrouw.TabStop = true;
            this.rbVrouw.Text = "Vrouw";
            this.rbVrouw.UseVisualStyleBackColor = true;
            // 
            // tbLeerlingNaam
            // 
            this.tbLeerlingNaam.Location = new System.Drawing.Point(61, 28);
            this.tbLeerlingNaam.Name = "tbLeerlingNaam";
            this.tbLeerlingNaam.Size = new System.Drawing.Size(150, 20);
            this.tbLeerlingNaam.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "GeboorteDatum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Geslacht";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Naam";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbKlas);
            this.groupBox3.Controls.Add(this.lbLeerlingen);
            this.groupBox3.Location = new System.Drawing.Point(18, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bekijk klassen";
            // 
            // cbKlas
            // 
            this.cbKlas.FormattingEnabled = true;
            this.cbKlas.Location = new System.Drawing.Point(6, 19);
            this.cbKlas.Name = "cbKlas";
            this.cbKlas.Size = new System.Drawing.Size(403, 21);
            this.cbKlas.TabIndex = 1;
            this.cbKlas.SelectedIndexChanged += new System.EventHandler(this.cbKlas_SelectedIndexChanged);
            // 
            // lbLeerlingen
            // 
            this.lbLeerlingen.FormattingEnabled = true;
            this.lbLeerlingen.Location = new System.Drawing.Point(6, 46);
            this.lbLeerlingen.Name = "lbLeerlingen";
            this.lbLeerlingen.Size = new System.Drawing.Size(403, 95);
            this.lbLeerlingen.TabIndex = 0;
            this.lbLeerlingen.SelectedIndexChanged += new System.EventHandler(this.lbLeerlingen_SelectedIndexChanged);
            // 
            // btnMaakKlas
            // 
            this.btnMaakKlas.Location = new System.Drawing.Point(18, 12);
            this.btnMaakKlas.Name = "btnMaakKlas";
            this.btnMaakKlas.Size = new System.Drawing.Size(200, 23);
            this.btnMaakKlas.TabIndex = 2;
            this.btnMaakKlas.Text = "Maak Klas";
            this.btnMaakKlas.UseVisualStyleBackColor = true;
            this.btnMaakKlas.Click += new System.EventHandler(this.btnMaakKlas_Click);
            // 
            // btnMaakLeerling
            // 
            this.btnMaakLeerling.Location = new System.Drawing.Point(218, 12);
            this.btnMaakLeerling.Name = "btnMaakLeerling";
            this.btnMaakLeerling.Size = new System.Drawing.Size(217, 23);
            this.btnMaakLeerling.TabIndex = 3;
            this.btnMaakLeerling.Text = "Maak Leerling";
            this.btnMaakLeerling.UseVisualStyleBackColor = true;
            this.btnMaakLeerling.Click += new System.EventHandler(this.btnMaakLeerling_Click);
            // 
            // Oefening5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 450);
            this.Controls.Add(this.btnMaakLeerling);
            this.Controls.Add(this.btnMaakKlas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbMaakLeerling);
            this.Controls.Add(this.gbMaakKlas);
            this.Name = "Oefening5";
            this.Text = "Oefening5";
            this.Load += new System.EventHandler(this.Oefening5_Load);
            this.gbMaakKlas.ResumeLayout(false);
            this.gbMaakKlas.PerformLayout();
            this.gbMaakLeerling.ResumeLayout(false);
            this.gbMaakLeerling.PerformLayout();
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMaakKlas;
        private System.Windows.Forms.GroupBox gbMaakLeerling;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbKlas;
        private System.Windows.Forms.ListBox lbLeerlingen;
        private System.Windows.Forms.Button btnMaakKlas;
        private System.Windows.Forms.Button btnMaakLeerling;
        private System.Windows.Forms.TextBox tbKlasJaar;
        private System.Windows.Forms.TextBox tbKlasNaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.RadioButton rbVrouw;
        private System.Windows.Forms.TextBox tbLeerlingNaam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbGeslacht;
        private System.Windows.Forms.Button btnKlasAnnuleren;
        private System.Windows.Forms.Button btnKlasToevoegen;
        private System.Windows.Forms.Button btnLeerlingAnnuleren;
        private System.Windows.Forms.Button btnVoegLeerlingToe;
        private System.Windows.Forms.Label lblKlasLeerling;
        private System.Windows.Forms.ComboBox cbKlasLeerling;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}