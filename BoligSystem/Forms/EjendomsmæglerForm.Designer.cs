namespace SemesterProjekt.Forms
{
    partial class EjendomsmæglerForm
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
            TxtBox_Sælger_Email = new TextBox();
            Lbl_Sælger_Email = new Label();
            TxtBox_Sælger_TlfNr = new TextBox();
            Lbl_Sælger_TlfNr = new Label();
            TxtBox_Sælger_Navn = new TextBox();
            Lbl_Sælger_Navn = new Label();
            Lbl_Sælger = new Label();
            Refreshbutton = new Button();
            ScreenPnl = new Panel();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            Lbl_Tilknyttede_Boliger_Inaktive = new Label();
            Lbl_Mæglere_Tilknyttede_Aktive = new Label();
            Lbl_Dgv_Mægler = new Label();
            Dgv_Inaktive_Boliger = new DataGridView();
            Dgv_Mægler = new DataGridView();
            Dgv_Aktive_Boliger = new DataGridView();
            TxtBox_Køber_Email = new TextBox();
            Lbl_Køber_Email = new Label();
            TxtBox_Køber_TlfNr = new TextBox();
            Lbl_Køber_TlfNr = new Label();
            Lbl_Køber_Navn = new Label();
            Lbl_Køber = new Label();
            panel1 = new Panel();
            TxtBox_Køber_Navn = new TextBox();
            ScreenPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Inaktive_Boliger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Mægler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Aktive_Boliger).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Create
            // 
            Btn_Create.BackColor = SystemColors.ControlDark;
            Btn_Create.Dock = DockStyle.Bottom;
            Btn_Create.FlatAppearance.BorderSize = 2;
            Btn_Create.FlatStyle = FlatStyle.Flat;
            Btn_Create.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Btn_Create.ForeColor = Color.White;
            Btn_Create.Location = new Point(0, 663);
            Btn_Create.Margin = new Padding(3, 5, 3, 5);
            Btn_Create.Name = "Btn_Create";
            Btn_Create.Size = new Size(318, 76);
            Btn_Create.TabIndex = 16;
            Btn_Create.Text = "Opret Ejendomsmægler";
            Btn_Create.UseVisualStyleBackColor = false;
            Btn_Create.Click += Btn_Create_Click;
            // 
            // Btn_Update
            // 
            Btn_Update.BackColor = SystemColors.ControlDark;
            Btn_Update.Dock = DockStyle.Bottom;
            Btn_Update.FlatAppearance.BorderSize = 2;
            Btn_Update.FlatStyle = FlatStyle.Flat;
            Btn_Update.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Btn_Update.ForeColor = Color.White;
            Btn_Update.Location = new Point(0, 739);
            Btn_Update.Margin = new Padding(3, 5, 3, 5);
            Btn_Update.Name = "Btn_Update";
            Btn_Update.Size = new Size(318, 76);
            Btn_Update.TabIndex = 15;
            Btn_Update.Text = "Opdater Ejendomsmægler afd.";
            Btn_Update.UseVisualStyleBackColor = false;
            Btn_Update.Click += Btn_Update_Click;
            // 
            // Btn_Delete
            // 
            Btn_Delete.BackColor = SystemColors.ControlDark;
            Btn_Delete.Dock = DockStyle.Bottom;
            Btn_Delete.FlatAppearance.BorderSize = 2;
            Btn_Delete.FlatStyle = FlatStyle.Flat;
            Btn_Delete.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Btn_Delete.ForeColor = Color.White;
            Btn_Delete.Location = new Point(0, 815);
            Btn_Delete.Margin = new Padding(3, 4, 3, 4);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(318, 76);
            Btn_Delete.TabIndex = 14;
            Btn_Delete.Text = "Ejendomsmægler aktivitet";
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // TxtBox_Sælger_Email
            // 
            TxtBox_Sælger_Email.Anchor = AnchorStyles.Top;
            TxtBox_Sælger_Email.Location = new Point(8, 528);
            TxtBox_Sælger_Email.Margin = new Padding(3, 4, 3, 4);
            TxtBox_Sælger_Email.Name = "TxtBox_Sælger_Email";
            TxtBox_Sælger_Email.ReadOnly = true;
            TxtBox_Sælger_Email.Size = new Size(297, 27);
            TxtBox_Sælger_Email.TabIndex = 13;
            // 
            // Lbl_Sælger_Email
            // 
            Lbl_Sælger_Email.Anchor = AnchorStyles.Top;
            Lbl_Sælger_Email.AutoSize = true;
            Lbl_Sælger_Email.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_Sælger_Email.ForeColor = Color.White;
            Lbl_Sælger_Email.Location = new Point(8, 499);
            Lbl_Sælger_Email.Name = "Lbl_Sælger_Email";
            Lbl_Sælger_Email.Size = new Size(54, 23);
            Lbl_Sælger_Email.TabIndex = 12;
            Lbl_Sælger_Email.Text = "Email";
            // 
            // TxtBox_Sælger_TlfNr
            // 
            TxtBox_Sælger_TlfNr.Anchor = AnchorStyles.Top;
            TxtBox_Sælger_TlfNr.Location = new Point(8, 464);
            TxtBox_Sælger_TlfNr.Margin = new Padding(3, 4, 3, 4);
            TxtBox_Sælger_TlfNr.Name = "TxtBox_Sælger_TlfNr";
            TxtBox_Sælger_TlfNr.ReadOnly = true;
            TxtBox_Sælger_TlfNr.Size = new Size(297, 27);
            TxtBox_Sælger_TlfNr.TabIndex = 11;
            // 
            // Lbl_Sælger_TlfNr
            // 
            Lbl_Sælger_TlfNr.Anchor = AnchorStyles.Top;
            Lbl_Sælger_TlfNr.AutoSize = true;
            Lbl_Sælger_TlfNr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_Sælger_TlfNr.ForeColor = Color.White;
            Lbl_Sælger_TlfNr.Location = new Point(8, 435);
            Lbl_Sælger_TlfNr.Name = "Lbl_Sælger_TlfNr";
            Lbl_Sælger_TlfNr.Size = new Size(57, 23);
            Lbl_Sælger_TlfNr.TabIndex = 10;
            Lbl_Sælger_TlfNr.Text = "Tlf Nr";
            // 
            // TxtBox_Sælger_Navn
            // 
            TxtBox_Sælger_Navn.Anchor = AnchorStyles.Top;
            TxtBox_Sælger_Navn.Location = new Point(8, 400);
            TxtBox_Sælger_Navn.Margin = new Padding(3, 4, 3, 4);
            TxtBox_Sælger_Navn.Name = "TxtBox_Sælger_Navn";
            TxtBox_Sælger_Navn.ReadOnly = true;
            TxtBox_Sælger_Navn.Size = new Size(297, 27);
            TxtBox_Sælger_Navn.TabIndex = 9;
            // 
            // Lbl_Sælger_Navn
            // 
            Lbl_Sælger_Navn.Anchor = AnchorStyles.Top;
            Lbl_Sælger_Navn.AutoSize = true;
            Lbl_Sælger_Navn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_Sælger_Navn.ForeColor = Color.White;
            Lbl_Sælger_Navn.Location = new Point(8, 371);
            Lbl_Sælger_Navn.Name = "Lbl_Sælger_Navn";
            Lbl_Sælger_Navn.Size = new Size(51, 23);
            Lbl_Sælger_Navn.TabIndex = 8;
            Lbl_Sælger_Navn.Text = "Navn";
            // 
            // Lbl_Sælger
            // 
            Lbl_Sælger.Anchor = AnchorStyles.Top;
            Lbl_Sælger.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Lbl_Sælger.ForeColor = Color.White;
            Lbl_Sælger.Location = new Point(0, 280);
            Lbl_Sælger.Name = "Lbl_Sælger";
            Lbl_Sælger.Size = new Size(318, 89);
            Lbl_Sælger.TabIndex = 7;
            Lbl_Sælger.Text = "Sælger";
            Lbl_Sælger.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Refreshbutton
            // 
            Refreshbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Refreshbutton.Location = new Point(1713, 85);
            Refreshbutton.Margin = new Padding(3, 4, 3, 4);
            Refreshbutton.Name = "Refreshbutton";
            Refreshbutton.Size = new Size(86, 31);
            Refreshbutton.TabIndex = 5;
            Refreshbutton.Text = "Refresh";
            Refreshbutton.UseVisualStyleBackColor = true;
            // 
            // ScreenPnl
            // 
            ScreenPnl.Controls.Add(buttonDelete);
            ScreenPnl.Controls.Add(buttonRefresh);
            ScreenPnl.Controls.Add(Lbl_Tilknyttede_Boliger_Inaktive);
            ScreenPnl.Controls.Add(Lbl_Mæglere_Tilknyttede_Aktive);
            ScreenPnl.Controls.Add(Lbl_Dgv_Mægler);
            ScreenPnl.Controls.Add(Dgv_Inaktive_Boliger);
            ScreenPnl.Controls.Add(Dgv_Mægler);
            ScreenPnl.Controls.Add(Dgv_Aktive_Boliger);
            ScreenPnl.Controls.Add(Refreshbutton);
            ScreenPnl.Dock = DockStyle.Fill;
            ScreenPnl.Location = new Point(0, 0);
            ScreenPnl.Margin = new Padding(3, 4, 3, 4);
            ScreenPnl.Name = "ScreenPnl";
            ScreenPnl.Size = new Size(977, 891);
            ScreenPnl.TabIndex = 4;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonDelete.Location = new Point(16, 856);
            buttonDelete.Margin = new Padding(3, 4, 3, 4);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(187, 31);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete ejendomsmægler";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRefresh.Location = new Point(878, 4);
            buttonRefresh.Margin = new Padding(3, 4, 3, 4);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(86, 31);
            buttonRefresh.TabIndex = 11;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // Lbl_Tilknyttede_Boliger_Inaktive
            // 
            Lbl_Tilknyttede_Boliger_Inaktive.AutoSize = true;
            Lbl_Tilknyttede_Boliger_Inaktive.Location = new Point(16, 544);
            Lbl_Tilknyttede_Boliger_Inaktive.Name = "Lbl_Tilknyttede_Boliger_Inaktive";
            Lbl_Tilknyttede_Boliger_Inaktive.Size = new Size(199, 20);
            Lbl_Tilknyttede_Boliger_Inaktive.TabIndex = 10;
            Lbl_Tilknyttede_Boliger_Inaktive.Text = "Tilknyttede boliger (inaktive)";
            // 
            // Lbl_Mæglere_Tilknyttede_Aktive
            // 
            Lbl_Mæglere_Tilknyttede_Aktive.AutoSize = true;
            Lbl_Mæglere_Tilknyttede_Aktive.Location = new Point(16, 208);
            Lbl_Mæglere_Tilknyttede_Aktive.Name = "Lbl_Mæglere_Tilknyttede_Aktive";
            Lbl_Mæglere_Tilknyttede_Aktive.Size = new Size(187, 20);
            Lbl_Mæglere_Tilknyttede_Aktive.TabIndex = 9;
            Lbl_Mæglere_Tilknyttede_Aktive.Text = "Tilknyttede boliger (aktive)";
            // 
            // Lbl_Dgv_Mægler
            // 
            Lbl_Dgv_Mægler.AutoSize = true;
            Lbl_Dgv_Mægler.Location = new Point(16, 15);
            Lbl_Dgv_Mægler.Name = "Lbl_Dgv_Mægler";
            Lbl_Dgv_Mægler.Size = new Size(133, 20);
            Lbl_Dgv_Mægler.TabIndex = 8;
            Lbl_Dgv_Mægler.Text = "Ejendomsmæglere";
            // 
            // Dgv_Inaktive_Boliger
            // 
            Dgv_Inaktive_Boliger.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Inaktive_Boliger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Inaktive_Boliger.BackgroundColor = SystemColors.Control;
            Dgv_Inaktive_Boliger.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Inaktive_Boliger.Location = new Point(16, 568);
            Dgv_Inaktive_Boliger.Margin = new Padding(3, 4, 3, 4);
            Dgv_Inaktive_Boliger.Name = "Dgv_Inaktive_Boliger";
            Dgv_Inaktive_Boliger.ReadOnly = true;
            Dgv_Inaktive_Boliger.RowHeadersWidth = 51;
            Dgv_Inaktive_Boliger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Inaktive_Boliger.Size = new Size(948, 283);
            Dgv_Inaktive_Boliger.TabIndex = 7;
            Dgv_Inaktive_Boliger.CellClick += Dgv_Inaktive_Boliger_CellClick;
            // 
            // Dgv_Mægler
            // 
            Dgv_Mægler.AllowUserToAddRows = false;
            Dgv_Mægler.AllowUserToDeleteRows = false;
            Dgv_Mægler.AllowUserToResizeColumns = false;
            Dgv_Mægler.AllowUserToResizeRows = false;
            Dgv_Mægler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Mægler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Mægler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Mægler.Location = new Point(16, 42);
            Dgv_Mægler.Name = "Dgv_Mægler";
            Dgv_Mægler.ReadOnly = true;
            Dgv_Mægler.RowHeadersWidth = 51;
            Dgv_Mægler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Mægler.Size = new Size(948, 152);
            Dgv_Mægler.TabIndex = 6;
            Dgv_Mægler.CellClick += Dgv_Mægler_CellClick;
            // 
            // Dgv_Aktive_Boliger
            // 
            Dgv_Aktive_Boliger.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Aktive_Boliger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Aktive_Boliger.BackgroundColor = SystemColors.Control;
            Dgv_Aktive_Boliger.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv_Aktive_Boliger.Location = new Point(16, 232);
            Dgv_Aktive_Boliger.Margin = new Padding(3, 4, 3, 4);
            Dgv_Aktive_Boliger.Name = "Dgv_Aktive_Boliger";
            Dgv_Aktive_Boliger.ReadOnly = true;
            Dgv_Aktive_Boliger.RowHeadersWidth = 51;
            Dgv_Aktive_Boliger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv_Aktive_Boliger.Size = new Size(948, 288);
            Dgv_Aktive_Boliger.TabIndex = 5;
            Dgv_Aktive_Boliger.CellClick += Dgv_Aktive_Boliger_CellClick;
            // 
            // TxtBox_Køber_Email
            // 
            TxtBox_Køber_Email.Anchor = AnchorStyles.Top;
            TxtBox_Køber_Email.Location = new Point(7, 247);
            TxtBox_Køber_Email.Margin = new Padding(3, 4, 3, 4);
            TxtBox_Køber_Email.Name = "TxtBox_Køber_Email";
            TxtBox_Køber_Email.ReadOnly = true;
            TxtBox_Køber_Email.Size = new Size(297, 27);
            TxtBox_Køber_Email.TabIndex = 6;
            // 
            // Lbl_Køber_Email
            // 
            Lbl_Køber_Email.Anchor = AnchorStyles.Top;
            Lbl_Køber_Email.AutoSize = true;
            Lbl_Køber_Email.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_Køber_Email.ForeColor = Color.White;
            Lbl_Køber_Email.Location = new Point(7, 217);
            Lbl_Køber_Email.Name = "Lbl_Køber_Email";
            Lbl_Køber_Email.Size = new Size(54, 23);
            Lbl_Køber_Email.TabIndex = 5;
            Lbl_Køber_Email.Text = "Email";
            // 
            // TxtBox_Køber_TlfNr
            // 
            TxtBox_Køber_TlfNr.Anchor = AnchorStyles.Top;
            TxtBox_Køber_TlfNr.Location = new Point(7, 183);
            TxtBox_Køber_TlfNr.Margin = new Padding(3, 4, 3, 4);
            TxtBox_Køber_TlfNr.Name = "TxtBox_Køber_TlfNr";
            TxtBox_Køber_TlfNr.ReadOnly = true;
            TxtBox_Køber_TlfNr.Size = new Size(297, 27);
            TxtBox_Køber_TlfNr.TabIndex = 4;
            // 
            // Lbl_Køber_TlfNr
            // 
            Lbl_Køber_TlfNr.Anchor = AnchorStyles.Top;
            Lbl_Køber_TlfNr.AutoSize = true;
            Lbl_Køber_TlfNr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_Køber_TlfNr.ForeColor = Color.White;
            Lbl_Køber_TlfNr.Location = new Point(7, 153);
            Lbl_Køber_TlfNr.Name = "Lbl_Køber_TlfNr";
            Lbl_Køber_TlfNr.Size = new Size(57, 23);
            Lbl_Køber_TlfNr.TabIndex = 3;
            Lbl_Køber_TlfNr.Text = "Tlf Nr";
            // 
            // Lbl_Køber_Navn
            // 
            Lbl_Køber_Navn.Anchor = AnchorStyles.Top;
            Lbl_Køber_Navn.AutoSize = true;
            Lbl_Køber_Navn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Lbl_Køber_Navn.ForeColor = Color.White;
            Lbl_Køber_Navn.Location = new Point(7, 89);
            Lbl_Køber_Navn.Name = "Lbl_Køber_Navn";
            Lbl_Køber_Navn.Size = new Size(51, 23);
            Lbl_Køber_Navn.TabIndex = 1;
            Lbl_Køber_Navn.Text = "Navn";
            // 
            // Lbl_Køber
            // 
            Lbl_Køber.Anchor = AnchorStyles.Top;
            Lbl_Køber.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Lbl_Køber.ForeColor = Color.White;
            Lbl_Køber.Location = new Point(0, 0);
            Lbl_Køber.Name = "Lbl_Køber";
            Lbl_Køber.Size = new Size(318, 89);
            Lbl_Køber.TabIndex = 0;
            Lbl_Køber.Text = "Køber";
            Lbl_Køber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(Btn_Create);
            panel1.Controls.Add(Btn_Update);
            panel1.Controls.Add(Btn_Delete);
            panel1.Controls.Add(TxtBox_Sælger_Email);
            panel1.Controls.Add(Lbl_Sælger_Email);
            panel1.Controls.Add(TxtBox_Sælger_TlfNr);
            panel1.Controls.Add(Lbl_Sælger_TlfNr);
            panel1.Controls.Add(TxtBox_Sælger_Navn);
            panel1.Controls.Add(Lbl_Sælger_Navn);
            panel1.Controls.Add(Lbl_Sælger);
            panel1.Controls.Add(TxtBox_Køber_Email);
            panel1.Controls.Add(Lbl_Køber_Email);
            panel1.Controls.Add(TxtBox_Køber_TlfNr);
            panel1.Controls.Add(Lbl_Køber_TlfNr);
            panel1.Controls.Add(TxtBox_Køber_Navn);
            panel1.Controls.Add(Lbl_Køber_Navn);
            panel1.Controls.Add(Lbl_Køber);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(977, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 891);
            panel1.TabIndex = 3;
            // 
            // TxtBox_Køber_Navn
            // 
            TxtBox_Køber_Navn.Anchor = AnchorStyles.Top;
            TxtBox_Køber_Navn.Location = new Point(7, 119);
            TxtBox_Køber_Navn.Margin = new Padding(3, 4, 3, 4);
            TxtBox_Køber_Navn.Name = "TxtBox_Køber_Navn";
            TxtBox_Køber_Navn.ReadOnly = true;
            TxtBox_Køber_Navn.Size = new Size(297, 27);
            TxtBox_Køber_Navn.TabIndex = 2;
            // 
            // EjendomsmæglerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1295, 891);
            Controls.Add(ScreenPnl);
            Controls.Add(panel1);
            Name = "EjendomsmæglerForm";
            Text = "EjendomsmæglerForm";
            Load += EjendomsmæglerForm_Load;
            ScreenPnl.ResumeLayout(false);
            ScreenPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Dgv_Inaktive_Boliger).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Mægler).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Aktive_Boliger).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Btn_Create;
        private Button Btn_Update;
        private Button Btn_Delete;
        private TextBox TxtBox_Sælger_Email;
        private Label Lbl_Sælger_Email;
        private TextBox TxtBox_Sælger_TlfNr;
        private Label Lbl_Sælger_TlfNr;
        private TextBox TxtBox_Sælger_Navn;
        private Label Lbl_Sælger_Navn;
        private Label Lbl_Sælger;
        private Button Refreshbutton;
        private Panel ScreenPnl;
        private TextBox TxtBox_Køber_Email;
        private Label Lbl_Køber_Email;
        private TextBox TxtBox_Køber_TlfNr;
        private Label Lbl_Køber_TlfNr;
        private Label Lbl_Køber_Navn;
        private Label Lbl_Køber;
        private Panel panel1;
        private TextBox TxtBox_Køber_Navn;
        private DataGridView Dgv_Aktive_Boliger;
        private DataGridView Dgv_Mægler;
        private Label Lbl_Tilknyttede_Boliger_Inaktive;
        private Label Lbl_Mæglere_Tilknyttede_Aktive;
        private Label Lbl_Dgv_Mægler;
        private DataGridView Dgv_Inaktive_Boliger;
        private Button buttonRefresh;
        private Button buttonDelete;
    }
}