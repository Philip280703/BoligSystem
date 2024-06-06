namespace BoligSystem.Forms
{
    partial class NewMaeglerform
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
            groupBox2 = new GroupBox();
            comboBoxAfdeling = new ComboBox();
            lbl_Afdeling = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxEmail = new TextBox();
            textBoxTlf = new TextBox();
            label2 = new Label();
            textBoxFornavn = new TextBox();
            label3 = new Label();
            textBoxEfternavn = new TextBox();
            buttonBack = new Button();
            buttonVidere = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxAfdeling);
            groupBox2.Controls.Add(lbl_Afdeling);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(textBoxTlf);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxFornavn);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxEfternavn);
            groupBox2.Location = new Point(119, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(298, 248);
            groupBox2.TabIndex = 62;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ny Ejendomsmægler";
            // 
            // comboBoxAfdeling
            // 
            comboBoxAfdeling.FormattingEnabled = true;
            comboBoxAfdeling.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxAfdeling.Location = new Point(90, 189);
            comboBoxAfdeling.Name = "comboBoxAfdeling";
            comboBoxAfdeling.Size = new Size(170, 28);
            comboBoxAfdeling.TabIndex = 72;
            // 
            // lbl_Afdeling
            // 
            lbl_Afdeling.AutoSize = true;
            lbl_Afdeling.Location = new Point(20, 192);
            lbl_Afdeling.Name = "lbl_Afdeling";
            lbl_Afdeling.Size = new Size(66, 20);
            lbl_Afdeling.TabIndex = 71;
            lbl_Afdeling.Text = "Afdeling";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 115);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 67;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 154);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 68;
            label5.Text = "Tlf.";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(90, 112);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(170, 27);
            textBoxEmail.TabIndex = 69;
            // 
            // textBoxTlf
            // 
            textBoxTlf.Location = new Point(90, 151);
            textBoxTlf.Margin = new Padding(3, 4, 3, 4);
            textBoxTlf.Name = "textBoxTlf";
            textBoxTlf.Size = new Size(170, 27);
            textBoxTlf.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 38);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 63;
            label2.Text = "Fornavn";
            // 
            // textBoxFornavn
            // 
            textBoxFornavn.Location = new Point(90, 35);
            textBoxFornavn.Margin = new Padding(3, 4, 3, 4);
            textBoxFornavn.Name = "textBoxFornavn";
            textBoxFornavn.Size = new Size(170, 27);
            textBoxFornavn.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 77);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 64;
            label3.Text = "Efternavn";
            // 
            // textBoxEfternavn
            // 
            textBoxEfternavn.Location = new Point(90, 74);
            textBoxEfternavn.Margin = new Padding(3, 4, 3, 4);
            textBoxEfternavn.Name = "textBoxEfternavn";
            textBoxEfternavn.Size = new Size(170, 27);
            textBoxEfternavn.TabIndex = 66;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 348);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 37);
            buttonBack.TabIndex = 63;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonVidere
            // 
            buttonVidere.BackColor = SystemColors.ControlLight;
            buttonVidere.Location = new Point(218, 304);
            buttonVidere.Name = "buttonVidere";
            buttonVidere.Size = new Size(161, 67);
            buttonVidere.TabIndex = 64;
            buttonVidere.Text = "Videre";
            buttonVidere.UseVisualStyleBackColor = false;
            buttonVidere.Click += buttonVidere_Click;
            // 
            // NewMaeglerform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 397);
            Controls.Add(buttonVidere);
            Controls.Add(buttonBack);
            Controls.Add(groupBox2);
            Name = "NewMaeglerform";
            Text = "NewMaeglerform";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private TextBox textBoxEmail;
        private TextBox textBoxTlf;
        private Label label2;
        private TextBox textBoxFornavn;
        private Label label3;
        private TextBox textBoxEfternavn;
        private ComboBox comboBoxAfdeling;
        private Label lbl_Afdeling;
        private Button buttonBack;
        private Button buttonVidere;
    }
}