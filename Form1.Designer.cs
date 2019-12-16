namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.OpoinPanel = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PesButton = new System.Windows.Forms.RadioButton();
            this.PersPanel = new System.Windows.Forms.Panel();
            this.endButton = new System.Windows.Forms.Button();
            this.Singlist = new System.Windows.Forms.ListBox();
            this.PersList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CataPanel = new System.Windows.Forms.Panel();
            this.CataButton = new System.Windows.Forms.Button();
            this.Catalist = new System.Windows.Forms.ListBox();
            this.Cata = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OpoinPanel.SuspendLayout();
            this.PersPanel.SuspendLayout();
            this.CataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presdient Selecter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OpoinPanel
            // 
            this.OpoinPanel.Controls.Add(this.radioButton1);
            this.OpoinPanel.Controls.Add(this.PesButton);
            this.OpoinPanel.Location = new System.Drawing.Point(12, 72);
            this.OpoinPanel.Name = "OpoinPanel";
            this.OpoinPanel.Size = new System.Drawing.Size(200, 100);
            this.OpoinPanel.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(3, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 29);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Catagory";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // PesButton
            // 
            this.PesButton.AutoSize = true;
            this.PesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesButton.Location = new System.Drawing.Point(3, 3);
            this.PesButton.Name = "PesButton";
            this.PesButton.Size = new System.Drawing.Size(169, 29);
            this.PesButton.TabIndex = 2;
            this.PesButton.TabStop = true;
            this.PesButton.Text = "Single Pesident";
            this.PesButton.UseVisualStyleBackColor = true;
            this.PesButton.CheckedChanged += new System.EventHandler(this.PesButton_CheckedChanged);
            // 
            // PersPanel
            // 
            this.PersPanel.Controls.Add(this.endButton);
            this.PersPanel.Controls.Add(this.Singlist);
            this.PersPanel.Controls.Add(this.PersList);
            this.PersPanel.Controls.Add(this.label2);
            this.PersPanel.Location = new System.Drawing.Point(15, 178);
            this.PersPanel.Name = "PersPanel";
            this.PersPanel.Size = new System.Drawing.Size(344, 365);
            this.PersPanel.TabIndex = 2;
            this.PersPanel.Visible = false;
            // 
            // endButton
            // 
            this.endButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endButton.Location = new System.Drawing.Point(77, 311);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(174, 30);
            this.endButton.TabIndex = 4;
            this.endButton.Text = "enter";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // Singlist
            // 
            this.Singlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Singlist.FormattingEnabled = true;
            this.Singlist.ItemHeight = 22;
            this.Singlist.Location = new System.Drawing.Point(33, 62);
            this.Singlist.Name = "Singlist";
            this.Singlist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Singlist.Size = new System.Drawing.Size(268, 224);
            this.Singlist.TabIndex = 6;
            // 
            // PersList
            // 
            this.PersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersList.FormattingEnabled = true;
            this.PersList.Location = new System.Drawing.Point(77, 12);
            this.PersList.Name = "PersList";
            this.PersList.Size = new System.Drawing.Size(174, 28);
            this.PersList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Single:";
            // 
            // CataPanel
            // 
            this.CataPanel.Controls.Add(this.CataButton);
            this.CataPanel.Controls.Add(this.Catalist);
            this.CataPanel.Controls.Add(this.Cata);
            this.CataPanel.Controls.Add(this.label3);
            this.CataPanel.Location = new System.Drawing.Point(378, 178);
            this.CataPanel.Name = "CataPanel";
            this.CataPanel.Size = new System.Drawing.Size(344, 365);
            this.CataPanel.TabIndex = 3;
            this.CataPanel.Visible = false;
            // 
            // CataButton
            // 
            this.CataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CataButton.Location = new System.Drawing.Point(109, 311);
            this.CataButton.Name = "CataButton";
            this.CataButton.Size = new System.Drawing.Size(174, 30);
            this.CataButton.TabIndex = 8;
            this.CataButton.Text = "enter";
            this.CataButton.UseVisualStyleBackColor = true;
            this.CataButton.Click += new System.EventHandler(this.CataButton_Click);
            // 
            // Catalist
            // 
            this.Catalist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Catalist.FormattingEnabled = true;
            this.Catalist.ItemHeight = 22;
            this.Catalist.Location = new System.Drawing.Point(41, 62);
            this.Catalist.Name = "Catalist";
            this.Catalist.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Catalist.Size = new System.Drawing.Size(268, 224);
            this.Catalist.TabIndex = 7;
            // 
            // Cata
            // 
            this.Cata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cata.FormattingEnabled = true;
            this.Cata.Location = new System.Drawing.Point(109, 14);
            this.Cata.Name = "Cata";
            this.Cata.Size = new System.Drawing.Size(174, 28);
            this.Cata.TabIndex = 6;
            this.Cata.SelectedIndexChanged += new System.EventHandler(this.Cata_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Catagory:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(727, 675);
            this.Controls.Add(this.CataPanel);
            this.Controls.Add(this.PersPanel);
            this.Controls.Add(this.OpoinPanel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.OpoinPanel.ResumeLayout(false);
            this.OpoinPanel.PerformLayout();
            this.PersPanel.ResumeLayout(false);
            this.PersPanel.PerformLayout();
            this.CataPanel.ResumeLayout(false);
            this.CataPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel OpoinPanel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton PesButton;
        private System.Windows.Forms.Panel PersPanel;
        private System.Windows.Forms.Panel CataPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PersList;
        private System.Windows.Forms.ComboBox Cata;
        private System.Windows.Forms.ListBox Singlist;
        private System.Windows.Forms.ListBox Catalist;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button CataButton;
    }
}

