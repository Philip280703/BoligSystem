namespace BoligSystem.Forms
{
    partial class OpdaterKundeform
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
            Txt_NytTlfNr = new TextBox();
            Lbl_Nyt_TlfNr = new Label();
            GPBOX_SælgerInfo = new GroupBox();
            Txt_kundeTlfNr = new TextBox();
            Lbl_Sælger_TlfNr = new Label();
            txt_Kundeemail = new TextBox();
            Lbl_Sælger_Email = new Label();
            txt_kundeefternavn = new TextBox();
            LBL_KundeEfternavn = new Label();
            txt_kundefornavn = new TextBox();
            Lbl_sælger_navn = new Label();
            Lbl_Opdater = new Label();
            btn_tilbage = new Button();
            GPBOX_SælgerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Update
            // 
            Btn_Update.Location = new Point(335, 249);
            Btn_Update.Name = "Btn_Update";
            Btn_Update.Size = new Size(184, 29);
            Btn_Update.TabIndex = 73;
            Btn_Update.Text = "Opdater";
            Btn_Update.UseVisualStyleBackColor = true;
            Btn_Update.Click += Btn_Update_Click;
            // 
            // Txt_NytTlfNr
            // 
            Txt_NytTlfNr.Location = new Point(327, 177);
            Txt_NytTlfNr.Name = "Txt_NytTlfNr";
            Txt_NytTlfNr.Size = new Size(192, 27);
            Txt_NytTlfNr.TabIndex = 72;
            // 
            // Lbl_Nyt_TlfNr
            // 
            Lbl_Nyt_TlfNr.AutoSize = true;
            Lbl_Nyt_TlfNr.Location = new Point(327, 153);
            Lbl_Nyt_TlfNr.Name = "Lbl_Nyt_TlfNr";
            Lbl_Nyt_TlfNr.Size = new Size(69, 20);
            Lbl_Nyt_TlfNr.TabIndex = 71;
            Lbl_Nyt_TlfNr.Text = "Nyt TlfNr";
            // 
            // GPBOX_SælgerInfo
            // 
            GPBOX_SælgerInfo.Controls.Add(Txt_kundeTlfNr);
            GPBOX_SælgerInfo.Controls.Add(Lbl_Sælger_TlfNr);
            GPBOX_SælgerInfo.Controls.Add(txt_Kundeemail);
            GPBOX_SælgerInfo.Controls.Add(Lbl_Sælger_Email);
            GPBOX_SælgerInfo.Controls.Add(txt_kundeefternavn);
            GPBOX_SælgerInfo.Controls.Add(LBL_KundeEfternavn);
            GPBOX_SælgerInfo.Controls.Add(txt_kundefornavn);
            GPBOX_SælgerInfo.Controls.Add(Lbl_sælger_navn);
            GPBOX_SælgerInfo.Location = new Point(31, 49);
            GPBOX_SælgerInfo.Name = "GPBOX_SælgerInfo";
            GPBOX_SælgerInfo.Size = new Size(248, 330);
            GPBOX_SælgerInfo.TabIndex = 70;
            GPBOX_SælgerInfo.TabStop = false;
            GPBOX_SælgerInfo.Text = "Sælger Info";
            // 
            // Txt_kundeTlfNr
            // 
            Txt_kundeTlfNr.Location = new Point(11, 279);
            Txt_kundeTlfNr.Name = "Txt_kundeTlfNr";
            Txt_kundeTlfNr.ReadOnly = true;
            Txt_kundeTlfNr.Size = new Size(224, 27);
            Txt_kundeTlfNr.TabIndex = 9;
            // 
            // Lbl_Sælger_TlfNr
            // 
            Lbl_Sælger_TlfNr.AutoSize = true;
            Lbl_Sælger_TlfNr.Location = new Point(11, 255);
            Lbl_Sælger_TlfNr.Name = "Lbl_Sælger_TlfNr";
            Lbl_Sælger_TlfNr.Size = new Size(88, 20);
            Lbl_Sælger_TlfNr.TabIndex = 8;
            Lbl_Sælger_TlfNr.Text = "Kunde TlfNr";
            // 
            // txt_Kundeemail
            // 
            txt_Kundeemail.Location = new Point(11, 207);
            txt_Kundeemail.Name = "txt_Kundeemail";
            txt_Kundeemail.ReadOnly = true;
            txt_Kundeemail.Size = new Size(224, 27);
            txt_Kundeemail.TabIndex = 7;
            // 
            // Lbl_Sælger_Email
            // 
            Lbl_Sælger_Email.AutoSize = true;
            Lbl_Sælger_Email.Location = new Point(11, 183);
            Lbl_Sælger_Email.Name = "Lbl_Sælger_Email";
            Lbl_Sælger_Email.Size = new Size(92, 20);
            Lbl_Sælger_Email.TabIndex = 6;
            Lbl_Sælger_Email.Text = "Kunde Email";
            // 
            // txt_kundeefternavn
            // 
            txt_kundeefternavn.Location = new Point(11, 135);
            txt_kundeefternavn.Name = "txt_kundeefternavn";
            txt_kundeefternavn.ReadOnly = true;
            txt_kundeefternavn.Size = new Size(125, 27);
            txt_kundeefternavn.TabIndex = 5;
            // 
            // LBL_KundeEfternavn
            // 
            LBL_KundeEfternavn.AutoSize = true;
            LBL_KundeEfternavn.Location = new Point(11, 111);
            LBL_KundeEfternavn.Name = "LBL_KundeEfternavn";
            LBL_KundeEfternavn.Size = new Size(117, 20);
            LBL_KundeEfternavn.TabIndex = 4;
            LBL_KundeEfternavn.Text = "Kunde efternavn";
            // 
            // txt_kundefornavn
            // 
            txt_kundefornavn.Location = new Point(11, 63);
            txt_kundefornavn.Name = "txt_kundefornavn";
            txt_kundefornavn.ReadOnly = true;
            txt_kundefornavn.Size = new Size(216, 27);
            txt_kundefornavn.TabIndex = 3;
            // 
            // Lbl_sælger_navn
            // 
            Lbl_sælger_navn.AutoSize = true;
            Lbl_sælger_navn.Location = new Point(11, 39);
            Lbl_sælger_navn.Name = "Lbl_sælger_navn";
            Lbl_sælger_navn.Size = new Size(105, 20);
            Lbl_sælger_navn.TabIndex = 2;
            Lbl_sælger_navn.Text = "Kunde fornavn";
            // 
            // Lbl_Opdater
            // 
            Lbl_Opdater.AutoSize = true;
            Lbl_Opdater.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Opdater.Location = new Point(23, 9);
            Lbl_Opdater.Name = "Lbl_Opdater";
            Lbl_Opdater.Size = new Size(115, 20);
            Lbl_Opdater.TabIndex = 69;
            Lbl_Opdater.Text = "Opdater Kunde";
            // 
            // btn_tilbage
            // 
            btn_tilbage.Location = new Point(42, 401);
            btn_tilbage.Name = "btn_tilbage";
            btn_tilbage.Size = new Size(184, 29);
            btn_tilbage.TabIndex = 74;
            btn_tilbage.Text = "Tilbage";
            btn_tilbage.UseVisualStyleBackColor = true;
            btn_tilbage.Click += btn_tilbage_Click;
            // 
            // OpdaterKundeform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 442);
            Controls.Add(btn_tilbage);
            Controls.Add(Btn_Update);
            Controls.Add(Txt_NytTlfNr);
            Controls.Add(Lbl_Nyt_TlfNr);
            Controls.Add(GPBOX_SælgerInfo);
            Controls.Add(Lbl_Opdater);
            Name = "OpdaterKundeform";
            Text = "OpdaterKundeform";
            GPBOX_SælgerInfo.ResumeLayout(false);
            GPBOX_SælgerInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Update;
        private TextBox Txt_NytTlfNr;
        private Label Lbl_Nyt_TlfNr;
        private GroupBox GPBOX_SælgerInfo;
        private TextBox Txt_kundeTlfNr;
        private Label Lbl_Sælger_TlfNr;
        private TextBox txt_Kundeemail;
        private Label Lbl_Sælger_Email;
        private TextBox txt_kundeefternavn;
        private Label LBL_KundeEfternavn;
        private TextBox txt_kundefornavn;
        private Label Lbl_sælger_navn;
        private Label Lbl_Opdater;
        private Button btn_tilbage;
    }
}