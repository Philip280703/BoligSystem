using BoligSystem;
using BoligSystem.DataAccess;
using BoligSystem.Forms;
using BoligSystem.Models;

namespace BoligSystem
{
    public partial class Framework : Form
    {
        InfoBolig bf;
        Ejendomsm�glerForm ef;
        S�lgerform sf;
        KundeForm kf;
        SagerForm sagerForm;

        public Framework()
        {
            InitializeComponent();
            bf = new InfoBolig();
            ef = new Ejendomsm�glerForm();
            sf = new S�lgerform();
            kf = new KundeForm();
            sagerForm = new SagerForm();


            // Farve skifter p� knapper//
            ButtonB.BackColor = Color.FromArgb(229, 159, 0);
            ButtonB.ForeColor = Color.FromArgb(35, 31, 80);
            Lbl_Title.Text = "Bolig";

            //�bner Form inde i panelet i form1// 
            bf.TopLevel = false;
            bf.FormBorderStyle = FormBorderStyle.None;
            bf.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(bf);
            bf.Show();
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {

            // Farve skifter p� knapper//
            ButtonB.BackColor = Color.FromArgb(229, 159, 0);
            ButtonB.ForeColor = Color.FromArgb(35, 31, 80);

            ButtonS.BackColor = Color.FromArgb(35, 31, 80);
            ButtonS.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonK.BackColor = Color.FromArgb(35, 31, 80);
            ButtonK.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonM.BackColor = Color.FromArgb(35, 31, 80);
            ButtonM.ForeColor = Color.FromArgb(229, 159, 0);

            buttonSager.BackColor = Color.FromArgb(35, 31, 80);
            buttonSager.ForeColor = Color.FromArgb(229, 159, 0);

            ef.Hide();
            sf.Hide();
            kf.Hide();
            sagerForm.Hide();
            Lbl_Title.Text = "Bolig";

            //�bner Form inde i panelet i form1// 
            bf.TopLevel = false;
            bf.FormBorderStyle = FormBorderStyle.None;
            bf.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(bf);
            bf.Show();

        }

        private void ButtonS_Click(object sender, EventArgs e)
        {
            // Farve skifter p� knapper//
            ButtonB.BackColor = Color.FromArgb(35, 31, 80);
            ButtonB.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonS.BackColor = Color.FromArgb(229, 159, 0);
            ButtonS.ForeColor = Color.FromArgb(35, 31, 80);

            ButtonK.BackColor = Color.FromArgb(35, 31, 80);
            ButtonK.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonM.BackColor = Color.FromArgb(35, 31, 80);
            ButtonM.ForeColor = Color.FromArgb(229, 159, 0);

            buttonSager.BackColor = Color.FromArgb(35, 31, 80);
            buttonSager.ForeColor = Color.FromArgb(229, 159, 0);

            ef.Hide();
            bf.Hide();
            kf.Hide();
            sagerForm.Hide();
            Lbl_Title.Text = "S�lger";

            //�bner ny form
            sf.TopLevel = false;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(sf);
            sf.Show();
        }

        private void ButtonK_Click(object sender, EventArgs e)
        {
            // Farve skifter p� knapper//
            ButtonB.BackColor = Color.FromArgb(35, 31, 80);
            ButtonB.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonS.BackColor = Color.FromArgb(35, 31, 80);
            ButtonS.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonK.BackColor = Color.FromArgb(229, 159, 0);
            ButtonK.ForeColor = Color.FromArgb(35, 31, 80);

            ButtonM.BackColor = Color.FromArgb(35, 31, 80);
            ButtonM.ForeColor = Color.FromArgb(229, 159, 0);

            buttonSager.BackColor = Color.FromArgb(35, 31, 80);
            buttonSager.ForeColor = Color.FromArgb(229, 159, 0);

            ef.Hide();
            bf.Hide();
            sf.Hide();
            sagerForm.Hide();
            Lbl_Title.Text = "K�ber";

            //�bner ny form
            kf.TopLevel = false;
            kf.FormBorderStyle = FormBorderStyle.None;
            kf.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(kf);
            kf.Show();
        }

        private void ButtonM_Click(object sender, EventArgs e)
        {
            // Farve skifter p� knapper//
            ButtonB.BackColor = Color.FromArgb(35, 31, 80);
            ButtonB.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonS.BackColor = Color.FromArgb(35, 31, 80);
            ButtonS.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonK.BackColor = Color.FromArgb(35, 31, 80);
            ButtonK.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonM.BackColor = Color.FromArgb(229, 159, 0);
            ButtonM.ForeColor = Color.FromArgb(35, 31, 80);

            buttonSager.BackColor = Color.FromArgb(35, 31, 80);
            buttonSager.ForeColor = Color.FromArgb(229, 159, 0);

            bf.Hide();
            sf.Hide();
            kf.Hide();
            sagerForm.Hide();
            Lbl_Title.Text = "M�gler";

            //�bner ny form
            ef.TopLevel = false;
            ef.FormBorderStyle = FormBorderStyle.None;
            ef.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(ef);
            ef.Show();
        }

        private void buttonSager_Click(object sender, EventArgs e)
        {
            // Farve skifter p� knapper//
            ButtonB.BackColor = Color.FromArgb(35, 31, 80);
            ButtonB.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonS.BackColor = Color.FromArgb(35, 31, 80);
            ButtonS.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonK.BackColor = Color.FromArgb(35, 31, 80);
            ButtonK.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonM.BackColor = Color.FromArgb(35, 31, 80);
            ButtonM.ForeColor = Color.FromArgb(229, 159, 0);

            buttonSager.BackColor = Color.FromArgb(229, 159, 0);
            buttonSager.ForeColor = Color.FromArgb(35, 31, 80);
            bf.Hide();
            sf.Hide();
            kf.Hide();
            ef.Hide();
            Lbl_Title.Text = "Sager";

            //�bner ny form
            sagerForm.TopLevel = false;
            sagerForm.FormBorderStyle = FormBorderStyle.None;
            sagerForm.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(sagerForm);
            sagerForm.Show();
        }
    }
}
