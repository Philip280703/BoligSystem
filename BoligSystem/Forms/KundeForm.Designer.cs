namespace SemesterProjekt.Forms
{
    partial class KundeForm
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
            Btn_Create = new Button();
            Btn_Update = new Button();
            Btn_Delete = new Button();
            DGV_Kunde_Bolig = new DataGridView();
            TxtSearch = new TextBox();
            DGVKunde = new DataGridView();
            panel1 = new Panel();
            Txtbox_SaelgerEmail = new TextBox();
            Txtbox_MaeglerEmail = new TextBox();
            Lbl_MeaglerEmail = new Label();
            Lbl_SaeglerEmail = new Label();
            Txtbox_MaeglerTlf = new TextBox();
            Lbl_TlfNr = new Label();
            Txtbox_SælgerTlfnr = new TextBox();
            textbox_MaeglerNavn = new TextBox();
            Lbl_MaeglerNavn = new Label();
            Lbl_SaeglerTlfnr = new Label();
            Lbl_Maegler = new Label();
            Txtbox_SaelgerNavn = new TextBox();
            Lbl_SaeglerNavn = new Label();
            Lbl_Saelger = new Label();
            Btn_Refresh = new Button();
            label1 = new Label();
            checkBoxSolgteBoliger = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)DGV_Kunde_Bolig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVKunde).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Create
            // 
            Btn_Create.BackColor = SystemColors.ControlDark;
            Btn_Create.Dock = DockStyle.Bottom;
            Btn_Create.FlatAppearance.BorderSize = 2;
            Btn_Create.FlatStyle = FlatStyle.Flat;
            Btn_Create.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Btn_Create.ForeColor = Color.White;
            Btn_Create.Location = new Point(0, 663);
            Btn_Create.Margin = new Padding(3, 5, 3, 5);
            Btn_Create.Name = "Btn_Create";
            Btn_Create.Size = new Size(318, 76);
            Btn_Create.TabIndex = 16;
            Btn_Create.Text = "Opret Køber";
            Btn_Create.UseVisualStyleBackColor = false;
            Btn_Create.Click += Btn_Create_Click;
            // 
            // Btn_Update
            // 
            Btn_Update.BackColor = SystemColors.ControlDark;
            Btn_Update.Dock = DockStyle.Bottom;
            Btn_Update.FlatAppearance.BorderSize = 2;
            Btn_Update.FlatStyle = FlatStyle.Flat;
            Btn_Update.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Btn_Update.ForeColor = Color.White;
            Btn_Update.Location = new Point(0, 739);
            Btn_Update.Margin = new Padding(3, 5, 3, 5);
            Btn_Update.Name = "Btn_Update";
            Btn_Update.Size = new Size(318, 76);
            Btn_Update.TabIndex = 15;
            Btn_Update.Text = "Opdater Køber";
            Btn_Update.UseVisualStyleBackColor = false;
            Btn_Update.Click += Btn_Update_Click;
            // 
            // Btn_Delete
            // 
            Btn_Delete.BackColor = SystemColors.ControlDark;
            Btn_Delete.Dock = DockStyle.Bottom;
            Btn_Delete.FlatAppearance.BorderSize = 2;
            Btn_Delete.FlatStyle = FlatStyle.Flat;
            Btn_Delete.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Btn_Delete.ForeColor = Color.White;
            Btn_Delete.Location = new Point(0, 815);
            Btn_Delete.Margin = new Padding(3, 4, 3, 4);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(318, 76);
            Btn_Delete.TabIndex = 14;
            Btn_Delete.Text = "Slet Køber";
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // DGV_Kunde_Bolig
            // 
            DGV_Kunde_Bolig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Kunde_Bolig.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Kunde_Bolig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Kunde_Bolig.Location = new Point(4, 504);
            DGV_Kunde_Bolig.Name = "DGV_Kunde_Bolig";
            DGV_Kunde_Bolig.ReadOnly = true;
            DGV_Kunde_Bolig.RowHeadersWidth = 51;
            DGV_Kunde_Bolig.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Kunde_Bolig.Size = new Size(960, 92);
            DGV_Kunde_Bolig.TabIndex = 10;
            DGV_Kunde_Bolig.CellMouseClick += DGV_Kunde_Bolig_CellMouseClick;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(4, 8);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Navn...";
            TxtSearch.Size = new Size(528, 27);
            TxtSearch.TabIndex = 9;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // DGVKunde
            // 
            DGVKunde.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVKunde.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVKunde.BackgroundColor = SystemColors.Control;
            DGVKunde.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVKunde.Location = new Point(4, 40);
            DGVKunde.Margin = new Padding(3, 4, 3, 4);
            DGVKunde.Name = "DGVKunde";
            DGVKunde.ReadOnly = true;
            DGVKunde.RowHeadersWidth = 51;
            DGVKunde.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVKunde.Size = new Size(960, 400);
            DGVKunde.TabIndex = 7;
            DGVKunde.CellClick += DGVKunde_CellClick;
            DGVKunde.CellMouseClick += DGVKunde_CellMouseClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Txtbox_SaelgerEmail);
            panel1.Controls.Add(Txtbox_MaeglerEmail);
            panel1.Controls.Add(Lbl_MeaglerEmail);
            panel1.Controls.Add(Lbl_SaeglerEmail);
            panel1.Controls.Add(Txtbox_MaeglerTlf);
            panel1.Controls.Add(Lbl_TlfNr);
            panel1.Controls.Add(Txtbox_SælgerTlfnr);
            panel1.Controls.Add(textbox_MaeglerNavn);
            panel1.Controls.Add(Lbl_MaeglerNavn);
            panel1.Controls.Add(Lbl_SaeglerTlfnr);
            panel1.Controls.Add(Lbl_Maegler);
            panel1.Controls.Add(Btn_Create);
            panel1.Controls.Add(Txtbox_SaelgerNavn);
            panel1.Controls.Add(Btn_Update);
            panel1.Controls.Add(Btn_Delete);
            panel1.Controls.Add(Lbl_SaeglerNavn);
            panel1.Controls.Add(Lbl_Saelger);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(977, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 891);
            panel1.TabIndex = 8;
            // 
            // Txtbox_SaelgerEmail
            // 
            Txtbox_SaelgerEmail.Anchor = AnchorStyles.Top;
            Txtbox_SaelgerEmail.Location = new Point(9, 271);
            Txtbox_SaelgerEmail.Margin = new Padding(3, 4, 3, 4);
            Txtbox_SaelgerEmail.Name = "Txtbox_SaelgerEmail";
            Txtbox_SaelgerEmail.ReadOnly = true;
            Txtbox_SaelgerEmail.Size = new Size(297, 27);
            Txtbox_SaelgerEmail.TabIndex = 30;
            // 
            // Txtbox_MaeglerEmail
            // 
            Txtbox_MaeglerEmail.Anchor = AnchorStyles.Top;
            Txtbox_MaeglerEmail.Location = new Point(7, 554);
            Txtbox_MaeglerEmail.Margin = new Padding(3, 4, 3, 4);
            Txtbox_MaeglerEmail.Name = "Txtbox_MaeglerEmail";
            Txtbox_MaeglerEmail.ReadOnly = true;
            Txtbox_MaeglerEmail.Size = new Size(297, 27);
            Txtbox_MaeglerEmail.TabIndex = 23;
            // 
            // Lbl_MeaglerEmail
            // 
            Lbl_MeaglerEmail.Anchor = AnchorStyles.Top;
            Lbl_MeaglerEmail.AutoSize = true;
            Lbl_MeaglerEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_MeaglerEmail.ForeColor = Color.White;
            Lbl_MeaglerEmail.Location = new Point(7, 524);
            Lbl_MeaglerEmail.Name = "Lbl_MeaglerEmail";
            Lbl_MeaglerEmail.Size = new Size(54, 23);
            Lbl_MeaglerEmail.TabIndex = 22;
            Lbl_MeaglerEmail.Text = "Email";
            // 
            // Lbl_SaeglerEmail
            // 
            Lbl_SaeglerEmail.Anchor = AnchorStyles.Top;
            Lbl_SaeglerEmail.AutoSize = true;
            Lbl_SaeglerEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_SaeglerEmail.ForeColor = Color.White;
            Lbl_SaeglerEmail.Location = new Point(9, 242);
            Lbl_SaeglerEmail.Name = "Lbl_SaeglerEmail";
            Lbl_SaeglerEmail.Size = new Size(54, 23);
            Lbl_SaeglerEmail.TabIndex = 29;
            Lbl_SaeglerEmail.Text = "Email";
            // 
            // Txtbox_MaeglerTlf
            // 
            Txtbox_MaeglerTlf.Anchor = AnchorStyles.Top;
            Txtbox_MaeglerTlf.Location = new Point(7, 490);
            Txtbox_MaeglerTlf.Margin = new Padding(3, 4, 3, 4);
            Txtbox_MaeglerTlf.Name = "Txtbox_MaeglerTlf";
            Txtbox_MaeglerTlf.ReadOnly = true;
            Txtbox_MaeglerTlf.Size = new Size(297, 27);
            Txtbox_MaeglerTlf.TabIndex = 21;
            // 
            // Lbl_TlfNr
            // 
            Lbl_TlfNr.Anchor = AnchorStyles.Top;
            Lbl_TlfNr.AutoSize = true;
            Lbl_TlfNr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_TlfNr.ForeColor = Color.White;
            Lbl_TlfNr.Location = new Point(7, 460);
            Lbl_TlfNr.Name = "Lbl_TlfNr";
            Lbl_TlfNr.Size = new Size(57, 23);
            Lbl_TlfNr.TabIndex = 20;
            Lbl_TlfNr.Text = "Tlf Nr";
            // 
            // Txtbox_SælgerTlfnr
            // 
            Txtbox_SælgerTlfnr.Anchor = AnchorStyles.Top;
            Txtbox_SælgerTlfnr.Location = new Point(9, 207);
            Txtbox_SælgerTlfnr.Margin = new Padding(3, 4, 3, 4);
            Txtbox_SælgerTlfnr.Name = "Txtbox_SælgerTlfnr";
            Txtbox_SælgerTlfnr.ReadOnly = true;
            Txtbox_SælgerTlfnr.Size = new Size(297, 27);
            Txtbox_SælgerTlfnr.TabIndex = 28;
            // 
            // textbox_MaeglerNavn
            // 
            textbox_MaeglerNavn.Anchor = AnchorStyles.Top;
            textbox_MaeglerNavn.Location = new Point(7, 426);
            textbox_MaeglerNavn.Margin = new Padding(3, 4, 3, 4);
            textbox_MaeglerNavn.Name = "textbox_MaeglerNavn";
            textbox_MaeglerNavn.ReadOnly = true;
            textbox_MaeglerNavn.Size = new Size(297, 27);
            textbox_MaeglerNavn.TabIndex = 19;
            // 
            // Lbl_MaeglerNavn
            // 
            Lbl_MaeglerNavn.Anchor = AnchorStyles.Top;
            Lbl_MaeglerNavn.AutoSize = true;
            Lbl_MaeglerNavn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_MaeglerNavn.ForeColor = Color.White;
            Lbl_MaeglerNavn.Location = new Point(7, 396);
            Lbl_MaeglerNavn.Name = "Lbl_MaeglerNavn";
            Lbl_MaeglerNavn.Size = new Size(51, 23);
            Lbl_MaeglerNavn.TabIndex = 18;
            Lbl_MaeglerNavn.Text = "Navn";
            // 
            // Lbl_SaeglerTlfnr
            // 
            Lbl_SaeglerTlfnr.Anchor = AnchorStyles.Top;
            Lbl_SaeglerTlfnr.AutoSize = true;
            Lbl_SaeglerTlfnr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_SaeglerTlfnr.ForeColor = Color.White;
            Lbl_SaeglerTlfnr.Location = new Point(9, 178);
            Lbl_SaeglerTlfnr.Name = "Lbl_SaeglerTlfnr";
            Lbl_SaeglerTlfnr.Size = new Size(57, 23);
            Lbl_SaeglerTlfnr.TabIndex = 27;
            Lbl_SaeglerTlfnr.Text = "Tlf Nr";
            // 
            // Lbl_Maegler
            // 
            Lbl_Maegler.Anchor = AnchorStyles.Top;
            Lbl_Maegler.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Lbl_Maegler.ForeColor = Color.White;
            Lbl_Maegler.Location = new Point(0, 325);
            Lbl_Maegler.Name = "Lbl_Maegler";
            Lbl_Maegler.Size = new Size(318, 89);
            Lbl_Maegler.TabIndex = 17;
            Lbl_Maegler.Text = "Ejendomsmægler";
            Lbl_Maegler.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txtbox_SaelgerNavn
            // 
            Txtbox_SaelgerNavn.Anchor = AnchorStyles.Top;
            Txtbox_SaelgerNavn.Location = new Point(9, 143);
            Txtbox_SaelgerNavn.Margin = new Padding(3, 4, 3, 4);
            Txtbox_SaelgerNavn.Name = "Txtbox_SaelgerNavn";
            Txtbox_SaelgerNavn.ReadOnly = true;
            Txtbox_SaelgerNavn.Size = new Size(297, 27);
            Txtbox_SaelgerNavn.TabIndex = 26;
            // 
            // Lbl_SaeglerNavn
            // 
            Lbl_SaeglerNavn.Anchor = AnchorStyles.Top;
            Lbl_SaeglerNavn.AutoSize = true;
            Lbl_SaeglerNavn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_SaeglerNavn.ForeColor = Color.White;
            Lbl_SaeglerNavn.Location = new Point(9, 114);
            Lbl_SaeglerNavn.Name = "Lbl_SaeglerNavn";
            Lbl_SaeglerNavn.Size = new Size(51, 23);
            Lbl_SaeglerNavn.TabIndex = 25;
            Lbl_SaeglerNavn.Text = "Navn";
            // 
            // Lbl_Saelger
            // 
            Lbl_Saelger.Anchor = AnchorStyles.Top;
            Lbl_Saelger.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Lbl_Saelger.ForeColor = Color.White;
            Lbl_Saelger.Location = new Point(0, 59);
            Lbl_Saelger.Name = "Lbl_Saelger";
            Lbl_Saelger.Size = new Size(318, 89);
            Lbl_Saelger.TabIndex = 24;
            Lbl_Saelger.Text = "Sælger";
            Lbl_Saelger.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_Refresh
            // 
            Btn_Refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Refresh.Location = new Point(870, 8);
            Btn_Refresh.Name = "Btn_Refresh";
            Btn_Refresh.Size = new Size(94, 29);
            Btn_Refresh.TabIndex = 17;
            Btn_Refresh.Text = "Refresh";
            Btn_Refresh.UseVisualStyleBackColor = true;
            Btn_Refresh.Click += Btn_Refresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 477);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 18;
            label1.Text = "Tilknyttet bolig";
            // 
            // checkBoxSolgteBoliger
            // 
            checkBoxSolgteBoliger.AutoSize = true;
            checkBoxSolgteBoliger.Location = new Point(620, 8);
            checkBoxSolgteBoliger.Name = "checkBoxSolgteBoliger";
            checkBoxSolgteBoliger.Size = new Size(126, 24);
            checkBoxSolgteBoliger.TabIndex = 19;
            checkBoxSolgteBoliger.Text = "Solgte boliger";
            checkBoxSolgteBoliger.UseVisualStyleBackColor = true;
            checkBoxSolgteBoliger.CheckedChanged += checkBoxSolgteBoliger_CheckedChanged;
            // 
            // KundeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 891);
            Controls.Add(checkBoxSolgteBoliger);
            Controls.Add(label1);
            Controls.Add(Btn_Refresh);
            Controls.Add(DGV_Kunde_Bolig);
            Controls.Add(TxtSearch);
            Controls.Add(DGVKunde);
            Controls.Add(panel1);
            Name = "KundeForm";
            Text = "Kunde";
            ((System.ComponentModel.ISupportInitialize)DGV_Kunde_Bolig).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVKunde).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Create;
        private Button Btn_Update;
        private Button Btn_Delete;
        private DataGridView DGV_Kunde_Bolig;
        private TextBox TxtSearch;
        private DataGridView DGVKunde;
        private Panel panel1;
        private Button Btn_Refresh;
        private TextBox Txtbox_MaeglerEmail;
        private Label Lbl_MeaglerEmail;
        private TextBox Txtbox_MaeglerTlf;
        private Label Lbl_TlfNr;
        private TextBox textbox_MaeglerNavn;
        private Label Lbl_MaeglerNavn;
        private Label Lbl_Maegler;
        private TextBox Txtbox_SaelgerEmail;
        private Label Lbl_SaeglerEmail;
        private TextBox Txtbox_SælgerTlfnr;
        private Label Lbl_SaeglerTlfnr;
        private TextBox Txtbox_SaelgerNavn;
        private Label Lbl_SaeglerNavn;
        private Label Lbl_Saelger;
        private Label label1;
        private CheckBox checkBoxSolgteBoliger;
    }
}