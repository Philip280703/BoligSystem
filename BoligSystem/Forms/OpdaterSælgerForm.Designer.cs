namespace BoligSystem.Forms
{
    partial class OpdaterSælgerForm
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
            Lbl_Opdater = new Label();
            GPBOX_SælgerInfo = new GroupBox();
            Txt_SælgerTlfNr = new TextBox();
            Lbl_Sælger_TlfNr = new Label();
            Txt_SælgerEmail = new TextBox();
            Lbl_Sælger_Email = new Label();
            Txt_BoligId = new TextBox();
            LBL_BoligId = new Label();
            Txt_SælgerNavn = new TextBox();
            Lbl_sælger_navn = new Label();
            Lbl_Sælger_Id = new Label();
            Txt_SælgerId = new TextBox();
            Lbl_Nyt_TlfNr = new Label();
            Txt_NytTlfNr = new TextBox();
            Btn_Update = new Button();
            GPBOX_SælgerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Opdater
            // 
            Lbl_Opdater.AutoSize = true;
            Lbl_Opdater.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Opdater.Location = new Point(8, 8);
            Lbl_Opdater.Name = "Lbl_Opdater";
            Lbl_Opdater.Size = new Size(117, 20);
            Lbl_Opdater.TabIndex = 64;
            Lbl_Opdater.Text = "Opdater Sælger";
            // 
            // GPBOX_SælgerInfo
            // 
            GPBOX_SælgerInfo.Controls.Add(Txt_SælgerTlfNr);
            GPBOX_SælgerInfo.Controls.Add(Lbl_Sælger_TlfNr);
            GPBOX_SælgerInfo.Controls.Add(Txt_SælgerEmail);
            GPBOX_SælgerInfo.Controls.Add(Lbl_Sælger_Email);
            GPBOX_SælgerInfo.Controls.Add(Txt_BoligId);
            GPBOX_SælgerInfo.Controls.Add(LBL_BoligId);
            GPBOX_SælgerInfo.Controls.Add(Txt_SælgerNavn);
            GPBOX_SælgerInfo.Controls.Add(Lbl_sælger_navn);
            GPBOX_SælgerInfo.Controls.Add(Lbl_Sælger_Id);
            GPBOX_SælgerInfo.Controls.Add(Txt_SælgerId);
            GPBOX_SælgerInfo.Location = new Point(16, 48);
            GPBOX_SælgerInfo.Name = "GPBOX_SælgerInfo";
            GPBOX_SælgerInfo.Size = new Size(248, 376);
            GPBOX_SælgerInfo.TabIndex = 65;
            GPBOX_SælgerInfo.TabStop = false;
            GPBOX_SælgerInfo.Text = "Sælger Info";
            // 
            // Txt_SælgerTlfNr
            // 
            Txt_SælgerTlfNr.Location = new Point(8, 344);
            Txt_SælgerTlfNr.Name = "Txt_SælgerTlfNr";
            Txt_SælgerTlfNr.ReadOnly = true;
            Txt_SælgerTlfNr.Size = new Size(224, 27);
            Txt_SælgerTlfNr.TabIndex = 9;
            // 
            // Lbl_Sælger_TlfNr
            // 
            Lbl_Sælger_TlfNr.AutoSize = true;
            Lbl_Sælger_TlfNr.Location = new Point(8, 320);
            Lbl_Sælger_TlfNr.Name = "Lbl_Sælger_TlfNr";
            Lbl_Sælger_TlfNr.Size = new Size(92, 20);
            Lbl_Sælger_TlfNr.TabIndex = 8;
            Lbl_Sælger_TlfNr.Text = "Sælger TlfNr";
            // 
            // Txt_SælgerEmail
            // 
            Txt_SælgerEmail.Location = new Point(8, 272);
            Txt_SælgerEmail.Name = "Txt_SælgerEmail";
            Txt_SælgerEmail.ReadOnly = true;
            Txt_SælgerEmail.Size = new Size(224, 27);
            Txt_SælgerEmail.TabIndex = 7;
            // 
            // Lbl_Sælger_Email
            // 
            Lbl_Sælger_Email.AutoSize = true;
            Lbl_Sælger_Email.Location = new Point(8, 248);
            Lbl_Sælger_Email.Name = "Lbl_Sælger_Email";
            Lbl_Sælger_Email.Size = new Size(96, 20);
            Lbl_Sælger_Email.TabIndex = 6;
            Lbl_Sælger_Email.Text = "Sælger Email";
            // 
            // Txt_BoligId
            // 
            Txt_BoligId.Location = new Point(8, 200);
            Txt_BoligId.Name = "Txt_BoligId";
            Txt_BoligId.ReadOnly = true;
            Txt_BoligId.Size = new Size(125, 27);
            Txt_BoligId.TabIndex = 5;
            // 
            // LBL_BoligId
            // 
            LBL_BoligId.AutoSize = true;
            LBL_BoligId.Location = new Point(8, 176);
            LBL_BoligId.Name = "LBL_BoligId";
            LBL_BoligId.Size = new Size(119, 20);
            LBL_BoligId.TabIndex = 4;
            LBL_BoligId.Text = "Tilkoblet BoligId";
            // 
            // Txt_SælgerNavn
            // 
            Txt_SælgerNavn.Location = new Point(8, 128);
            Txt_SælgerNavn.Name = "Txt_SælgerNavn";
            Txt_SælgerNavn.ReadOnly = true;
            Txt_SælgerNavn.Size = new Size(216, 27);
            Txt_SælgerNavn.TabIndex = 3;
            // 
            // Lbl_sælger_navn
            // 
            Lbl_sælger_navn.AutoSize = true;
            Lbl_sælger_navn.Location = new Point(8, 104);
            Lbl_sælger_navn.Name = "Lbl_sælger_navn";
            Lbl_sælger_navn.Size = new Size(93, 20);
            Lbl_sælger_navn.TabIndex = 2;
            Lbl_sælger_navn.Text = "Sælger Navn";
            // 
            // Lbl_Sælger_Id
            // 
            Lbl_Sælger_Id.AutoSize = true;
            Lbl_Sælger_Id.Location = new Point(8, 32);
            Lbl_Sælger_Id.Name = "Lbl_Sælger_Id";
            Lbl_Sælger_Id.Size = new Size(68, 20);
            Lbl_Sælger_Id.TabIndex = 1;
            Lbl_Sælger_Id.Text = "SælgerId";
            // 
            // Txt_SælgerId
            // 
            Txt_SælgerId.Location = new Point(8, 56);
            Txt_SælgerId.Name = "Txt_SælgerId";
            Txt_SælgerId.ReadOnly = true;
            Txt_SælgerId.Size = new Size(125, 27);
            Txt_SælgerId.TabIndex = 0;
            // 
            // Lbl_Nyt_TlfNr
            // 
            Lbl_Nyt_TlfNr.AutoSize = true;
            Lbl_Nyt_TlfNr.Location = new Point(312, 152);
            Lbl_Nyt_TlfNr.Name = "Lbl_Nyt_TlfNr";
            Lbl_Nyt_TlfNr.Size = new Size(69, 20);
            Lbl_Nyt_TlfNr.TabIndex = 66;
            Lbl_Nyt_TlfNr.Text = "Nyt TlfNr";
            // 
            // Txt_NytTlfNr
            // 
            Txt_NytTlfNr.Location = new Point(312, 176);
            Txt_NytTlfNr.Name = "Txt_NytTlfNr";
            Txt_NytTlfNr.Size = new Size(192, 27);
            Txt_NytTlfNr.TabIndex = 67;
            // 
            // Btn_Update
            // 
            Btn_Update.Location = new Point(320, 248);
            Btn_Update.Name = "Btn_Update";
            Btn_Update.Size = new Size(184, 29);
            Btn_Update.TabIndex = 68;
            Btn_Update.Text = "Opdater";
            Btn_Update.UseVisualStyleBackColor = true;
            Btn_Update.Click += Btn_Update_Click;
            // 
            // OpdaterSælger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 450);
            Controls.Add(Btn_Update);
            Controls.Add(Txt_NytTlfNr);
            Controls.Add(Lbl_Nyt_TlfNr);
            Controls.Add(GPBOX_SælgerInfo);
            Controls.Add(Lbl_Opdater);
            Name = "OpdaterSælger";
            Text = "OpretSælger";
            GPBOX_SælgerInfo.ResumeLayout(false);
            GPBOX_SælgerInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Opdater;
        private GroupBox GPBOX_SælgerInfo;
        private TextBox Txt_SælgerEmail;
        private Label Lbl_Sælger_Email;
        private TextBox Txt_BoligId;
        private Label LBL_BoligId;
        private TextBox Txt_SælgerNavn;
        private Label Lbl_sælger_navn;
        private Label Lbl_Sælger_Id;
        private TextBox Txt_SælgerId;
        private TextBox Txt_SælgerTlfNr;
        private Label Lbl_Sælger_TlfNr;
        private Label Lbl_Nyt_TlfNr;
        private TextBox Txt_NytTlfNr;
        private Button Btn_Update;
    }
}