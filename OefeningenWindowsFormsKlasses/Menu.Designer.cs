namespace OefeningenWindowsFormsKlasses
{
    partial class Menu
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
            this.brnOef1 = new System.Windows.Forms.Button();
            this.btnOef2 = new System.Windows.Forms.Button();
            this.btnOef3 = new System.Windows.Forms.Button();
            this.btnOef4 = new System.Windows.Forms.Button();
            this.brnOef5 = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brnOef1
            // 
            this.brnOef1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brnOef1.Location = new System.Drawing.Point(12, 12);
            this.brnOef1.Name = "brnOef1";
            this.brnOef1.Size = new System.Drawing.Size(135, 23);
            this.brnOef1.TabIndex = 0;
            this.brnOef1.Text = "Oefening 1";
            this.brnOef1.UseVisualStyleBackColor = true;
            this.brnOef1.Click += new System.EventHandler(this.brnOef1_Click);
            // 
            // btnOef2
            // 
            this.btnOef2.Location = new System.Drawing.Point(12, 41);
            this.btnOef2.Name = "btnOef2";
            this.btnOef2.Size = new System.Drawing.Size(135, 23);
            this.btnOef2.TabIndex = 1;
            this.btnOef2.Text = "Oefening 2";
            this.btnOef2.UseVisualStyleBackColor = true;
            this.btnOef2.Click += new System.EventHandler(this.btnOef2_Click);
            // 
            // btnOef3
            // 
            this.btnOef3.Location = new System.Drawing.Point(12, 70);
            this.btnOef3.Name = "btnOef3";
            this.btnOef3.Size = new System.Drawing.Size(135, 23);
            this.btnOef3.TabIndex = 2;
            this.btnOef3.Text = "Oefening 3";
            this.btnOef3.UseVisualStyleBackColor = true;
            this.btnOef3.Click += new System.EventHandler(this.btnOef3_Click);
            // 
            // btnOef4
            // 
            this.btnOef4.Location = new System.Drawing.Point(12, 99);
            this.btnOef4.Name = "btnOef4";
            this.btnOef4.Size = new System.Drawing.Size(135, 23);
            this.btnOef4.TabIndex = 3;
            this.btnOef4.Text = "Oefening 4";
            this.btnOef4.UseVisualStyleBackColor = true;
            this.btnOef4.Click += new System.EventHandler(this.btnOef4_Click);
            // 
            // brnOef5
            // 
            this.brnOef5.Location = new System.Drawing.Point(12, 128);
            this.brnOef5.Name = "brnOef5";
            this.brnOef5.Size = new System.Drawing.Size(135, 23);
            this.brnOef5.TabIndex = 4;
            this.brnOef5.Text = "Oefening 5";
            this.brnOef5.UseVisualStyleBackColor = true;
            this.brnOef5.Click += new System.EventHandler(this.brnOef5_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 180);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(135, 23);
            this.btnQuit.TabIndex = 5;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 218);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.brnOef5);
            this.Controls.Add(this.btnOef4);
            this.Controls.Add(this.btnOef3);
            this.Controls.Add(this.btnOef2);
            this.Controls.Add(this.brnOef1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button brnOef1;
        private System.Windows.Forms.Button btnOef2;
        private System.Windows.Forms.Button btnOef3;
        private System.Windows.Forms.Button btnOef4;
        private System.Windows.Forms.Button brnOef5;
        private System.Windows.Forms.Button btnQuit;
    }
}

