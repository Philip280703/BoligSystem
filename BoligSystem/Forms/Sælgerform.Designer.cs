namespace SemesterProjekt.Forms
{
    partial class Sælgerform
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
            Btn_Update = new Button();
            Btn_Delete = new Button();
            DGVSælger = new DataGridView();
            panel1 = new Panel();
            labelInfo = new Label();
            TxtSearch = new TextBox();
            DGV_Saelger_Bolig = new DataGridView();
            Btn_Sorter_Solgt = new Button();
            Btn_Refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVSælger).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Saelger_Bolig).BeginInit();
            SuspendLayout();
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
            Btn_Update.Text = "Opdater Sælger";
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
            Btn_Delete.Text = "Slet Sælger";
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // DGVSælger
            // 
            DGVSælger.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGVSælger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVSælger.BackgroundColor = SystemColors.Control;
            DGVSælger.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVSælger.Location = new Point(8, 40);
            DGVSælger.Margin = new Padding(3, 4, 3, 4);
            DGVSælger.Name = "DGVSælger";
            DGVSælger.ReadOnly = true;
            DGVSælger.RowHeadersWidth = 51;
            DGVSælger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVSælger.Size = new Size(961, 400);
            DGVSælger.TabIndex = 2;
            DGVSælger.CellClick += DGVSælger_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(labelInfo);
            panel1.Controls.Add(Btn_Update);
            panel1.Controls.Add(Btn_Delete);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(977, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 891);
            panel1.TabIndex = 3;
            // 
            // labelInfo
            // 
            labelInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelInfo.AutoSize = true;
            labelInfo.BorderStyle = BorderStyle.FixedSingle;
            labelInfo.ForeColor = SystemColors.ControlLightLight;
            labelInfo.Location = new Point(57, 649);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(207, 62);
            labelInfo.TabIndex = 16;
            labelInfo.Text = "For at oprette en sælger,\r\nskal man oprette en ny bolig, \r\nsom sælger tilknyttes";
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(8, 8);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Navn...";
            TxtSearch.Size = new Size(528, 27);
            TxtSearch.TabIndex = 4;
            TxtSearch.TextChanged += TxtSearchbar_TextChanged;
            // 
            // DGV_Saelger_Bolig
            // 
            DGV_Saelger_Bolig.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Saelger_Bolig.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Saelger_Bolig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Saelger_Bolig.Location = new Point(8, 504);
            DGV_Saelger_Bolig.Name = "DGV_Saelger_Bolig";
            DGV_Saelger_Bolig.ReadOnly = true;
            DGV_Saelger_Bolig.RowHeadersWidth = 51;
            DGV_Saelger_Bolig.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Saelger_Bolig.Size = new Size(960, 93);
            DGV_Saelger_Bolig.TabIndex = 5;
            // 
            // Btn_Sorter_Solgt
            // 
            Btn_Sorter_Solgt.Location = new Point(8, 472);
            Btn_Sorter_Solgt.Name = "Btn_Sorter_Solgt";
            Btn_Sorter_Solgt.Size = new Size(94, 29);
            Btn_Sorter_Solgt.TabIndex = 6;
            Btn_Sorter_Solgt.Text = "Solgt";
            Btn_Sorter_Solgt.UseVisualStyleBackColor = true;
            Btn_Sorter_Solgt.Click += Btn_Sorter_Solgt_Click;
            // 
            // Btn_Refresh
            // 
            Btn_Refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Refresh.Location = new Point(872, 8);
            Btn_Refresh.Name = "Btn_Refresh";
            Btn_Refresh.Size = new Size(94, 29);
            Btn_Refresh.TabIndex = 7;
            Btn_Refresh.Text = "Refresh";
            Btn_Refresh.UseVisualStyleBackColor = true;
            Btn_Refresh.Click += Btn_Refresh_Click;
            // 
            // Sælgerform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 891);
            Controls.Add(Btn_Refresh);
            Controls.Add(Btn_Sorter_Solgt);
            Controls.Add(DGV_Saelger_Bolig);
            Controls.Add(TxtSearch);
            Controls.Add(DGVSælger);
            Controls.Add(panel1);
            Name = "Sælgerform";
            Text = "Sælgerform";
            Load += Sælgerform_Load;
            ((System.ComponentModel.ISupportInitialize)DGVSælger).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Saelger_Bolig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Btn_Update;
        private Button Btn_Delete;
        private DataGridView DGVSælger;
        private Panel panel1;
        private TextBox TxtSearch;
        private DataGridView DGV_Saelger_Bolig;
        private Button Btn_Sorter_Solgt;
        private Button Btn_Refresh;
        private Label labelInfo;
    }
}