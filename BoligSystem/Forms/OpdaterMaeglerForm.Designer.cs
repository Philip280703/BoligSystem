namespace BoligSystem.Forms
{
    partial class OpdaterMaeglerForm
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
            buttonVidere = new Button();
            buttonBack = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            textBoxId = new TextBox();
            textBoxAfdeling = new TextBox();
            lbl_Afdeling = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxEmail = new TextBox();
            textBoxTlf = new TextBox();
            label2 = new Label();
            textBoxFornavn = new TextBox();
            label3 = new Label();
            textBoxEfternavn = new TextBox();
            comboBoxNyAfdeling = new ComboBox();
            labelNyAfdeling = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonVidere
            // 
            buttonVidere.BackColor = SystemColors.ControlLight;
            buttonVidere.Location = new Point(435, 178);
            buttonVidere.Name = "buttonVidere";
            buttonVidere.Size = new Size(161, 67);
            buttonVidere.TabIndex = 67;
            buttonVidere.Text = "Videre";
            buttonVidere.UseVisualStyleBackColor = false;
            buttonVidere.Click += buttonVidere_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(12, 293);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 37);
            buttonBack.TabIndex = 66;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBoxId);
            groupBox2.Controls.Add(textBoxAfdeling);
            groupBox2.Controls.Add(lbl_Afdeling);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(textBoxTlf);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxFornavn);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxEfternavn);
            groupBox2.Location = new Point(87, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(298, 271);
            groupBox2.TabIndex = 65;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ejendomsmægler";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 34);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 73;
            label1.Text = "ID";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(94, 31);
            textBoxId.Margin = new Padding(3, 4, 3, 4);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(170, 27);
            textBoxId.TabIndex = 74;
            // 
            // textBoxAfdeling
            // 
            textBoxAfdeling.Location = new Point(94, 217);
            textBoxAfdeling.Margin = new Padding(3, 4, 3, 4);
            textBoxAfdeling.Name = "textBoxAfdeling";
            textBoxAfdeling.ReadOnly = true;
            textBoxAfdeling.Size = new Size(170, 27);
            textBoxAfdeling.TabIndex = 72;
            // 
            // lbl_Afdeling
            // 
            lbl_Afdeling.AutoSize = true;
            lbl_Afdeling.Location = new Point(24, 223);
            lbl_Afdeling.Name = "lbl_Afdeling";
            lbl_Afdeling.Size = new Size(66, 20);
            lbl_Afdeling.TabIndex = 71;
            lbl_Afdeling.Text = "Afdeling";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 146);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 67;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 185);
            label5.Name = "label5";
            label5.Size = new Size(29, 20);
            label5.TabIndex = 68;
            label5.Text = "Tlf.";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(94, 143);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ReadOnly = true;
            textBoxEmail.Size = new Size(170, 27);
            textBoxEmail.TabIndex = 69;
            // 
            // textBoxTlf
            // 
            textBoxTlf.Location = new Point(94, 182);
            textBoxTlf.Margin = new Padding(3, 4, 3, 4);
            textBoxTlf.Name = "textBoxTlf";
            textBoxTlf.ReadOnly = true;
            textBoxTlf.Size = new Size(170, 27);
            textBoxTlf.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 69);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 63;
            label2.Text = "Fornavn";
            // 
            // textBoxFornavn
            // 
            textBoxFornavn.Location = new Point(94, 66);
            textBoxFornavn.Margin = new Padding(3, 4, 3, 4);
            textBoxFornavn.Name = "textBoxFornavn";
            textBoxFornavn.ReadOnly = true;
            textBoxFornavn.Size = new Size(170, 27);
            textBoxFornavn.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 108);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 64;
            label3.Text = "Efternavn";
            // 
            // textBoxEfternavn
            // 
            textBoxEfternavn.Location = new Point(94, 105);
            textBoxEfternavn.Margin = new Padding(3, 4, 3, 4);
            textBoxEfternavn.Name = "textBoxEfternavn";
            textBoxEfternavn.ReadOnly = true;
            textBoxEfternavn.Size = new Size(170, 27);
            textBoxEfternavn.TabIndex = 66;
            // 
            // comboBoxNyAfdeling
            // 
            comboBoxNyAfdeling.FormattingEnabled = true;
            comboBoxNyAfdeling.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxNyAfdeling.Location = new Point(426, 119);
            comboBoxNyAfdeling.Name = "comboBoxNyAfdeling";
            comboBoxNyAfdeling.Size = new Size(170, 28);
            comboBoxNyAfdeling.TabIndex = 74;
            // 
            // labelNyAfdeling
            // 
            labelNyAfdeling.AutoSize = true;
            labelNyAfdeling.Location = new Point(426, 96);
            labelNyAfdeling.Name = "labelNyAfdeling";
            labelNyAfdeling.Size = new Size(88, 20);
            labelNyAfdeling.TabIndex = 73;
            labelNyAfdeling.Text = "Ny Afdeling";
            // 
            // OpdaterMaeglerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 341);
            Controls.Add(comboBoxNyAfdeling);
            Controls.Add(labelNyAfdeling);
            Controls.Add(buttonVidere);
            Controls.Add(buttonBack);
            Controls.Add(groupBox2);
            Name = "OpdaterMaeglerForm";
            Text = "OpdaterMaeglerForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVidere;
        private Button buttonBack;
        private GroupBox groupBox2;
        private Label lbl_Afdeling;
        private Label label4;
        private Label label5;
        private TextBox textBoxEmail;
        private TextBox textBoxTlf;
        private Label label2;
        private TextBox textBoxFornavn;
        private Label label3;
        private TextBox textBoxEfternavn;
        private ComboBox comboBoxNyAfdeling;
        private Label labelNyAfdeling;
        private TextBox textBoxAfdeling;
        private Label label1;
        private TextBox textBoxId;
    }
}