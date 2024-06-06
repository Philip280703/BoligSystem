namespace BoligSystem.Forms
{
    partial class NewkundeForm
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
            label4 = new Label();
            label5 = new Label();
            textBoxEmail = new TextBox();
            textBoxTlf = new TextBox();
            label2 = new Label();
            textBoxFornavn = new TextBox();
            label3 = new Label();
            textBoxEfternavn = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonVidere
            // 
            buttonVidere.BackColor = SystemColors.ControlLight;
            buttonVidere.Location = new Point(281, 328);
            buttonVidere.Name = "buttonVidere";
            buttonVidere.Size = new Size(161, 67);
            buttonVidere.TabIndex = 67;
            buttonVidere.Text = "Opret ny kunde";
            buttonVidere.UseVisualStyleBackColor = false;
            buttonVidere.Click += buttonVidere_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(36, 358);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(75, 37);
            buttonBack.TabIndex = 66;
            buttonBack.Text = "Tilbage";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxEmail);
            groupBox2.Controls.Add(textBoxTlf);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxFornavn);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxEfternavn);
            groupBox2.Location = new Point(144, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.No;
            groupBox2.Size = new Size(298, 210);
            groupBox2.TabIndex = 65;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ny Køber";
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
            // Newkunde
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 451);
            Controls.Add(buttonVidere);
            Controls.Add(buttonBack);
            Controls.Add(groupBox2);
            Name = "Newkunde";
            Text = "Newkunde";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonVidere;
        private Button buttonBack;
        private GroupBox groupBox2;
        private Label label4;
        private Label label5;
        private TextBox textBoxEmail;
        private TextBox textBoxTlf;
        private Label label2;
        private TextBox textBoxFornavn;
        private Label label3;
        private TextBox textBoxEfternavn;
    }
}