namespace BoligSystem.Forms
{
    partial class AdvanceInfoBolig
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
            lbl_BoligId = new Label();
            lbl_Adresse = new Label();
            BoligIdTextBox = new TextBox();
            AdresseTextbox = new TextBox();
            PostNrTextbox = new TextBox();
            lbl_PostNr = new Label();
            UdbudsprisTextbox = new TextBox();
            lbl_Udbudspris = new Label();
            KvadratmeterTextbox = new TextBox();
            lbl_kvadratmeter = new Label();
            lbl_kvmPris = new Label();
            KvmPrisTextBox = new TextBox();
            BoligTypeTextbox = new TextBox();
            lbl_boligType = new Label();
            AktivTextbox = new TextBox();
            lbl_aktiv = new Label();
            MaglerIdTextbox = new TextBox();
            lbl_MæglerId = new Label();
            panel_Sælg_Bolig = new Panel();
            SælgBolig = new Button();
            Salgspris = new TextBox();
            lbl_SalgsPris = new Label();
            lbl_SalgsDato = new Label();
            Salgsdato = new DateTimePicker();
            lbl_Sælg_Bolig = new Label();
            TilbageButton = new Button();
            DGVKunder = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBoxKundeId = new TextBox();
            panel_Sælg_Bolig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVKunder).BeginInit();
            SuspendLayout();
            // 
            // lbl_BoligId
            // 
            lbl_BoligId.AutoSize = true;
            lbl_BoligId.Location = new Point(55, 44);
            lbl_BoligId.Name = "lbl_BoligId";
            lbl_BoligId.Size = new Size(57, 20);
            lbl_BoligId.TabIndex = 0;
            lbl_BoligId.Text = "BoligId";
            // 
            // lbl_Adresse
            // 
            lbl_Adresse.AutoSize = true;
            lbl_Adresse.Location = new Point(50, 83);
            lbl_Adresse.Name = "lbl_Adresse";
            lbl_Adresse.Size = new Size(61, 20);
            lbl_Adresse.TabIndex = 1;
            lbl_Adresse.Text = "Adresse";
            // 
            // BoligIdTextBox
            // 
            BoligIdTextBox.Location = new Point(112, 40);
            BoligIdTextBox.Margin = new Padding(3, 4, 3, 4);
            BoligIdTextBox.Name = "BoligIdTextBox";
            BoligIdTextBox.ReadOnly = true;
            BoligIdTextBox.Size = new Size(170, 27);
            BoligIdTextBox.TabIndex = 3;
            // 
            // AdresseTextbox
            // 
            AdresseTextbox.Location = new Point(112, 79);
            AdresseTextbox.Margin = new Padding(3, 4, 3, 4);
            AdresseTextbox.Name = "AdresseTextbox";
            AdresseTextbox.ReadOnly = true;
            AdresseTextbox.Size = new Size(170, 27);
            AdresseTextbox.TabIndex = 4;
            // 
            // PostNrTextbox
            // 
            PostNrTextbox.Location = new Point(112, 117);
            PostNrTextbox.Margin = new Padding(3, 4, 3, 4);
            PostNrTextbox.Name = "PostNrTextbox";
            PostNrTextbox.ReadOnly = true;
            PostNrTextbox.Size = new Size(170, 27);
            PostNrTextbox.TabIndex = 5;
            // 
            // lbl_PostNr
            // 
            lbl_PostNr.AutoSize = true;
            lbl_PostNr.Location = new Point(55, 121);
            lbl_PostNr.Name = "lbl_PostNr";
            lbl_PostNr.Size = new Size(52, 20);
            lbl_PostNr.TabIndex = 6;
            lbl_PostNr.Text = "PostNr";
            // 
            // UdbudsprisTextbox
            // 
            UdbudsprisTextbox.Location = new Point(112, 156);
            UdbudsprisTextbox.Margin = new Padding(3, 4, 3, 4);
            UdbudsprisTextbox.Name = "UdbudsprisTextbox";
            UdbudsprisTextbox.ReadOnly = true;
            UdbudsprisTextbox.Size = new Size(170, 27);
            UdbudsprisTextbox.TabIndex = 7;
            // 
            // lbl_Udbudspris
            // 
            lbl_Udbudspris.AutoSize = true;
            lbl_Udbudspris.Location = new Point(27, 160);
            lbl_Udbudspris.Name = "lbl_Udbudspris";
            lbl_Udbudspris.Size = new Size(84, 20);
            lbl_Udbudspris.TabIndex = 8;
            lbl_Udbudspris.Text = "Udbudspris";
            // 
            // KvadratmeterTextbox
            // 
            KvadratmeterTextbox.Location = new Point(112, 195);
            KvadratmeterTextbox.Margin = new Padding(3, 4, 3, 4);
            KvadratmeterTextbox.Name = "KvadratmeterTextbox";
            KvadratmeterTextbox.ReadOnly = true;
            KvadratmeterTextbox.Size = new Size(170, 27);
            KvadratmeterTextbox.TabIndex = 9;
            // 
            // lbl_kvadratmeter
            // 
            lbl_kvadratmeter.AutoSize = true;
            lbl_kvadratmeter.Location = new Point(16, 199);
            lbl_kvadratmeter.Name = "lbl_kvadratmeter";
            lbl_kvadratmeter.Size = new Size(98, 20);
            lbl_kvadratmeter.TabIndex = 10;
            lbl_kvadratmeter.Text = "Kvadratmeter";
            // 
            // lbl_kvmPris
            // 
            lbl_kvmPris.AutoSize = true;
            lbl_kvmPris.Location = new Point(48, 234);
            lbl_kvmPris.Name = "lbl_kvmPris";
            lbl_kvmPris.Size = new Size(61, 20);
            lbl_kvmPris.TabIndex = 11;
            lbl_kvmPris.Text = "Kvmpris";
            // 
            // KvmPrisTextBox
            // 
            KvmPrisTextBox.Location = new Point(112, 230);
            KvmPrisTextBox.Margin = new Padding(3, 4, 3, 4);
            KvmPrisTextBox.Name = "KvmPrisTextBox";
            KvmPrisTextBox.ReadOnly = true;
            KvmPrisTextBox.Size = new Size(170, 27);
            KvmPrisTextBox.TabIndex = 12;
            // 
            // BoligTypeTextbox
            // 
            BoligTypeTextbox.Location = new Point(112, 269);
            BoligTypeTextbox.Margin = new Padding(3, 4, 3, 4);
            BoligTypeTextbox.Name = "BoligTypeTextbox";
            BoligTypeTextbox.ReadOnly = true;
            BoligTypeTextbox.Size = new Size(170, 27);
            BoligTypeTextbox.TabIndex = 13;
            // 
            // lbl_boligType
            // 
            lbl_boligType.AutoSize = true;
            lbl_boligType.Location = new Point(39, 273);
            lbl_boligType.Name = "lbl_boligType";
            lbl_boligType.Size = new Size(75, 20);
            lbl_boligType.TabIndex = 14;
            lbl_boligType.Text = "BoligType";
            // 
            // AktivTextbox
            // 
            AktivTextbox.Location = new Point(112, 307);
            AktivTextbox.Margin = new Padding(3, 4, 3, 4);
            AktivTextbox.Name = "AktivTextbox";
            AktivTextbox.ReadOnly = true;
            AktivTextbox.Size = new Size(170, 27);
            AktivTextbox.TabIndex = 15;
            // 
            // lbl_aktiv
            // 
            lbl_aktiv.AutoSize = true;
            lbl_aktiv.Location = new Point(62, 311);
            lbl_aktiv.Name = "lbl_aktiv";
            lbl_aktiv.Size = new Size(42, 20);
            lbl_aktiv.TabIndex = 17;
            lbl_aktiv.Text = "Aktiv";
            // 
            // MaglerIdTextbox
            // 
            MaglerIdTextbox.Location = new Point(112, 346);
            MaglerIdTextbox.Margin = new Padding(3, 4, 3, 4);
            MaglerIdTextbox.Name = "MaglerIdTextbox";
            MaglerIdTextbox.ReadOnly = true;
            MaglerIdTextbox.Size = new Size(170, 27);
            MaglerIdTextbox.TabIndex = 18;
            // 
            // lbl_MæglerId
            // 
            lbl_MæglerId.AutoSize = true;
            lbl_MæglerId.Location = new Point(39, 350);
            lbl_MæglerId.Name = "lbl_MæglerId";
            lbl_MæglerId.Size = new Size(73, 20);
            lbl_MæglerId.TabIndex = 19;
            lbl_MæglerId.Text = "MæglerId";
            // 
            // panel_Sælg_Bolig
            // 
            panel_Sælg_Bolig.BackColor = Color.WhiteSmoke;
            panel_Sælg_Bolig.Controls.Add(SælgBolig);
            panel_Sælg_Bolig.Controls.Add(Salgspris);
            panel_Sælg_Bolig.Controls.Add(lbl_SalgsPris);
            panel_Sælg_Bolig.Controls.Add(lbl_SalgsDato);
            panel_Sælg_Bolig.Controls.Add(Salgsdato);
            panel_Sælg_Bolig.Controls.Add(lbl_Sælg_Bolig);
            panel_Sælg_Bolig.Location = new Point(752, 44);
            panel_Sælg_Bolig.Margin = new Padding(3, 4, 3, 4);
            panel_Sælg_Bolig.Name = "panel_Sælg_Bolig";
            panel_Sælg_Bolig.Size = new Size(412, 326);
            panel_Sælg_Bolig.TabIndex = 20;
            // 
            // SælgBolig
            // 
            SælgBolig.Dock = DockStyle.Bottom;
            SælgBolig.FlatStyle = FlatStyle.Flat;
            SælgBolig.Location = new Point(0, 281);
            SælgBolig.Margin = new Padding(3, 4, 3, 4);
            SælgBolig.Name = "SælgBolig";
            SælgBolig.Size = new Size(412, 45);
            SælgBolig.TabIndex = 5;
            SælgBolig.Text = "Sælg Bolig";
            SælgBolig.UseVisualStyleBackColor = true;
            SælgBolig.Click += SælgBolig_Click;
            // 
            // Salgspris
            // 
            Salgspris.Location = new Point(58, 187);
            Salgspris.Margin = new Padding(3, 4, 3, 4);
            Salgspris.Name = "Salgspris";
            Salgspris.Size = new Size(305, 27);
            Salgspris.TabIndex = 4;
            // 
            // lbl_SalgsPris
            // 
            lbl_SalgsPris.Location = new Point(40, 144);
            lbl_SalgsPris.Name = "lbl_SalgsPris";
            lbl_SalgsPris.Size = new Size(339, 39);
            lbl_SalgsPris.TabIndex = 3;
            lbl_SalgsPris.Text = "Salgspris";
            lbl_SalgsPris.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_SalgsDato
            // 
            lbl_SalgsDato.Location = new Point(40, 67);
            lbl_SalgsDato.Name = "lbl_SalgsDato";
            lbl_SalgsDato.Size = new Size(339, 39);
            lbl_SalgsDato.TabIndex = 2;
            lbl_SalgsDato.Text = "Salgsdato";
            lbl_SalgsDato.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Salgsdato
            // 
            Salgsdato.Location = new Point(58, 109);
            Salgsdato.Margin = new Padding(3, 4, 3, 4);
            Salgsdato.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            Salgsdato.MinDate = new DateTime(1850, 1, 1, 0, 0, 0, 0);
            Salgsdato.Name = "Salgsdato";
            Salgsdato.Size = new Size(305, 27);
            Salgsdato.TabIndex = 1;
            // 
            // lbl_Sælg_Bolig
            // 
            lbl_Sælg_Bolig.BackColor = Color.Gainsboro;
            lbl_Sælg_Bolig.Dock = DockStyle.Top;
            lbl_Sælg_Bolig.Location = new Point(0, 0);
            lbl_Sælg_Bolig.Name = "lbl_Sælg_Bolig";
            lbl_Sælg_Bolig.Size = new Size(412, 31);
            lbl_Sælg_Bolig.TabIndex = 0;
            lbl_Sælg_Bolig.Text = "Sælg Bolig";
            lbl_Sælg_Bolig.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TilbageButton
            // 
            TilbageButton.Location = new Point(12, 435);
            TilbageButton.Margin = new Padding(3, 4, 3, 4);
            TilbageButton.Name = "TilbageButton";
            TilbageButton.Size = new Size(86, 31);
            TilbageButton.TabIndex = 21;
            TilbageButton.Text = "Tilbage";
            TilbageButton.UseVisualStyleBackColor = true;
            TilbageButton.Click += btn_Tilbage_Click;
            // 
            // DGVKunder
            // 
            DGVKunder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVKunder.Location = new Point(315, 63);
            DGVKunder.Name = "DGVKunder";
            DGVKunder.ReadOnly = true;
            DGVKunder.RowHeadersWidth = 51;
            DGVKunder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVKunder.Size = new Size(404, 271);
            DGVKunder.TabIndex = 22;
            DGVKunder.CellMouseClick += DGVKunder_CellMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(425, 40);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 23;
            label1.Text = "Vælg Køber af boligen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(391, 345);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 25;
            label2.Text = "Kundens Id";
            // 
            // textBoxKundeId
            // 
            textBoxKundeId.Location = new Point(479, 341);
            textBoxKundeId.Margin = new Padding(3, 4, 3, 4);
            textBoxKundeId.Name = "textBoxKundeId";
            textBoxKundeId.ReadOnly = true;
            textBoxKundeId.Size = new Size(170, 27);
            textBoxKundeId.TabIndex = 24;
            // 
            // AdvanceInfoBolig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1232, 478);
            Controls.Add(label2);
            Controls.Add(textBoxKundeId);
            Controls.Add(label1);
            Controls.Add(DGVKunder);
            Controls.Add(TilbageButton);
            Controls.Add(panel_Sælg_Bolig);
            Controls.Add(lbl_MæglerId);
            Controls.Add(MaglerIdTextbox);
            Controls.Add(lbl_aktiv);
            Controls.Add(AktivTextbox);
            Controls.Add(lbl_boligType);
            Controls.Add(BoligTypeTextbox);
            Controls.Add(KvmPrisTextBox);
            Controls.Add(lbl_kvmPris);
            Controls.Add(lbl_kvadratmeter);
            Controls.Add(KvadratmeterTextbox);
            Controls.Add(lbl_Udbudspris);
            Controls.Add(UdbudsprisTextbox);
            Controls.Add(lbl_PostNr);
            Controls.Add(PostNrTextbox);
            Controls.Add(AdresseTextbox);
            Controls.Add(BoligIdTextBox);
            Controls.Add(lbl_Adresse);
            Controls.Add(lbl_BoligId);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdvanceInfoBolig";
            Text = "Form3";
            panel_Sælg_Bolig.ResumeLayout(false);
            panel_Sælg_Bolig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVKunder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_BoligId;
        private Label lbl_Adresse;
        private TextBox BoligIdTextBox;
        private TextBox AdresseTextbox;
        private TextBox PostNrTextbox;
        private Label lbl_PostNr;
        private TextBox UdbudsprisTextbox;
        private Label lbl_Udbudspris;
        private TextBox KvadratmeterTextbox;
        private Label lbl_kvadratmeter;
        private Label lbl_kvmPris;
        private TextBox KvmPrisTextBox;
        private TextBox BoligTypeTextbox;
        private Label lbl_boligType;
        private TextBox AktivTextbox;
        private Label lbl_aktiv;
        private TextBox MaglerIdTextbox;
        private Label lbl_MæglerId;
        private Panel panel_Sælg_Bolig;
        private Label lbl_Sælg_Bolig;
        private Button TilbageButton;
        private Label lbl_SalgsDato;
        private DateTimePicker Salgsdato;
        private Button SælgBolig;
        private TextBox Salgspris;
        private Label lbl_SalgsPris;
        private DataGridView DGVKunder;
        private Label label1;
        private Label label2;
        private TextBox textBoxKundeId;
    }
}