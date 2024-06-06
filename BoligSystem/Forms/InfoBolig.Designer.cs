namespace SemesterProjekt.Forms
{
    partial class InfoBolig
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
            panel1 = new Panel();
            Btn_OpretBolig = new Button();
            Btn_OpdaterUdbudspris = new Button();
            Btn_SaelgBolig = new Button();
            Txtbox_SaelgerEmail = new TextBox();
            Lbl_SaeglerEmail = new Label();
            Txtbox_SælgerTlfnr = new TextBox();
            Lbl_SaeglerTlfnr = new Label();
            Txtbox_SaelgerNavn = new TextBox();
            Lbl_SaeglerNavn = new Label();
            Lbl_Saelger = new Label();
            Txtbox_MaeglerEmail = new TextBox();
            Lbl_MeaglerEmail = new Label();
            Txtbox_MaeglerTlf = new TextBox();
            Lbl_TlfNr = new Label();
            textbox_MaeglerNavn = new TextBox();
            Lbl_MaeglerNavn = new Label();
            Lbl_Maegler = new Label();
            ScreenPnl = new Panel();
            checkBoxSolgt = new CheckBox();
            comboxSortering = new ComboBox();
            buttonExportThisPostNr = new Button();
            btn_ExportToCSV = new Button();
            lblGnsKvm = new Label();
            textBoxGns = new TextBox();
            Btn_SletBolig = new Button();
            Aktiv_checkbox = new CheckBox();
            Refreshbutton = new Button();
            comboBoxPris = new ComboBox();
            comboBoxPostNr = new ComboBox();
            ComboBoxBoligtype = new ComboBox();
            txtSearchbar = new TextBox();
            DGVBolig = new DataGridView();
            panel1.SuspendLayout();
            ScreenPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVBolig).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Btn_OpretBolig);
            panel1.Controls.Add(Btn_OpdaterUdbudspris);
            panel1.Controls.Add(Btn_SaelgBolig);
            panel1.Controls.Add(Txtbox_SaelgerEmail);
            panel1.Controls.Add(Lbl_SaeglerEmail);
            panel1.Controls.Add(Txtbox_SælgerTlfnr);
            panel1.Controls.Add(Lbl_SaeglerTlfnr);
            panel1.Controls.Add(Txtbox_SaelgerNavn);
            panel1.Controls.Add(Lbl_SaeglerNavn);
            panel1.Controls.Add(Lbl_Saelger);
            panel1.Controls.Add(Txtbox_MaeglerEmail);
            panel1.Controls.Add(Lbl_MeaglerEmail);
            panel1.Controls.Add(Txtbox_MaeglerTlf);
            panel1.Controls.Add(Lbl_TlfNr);
            panel1.Controls.Add(textbox_MaeglerNavn);
            panel1.Controls.Add(Lbl_MaeglerNavn);
            panel1.Controls.Add(Lbl_Maegler);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(950, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 658);
            panel1.TabIndex = 1;
            // 
            // Btn_OpretBolig
            // 
            Btn_OpretBolig.BackColor = SystemColors.ControlDark;
            Btn_OpretBolig.Dock = DockStyle.Bottom;
            Btn_OpretBolig.FlatAppearance.BorderSize = 2;
            Btn_OpretBolig.FlatStyle = FlatStyle.Flat;
            Btn_OpretBolig.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Btn_OpretBolig.ForeColor = Color.White;
            Btn_OpretBolig.Location = new Point(0, 430);
            Btn_OpretBolig.Margin = new Padding(3, 5, 3, 5);
            Btn_OpretBolig.Name = "Btn_OpretBolig";
            Btn_OpretBolig.Size = new Size(318, 76);
            Btn_OpretBolig.TabIndex = 16;
            Btn_OpretBolig.Text = "Opret Bolig";
            Btn_OpretBolig.UseVisualStyleBackColor = false;
            Btn_OpretBolig.Click += buttonNyBolig_Click;
            // 
            // Btn_OpdaterUdbudspris
            // 
            Btn_OpdaterUdbudspris.BackColor = SystemColors.ControlDark;
            Btn_OpdaterUdbudspris.Dock = DockStyle.Bottom;
            Btn_OpdaterUdbudspris.FlatAppearance.BorderSize = 2;
            Btn_OpdaterUdbudspris.FlatStyle = FlatStyle.Flat;
            Btn_OpdaterUdbudspris.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Btn_OpdaterUdbudspris.ForeColor = Color.White;
            Btn_OpdaterUdbudspris.Location = new Point(0, 506);
            Btn_OpdaterUdbudspris.Margin = new Padding(3, 5, 3, 5);
            Btn_OpdaterUdbudspris.Name = "Btn_OpdaterUdbudspris";
            Btn_OpdaterUdbudspris.Size = new Size(318, 76);
            Btn_OpdaterUdbudspris.TabIndex = 15;
            Btn_OpdaterUdbudspris.Text = "Opdater Udbudspris";
            Btn_OpdaterUdbudspris.UseVisualStyleBackColor = false;
            Btn_OpdaterUdbudspris.Click += buttonOpdaterBolig_Click;
            // 
            // Btn_SaelgBolig
            // 
            Btn_SaelgBolig.BackColor = SystemColors.ControlDark;
            Btn_SaelgBolig.Dock = DockStyle.Bottom;
            Btn_SaelgBolig.FlatAppearance.BorderSize = 2;
            Btn_SaelgBolig.FlatStyle = FlatStyle.Flat;
            Btn_SaelgBolig.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Btn_SaelgBolig.ForeColor = Color.White;
            Btn_SaelgBolig.Location = new Point(0, 582);
            Btn_SaelgBolig.Margin = new Padding(3, 4, 3, 4);
            Btn_SaelgBolig.Name = "Btn_SaelgBolig";
            Btn_SaelgBolig.Size = new Size(318, 76);
            Btn_SaelgBolig.TabIndex = 14;
            Btn_SaelgBolig.Text = "Sælg Bolig";
            Btn_SaelgBolig.UseVisualStyleBackColor = false;
            Btn_SaelgBolig.Click += buttonSaelgBolig_Click;
            // 
            // Txtbox_SaelgerEmail
            // 
            Txtbox_SaelgerEmail.Anchor = AnchorStyles.Top;
            Txtbox_SaelgerEmail.Location = new Point(9, 515);
            Txtbox_SaelgerEmail.Margin = new Padding(3, 4, 3, 4);
            Txtbox_SaelgerEmail.Name = "Txtbox_SaelgerEmail";
            Txtbox_SaelgerEmail.ReadOnly = true;
            Txtbox_SaelgerEmail.Size = new Size(297, 27);
            Txtbox_SaelgerEmail.TabIndex = 13;
            // 
            // Lbl_SaeglerEmail
            // 
            Lbl_SaeglerEmail.Anchor = AnchorStyles.Top;
            Lbl_SaeglerEmail.AutoSize = true;
            Lbl_SaeglerEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_SaeglerEmail.ForeColor = Color.White;
            Lbl_SaeglerEmail.Location = new Point(9, 486);
            Lbl_SaeglerEmail.Name = "Lbl_SaeglerEmail";
            Lbl_SaeglerEmail.Size = new Size(54, 23);
            Lbl_SaeglerEmail.TabIndex = 12;
            Lbl_SaeglerEmail.Text = "Email";
            // 
            // Txtbox_SælgerTlfnr
            // 
            Txtbox_SælgerTlfnr.Anchor = AnchorStyles.Top;
            Txtbox_SælgerTlfnr.Location = new Point(9, 451);
            Txtbox_SælgerTlfnr.Margin = new Padding(3, 4, 3, 4);
            Txtbox_SælgerTlfnr.Name = "Txtbox_SælgerTlfnr";
            Txtbox_SælgerTlfnr.ReadOnly = true;
            Txtbox_SælgerTlfnr.Size = new Size(297, 27);
            Txtbox_SælgerTlfnr.TabIndex = 11;
            // 
            // Lbl_SaeglerTlfnr
            // 
            Lbl_SaeglerTlfnr.Anchor = AnchorStyles.Top;
            Lbl_SaeglerTlfnr.AutoSize = true;
            Lbl_SaeglerTlfnr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_SaeglerTlfnr.ForeColor = Color.White;
            Lbl_SaeglerTlfnr.Location = new Point(9, 422);
            Lbl_SaeglerTlfnr.Name = "Lbl_SaeglerTlfnr";
            Lbl_SaeglerTlfnr.Size = new Size(57, 23);
            Lbl_SaeglerTlfnr.TabIndex = 10;
            Lbl_SaeglerTlfnr.Text = "Tlf Nr";
            // 
            // Txtbox_SaelgerNavn
            // 
            Txtbox_SaelgerNavn.Anchor = AnchorStyles.Top;
            Txtbox_SaelgerNavn.Location = new Point(9, 387);
            Txtbox_SaelgerNavn.Margin = new Padding(3, 4, 3, 4);
            Txtbox_SaelgerNavn.Name = "Txtbox_SaelgerNavn";
            Txtbox_SaelgerNavn.ReadOnly = true;
            Txtbox_SaelgerNavn.Size = new Size(297, 27);
            Txtbox_SaelgerNavn.TabIndex = 9;
            // 
            // Lbl_SaeglerNavn
            // 
            Lbl_SaeglerNavn.Anchor = AnchorStyles.Top;
            Lbl_SaeglerNavn.AutoSize = true;
            Lbl_SaeglerNavn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_SaeglerNavn.ForeColor = Color.White;
            Lbl_SaeglerNavn.Location = new Point(9, 358);
            Lbl_SaeglerNavn.Name = "Lbl_SaeglerNavn";
            Lbl_SaeglerNavn.Size = new Size(51, 23);
            Lbl_SaeglerNavn.TabIndex = 8;
            Lbl_SaeglerNavn.Text = "Navn";
            // 
            // Lbl_Saelger
            // 
            Lbl_Saelger.Anchor = AnchorStyles.Top;
            Lbl_Saelger.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Lbl_Saelger.ForeColor = Color.White;
            Lbl_Saelger.Location = new Point(0, 303);
            Lbl_Saelger.Name = "Lbl_Saelger";
            Lbl_Saelger.Size = new Size(318, 89);
            Lbl_Saelger.TabIndex = 7;
            Lbl_Saelger.Text = "Sælger";
            Lbl_Saelger.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txtbox_MaeglerEmail
            // 
            Txtbox_MaeglerEmail.Anchor = AnchorStyles.Top;
            Txtbox_MaeglerEmail.Location = new Point(9, 255);
            Txtbox_MaeglerEmail.Margin = new Padding(3, 4, 3, 4);
            Txtbox_MaeglerEmail.Name = "Txtbox_MaeglerEmail";
            Txtbox_MaeglerEmail.ReadOnly = true;
            Txtbox_MaeglerEmail.Size = new Size(297, 27);
            Txtbox_MaeglerEmail.TabIndex = 6;
            // 
            // Lbl_MeaglerEmail
            // 
            Lbl_MeaglerEmail.Anchor = AnchorStyles.Top;
            Lbl_MeaglerEmail.AutoSize = true;
            Lbl_MeaglerEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_MeaglerEmail.ForeColor = Color.White;
            Lbl_MeaglerEmail.Location = new Point(9, 225);
            Lbl_MeaglerEmail.Name = "Lbl_MeaglerEmail";
            Lbl_MeaglerEmail.Size = new Size(54, 23);
            Lbl_MeaglerEmail.TabIndex = 5;
            Lbl_MeaglerEmail.Text = "Email";
            // 
            // Txtbox_MaeglerTlf
            // 
            Txtbox_MaeglerTlf.Anchor = AnchorStyles.Top;
            Txtbox_MaeglerTlf.Location = new Point(9, 191);
            Txtbox_MaeglerTlf.Margin = new Padding(3, 4, 3, 4);
            Txtbox_MaeglerTlf.Name = "Txtbox_MaeglerTlf";
            Txtbox_MaeglerTlf.ReadOnly = true;
            Txtbox_MaeglerTlf.Size = new Size(297, 27);
            Txtbox_MaeglerTlf.TabIndex = 4;
            // 
            // Lbl_TlfNr
            // 
            Lbl_TlfNr.Anchor = AnchorStyles.Top;
            Lbl_TlfNr.AutoSize = true;
            Lbl_TlfNr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_TlfNr.ForeColor = Color.White;
            Lbl_TlfNr.Location = new Point(9, 161);
            Lbl_TlfNr.Name = "Lbl_TlfNr";
            Lbl_TlfNr.Size = new Size(57, 23);
            Lbl_TlfNr.TabIndex = 3;
            Lbl_TlfNr.Text = "Tlf Nr";
            // 
            // textbox_MaeglerNavn
            // 
            textbox_MaeglerNavn.Anchor = AnchorStyles.Top;
            textbox_MaeglerNavn.Location = new Point(9, 127);
            textbox_MaeglerNavn.Margin = new Padding(3, 4, 3, 4);
            textbox_MaeglerNavn.Name = "textbox_MaeglerNavn";
            textbox_MaeglerNavn.ReadOnly = true;
            textbox_MaeglerNavn.Size = new Size(297, 27);
            textbox_MaeglerNavn.TabIndex = 2;
            // 
            // Lbl_MaeglerNavn
            // 
            Lbl_MaeglerNavn.Anchor = AnchorStyles.Top;
            Lbl_MaeglerNavn.AutoSize = true;
            Lbl_MaeglerNavn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_MaeglerNavn.ForeColor = Color.White;
            Lbl_MaeglerNavn.Location = new Point(9, 97);
            Lbl_MaeglerNavn.Name = "Lbl_MaeglerNavn";
            Lbl_MaeglerNavn.Size = new Size(51, 23);
            Lbl_MaeglerNavn.TabIndex = 1;
            Lbl_MaeglerNavn.Text = "Navn";
            // 
            // Lbl_Maegler
            // 
            Lbl_Maegler.Anchor = AnchorStyles.Top;
            Lbl_Maegler.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Lbl_Maegler.ForeColor = Color.White;
            Lbl_Maegler.Location = new Point(2, 42);
            Lbl_Maegler.Name = "Lbl_Maegler";
            Lbl_Maegler.Size = new Size(318, 89);
            Lbl_Maegler.TabIndex = 0;
            Lbl_Maegler.Text = "Mægler";
            Lbl_Maegler.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ScreenPnl
            // 
            ScreenPnl.Controls.Add(checkBoxSolgt);
            ScreenPnl.Controls.Add(comboxSortering);
            ScreenPnl.Controls.Add(buttonExportThisPostNr);
            ScreenPnl.Controls.Add(btn_ExportToCSV);
            ScreenPnl.Controls.Add(lblGnsKvm);
            ScreenPnl.Controls.Add(textBoxGns);
            ScreenPnl.Controls.Add(Btn_SletBolig);
            ScreenPnl.Controls.Add(Aktiv_checkbox);
            ScreenPnl.Controls.Add(Refreshbutton);
            ScreenPnl.Controls.Add(comboBoxPris);
            ScreenPnl.Controls.Add(comboBoxPostNr);
            ScreenPnl.Controls.Add(ComboBoxBoligtype);
            ScreenPnl.Controls.Add(txtSearchbar);
            ScreenPnl.Controls.Add(DGVBolig);
            ScreenPnl.Dock = DockStyle.Fill;
            ScreenPnl.Location = new Point(0, 0);
            ScreenPnl.Margin = new Padding(3, 4, 3, 4);
            ScreenPnl.Name = "ScreenPnl";
            ScreenPnl.Size = new Size(950, 658);
            ScreenPnl.TabIndex = 2;
            // 
            // checkBoxSolgt
            // 
            checkBoxSolgt.AutoSize = true;
            checkBoxSolgt.Location = new Point(744, 19);
            checkBoxSolgt.Name = "checkBoxSolgt";
            checkBoxSolgt.Size = new Size(66, 24);
            checkBoxSolgt.TabIndex = 23;
            checkBoxSolgt.Text = "Solgt";
            checkBoxSolgt.UseVisualStyleBackColor = true;
            checkBoxSolgt.CheckedChanged += checkBoxSolgt_CheckedChanged;
            // 
            // comboxSortering
            // 
            comboxSortering.FormattingEnabled = true;
            comboxSortering.Items.AddRange(new object[] { "Sortering", "Adresse (alfabetisk)", "Udbudspris (lav - høj)", "Udbudspris (høj - lav)", "Kvm (lav - høj)", "Kvm (høj - lav)", "Kvadratmeterpris (lav - høj)", "Kvadratmeterpris (høj - lav)", "Salgspris (lav - høj)", "Salgspris (høj - lav)" });
            comboxSortering.Location = new Point(820, 15);
            comboxSortering.Margin = new Padding(3, 4, 3, 4);
            comboxSortering.Name = "comboxSortering";
            comboxSortering.Size = new Size(141, 28);
            comboxSortering.TabIndex = 22;
            comboxSortering.Text = "Sortering";
            comboxSortering.SelectedIndexChanged += comboxSortering_SelectedIndexChanged;
            // 
            // buttonExportThisPostNr
            // 
            buttonExportThisPostNr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExportThisPostNr.Location = new Point(627, 12);
            buttonExportThisPostNr.Margin = new Padding(3, 4, 3, 4);
            buttonExportThisPostNr.Name = "buttonExportThisPostNr";
            buttonExportThisPostNr.Size = new Size(122, 31);
            buttonExportThisPostNr.TabIndex = 21;
            buttonExportThisPostNr.Text = "Exp. postnr CSV";
            buttonExportThisPostNr.UseVisualStyleBackColor = true;
            buttonExportThisPostNr.Click += buttonExportThisPostnr_Click;
            // 
            // btn_ExportToCSV
            // 
            btn_ExportToCSV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ExportToCSV.Location = new Point(755, 12);
            btn_ExportToCSV.Margin = new Padding(3, 4, 3, 4);
            btn_ExportToCSV.Name = "btn_ExportToCSV";
            btn_ExportToCSV.Size = new Size(86, 31);
            btn_ExportToCSV.TabIndex = 20;
            btn_ExportToCSV.Text = "Exp. CSV";
            btn_ExportToCSV.UseVisualStyleBackColor = true;
            btn_ExportToCSV.Click += btn_ExportToCSV_Click;
            // 
            // lblGnsKvm
            // 
            lblGnsKvm.AutoSize = true;
            lblGnsKvm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGnsKvm.Location = new Point(544, 808);
            lblGnsKvm.Name = "lblGnsKvm";
            lblGnsKvm.Size = new Size(270, 31);
            lblGnsKvm.TabIndex = 19;
            lblGnsKvm.Text = "Gennemsnitlig KvmPris:";
            // 
            // textBoxGns
            // 
            textBoxGns.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxGns.Location = new Point(820, 805);
            textBoxGns.Name = "textBoxGns";
            textBoxGns.ReadOnly = true;
            textBoxGns.Size = new Size(178, 38);
            textBoxGns.TabIndex = 18;
            // 
            // Btn_SletBolig
            // 
            Btn_SletBolig.Location = new Point(14, 815);
            Btn_SletBolig.Name = "Btn_SletBolig";
            Btn_SletBolig.Size = new Size(99, 34);
            Btn_SletBolig.TabIndex = 17;
            Btn_SletBolig.Text = "Slet bolig";
            Btn_SletBolig.UseVisualStyleBackColor = true;
            Btn_SletBolig.Click += Sletbolig_button_Click;
            // 
            // Aktiv_checkbox
            // 
            Aktiv_checkbox.AutoSize = true;
            Aktiv_checkbox.Location = new Point(675, 19);
            Aktiv_checkbox.Name = "Aktiv_checkbox";
            Aktiv_checkbox.Size = new Size(64, 24);
            Aktiv_checkbox.TabIndex = 6;
            Aktiv_checkbox.Text = "Aktiv";
            Aktiv_checkbox.UseVisualStyleBackColor = true;
            Aktiv_checkbox.CheckedChanged += Aktiv_checkbox_CheckedChanged;
            // 
            // Refreshbutton
            // 
            Refreshbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Refreshbutton.Location = new Point(857, 11);
            Refreshbutton.Margin = new Padding(3, 4, 3, 4);
            Refreshbutton.Name = "Refreshbutton";
            Refreshbutton.Size = new Size(86, 31);
            Refreshbutton.TabIndex = 5;
            Refreshbutton.Text = "Refresh";
            Refreshbutton.UseVisualStyleBackColor = true;
            Refreshbutton.Click += Refreshbutton_Click;
            // 
            // comboBoxPris
            // 
            comboBoxPris.FormattingEnabled = true;
            comboBoxPris.Items.AddRange(new object[] { "Pris", "1 - 999999", "1000000 - 1999999", "2000000 - 2999999", "3000000 - 3999999", "4000000 - 4999999", "5000000 - 5999999", "6000000 - 6999999", "7000000 - 7999999", "8000000 - 8999999", "9000000 - 10000000" });
            comboBoxPris.Location = new Point(561, 15);
            comboBoxPris.Margin = new Padding(3, 4, 3, 4);
            comboBoxPris.Name = "comboBoxPris";
            comboBoxPris.Size = new Size(108, 28);
            comboBoxPris.TabIndex = 4;
            comboBoxPris.Text = "Pris";
            comboBoxPris.SelectedIndexChanged += comboBoxPris_SelectedIndexChanged;
            // 
            // comboBoxPostNr
            // 
            comboBoxPostNr.FormattingEnabled = true;
            comboBoxPostNr.Items.AddRange(new object[] { "PostNr", "1000", "2000", "3000", "4000", "5000", "6000", "7000", "7080", "7100", "7400", "8000", "9000" });
            comboBoxPostNr.Location = new Point(456, 14);
            comboBoxPostNr.Margin = new Padding(3, 4, 3, 4);
            comboBoxPostNr.Name = "comboBoxPostNr";
            comboBoxPostNr.Size = new Size(100, 28);
            comboBoxPostNr.TabIndex = 3;
            comboBoxPostNr.Text = "PostNr";
            comboBoxPostNr.SelectedIndexChanged += comboBoxPostNr_SelectedIndexChanged;
            // 
            // ComboBoxBoligtype
            // 
            ComboBoxBoligtype.FormattingEnabled = true;
            ComboBoxBoligtype.Items.AddRange(new object[] { "BoligType", "Villa", "Lejlighed", "Rækkehus", "Andelsbolig" });
            ComboBoxBoligtype.Location = new Point(334, 14);
            ComboBoxBoligtype.Margin = new Padding(3, 4, 3, 4);
            ComboBoxBoligtype.Name = "ComboBoxBoligtype";
            ComboBoxBoligtype.Size = new Size(116, 28);
            ComboBoxBoligtype.TabIndex = 2;
            ComboBoxBoligtype.Text = "BoligType";
            ComboBoxBoligtype.SelectedIndexChanged += comboBoxBoligType_SelectedIndexChanged;
            // 
            // txtSearchbar
            // 
            txtSearchbar.Location = new Point(15, 15);
            txtSearchbar.Margin = new Padding(3, 4, 3, 4);
            txtSearchbar.Name = "txtSearchbar";
            txtSearchbar.PlaceholderText = "Adresse";
            txtSearchbar.Size = new Size(305, 27);
            txtSearchbar.TabIndex = 1;
            txtSearchbar.TextChanged += txtSearchbar_TextChanged;
            // 
            // DGVBolig
            // 
            DGVBolig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVBolig.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVBolig.BackgroundColor = SystemColors.Control;
            DGVBolig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVBolig.Location = new Point(14, 55);
            DGVBolig.Margin = new Padding(3, 4, 3, 4);
            DGVBolig.Name = "DGVBolig";
            DGVBolig.ReadOnly = true;
            DGVBolig.RowHeadersWidth = 51;
            DGVBolig.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVBolig.Size = new Size(929, 516);
            DGVBolig.TabIndex = 0;
            DGVBolig.CellMouseClick += dataGridViewBolig_CellMouseClick;
            // 
            // InfoBolig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 658);
            Controls.Add(ScreenPnl);
            Controls.Add(panel1);
            Name = "InfoBolig";
            Text = "Form2";
            Load += InfoBolig_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ScreenPnl.ResumeLayout(false);
            ScreenPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVBolig).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel ScreenPnl;
        private DataGridView DGVBolig;
        private TextBox txtSearchbar;
        private ComboBox ComboBoxBoligtype;
        private ComboBox comboBoxPostNr;
        private TrackBar trackBar1;
        private ComboBox comboBoxPris;
        private Label Lbl_TlfNr;
        private TextBox textbox_MaeglerNavn;
        private Label Lbl_MaeglerNavn;
        private Label Lbl_MeaglerEmail;
        private TextBox Txtbox_MaeglerTlf;
        private Label Lbl_Saelger;
        private TextBox Txtbox_MaeglerEmail;
        private TextBox Txtbox_SaelgerEmail;
        private Label Lbl_SaeglerEmail;
        private TextBox Txtbox_SælgerTlfnr;
        private Label Lbl_SaeglerTlfnr;
        private TextBox Txtbox_SaelgerNavn;
        private Label Lbl_SaeglerNavn;
        private Label Lbl_Maegler;
        private Button Btn_SaelgBolig;
        private Button Btn_OpdaterUdbudspris;
        private Button button3;
        private Button Refreshbutton;
        private Button Btn_OpretBolig;
        private CheckBox Aktiv_checkbox;
        private Button Btn_SletBolig;
        private TextBox textBoxGns;
        private Label lblGnsKvm;
        private Button btn_ExportToCSV;
        private Button buttonExportThisPostNr;
        private ComboBox comboxSortering;
        private CheckBox checkBoxSolgt;
    }
}