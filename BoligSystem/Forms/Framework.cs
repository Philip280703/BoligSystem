using BoligSystem.DataAccess;
using BoligSystem.Forms;
using BoligSystem.Models;
using System.Text;

namespace BoligSystem
{
    public partial class Framework : Form
    {
        InfoBolig bf;
        EjendomsmæglerForm ef;
        Sælgerform sf;
        KundeForm kf;

        public Framework()
        {
            InitializeComponent();
            bf = new InfoBolig();
            ef = new EjendomsmæglerForm();
            sf = new Sælgerform();
            kf = new KundeForm();


            // Farve skifter på knapper//
            ButtonB.BackColor = Color.FromArgb(229, 159, 0);
            ButtonB.ForeColor = Color.FromArgb(35, 31, 80);
            Lbl_Title.Text = "Bolig";

            //Åbner Form inde i panelet i form1// 
            bf.TopLevel = false;
            bf.FormBorderStyle = FormBorderStyle.None;
            bf.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(bf);
            bf.Show();
        }

        private void ButtonB_Click(object sender, EventArgs e)
        {

            // Farve skifter på knapper//
            ButtonB.BackColor = Color.FromArgb(229, 159, 0);
            ButtonB.ForeColor = Color.FromArgb(35, 31, 80);

            ButtonS.BackColor = Color.FromArgb(35, 31, 80);
            ButtonS.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonK.BackColor = Color.FromArgb(35, 31, 80);
            ButtonK.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonM.BackColor = Color.FromArgb(35, 31, 80);
            ButtonM.ForeColor = Color.FromArgb(229, 159, 0);
            ef.Hide();
            sf.Hide();
            kf.Hide();
            Lbl_Title.Text = "Bolig";

            //Åbner Form inde i panelet i form1// 
            bf.TopLevel = false;
            bf.FormBorderStyle = FormBorderStyle.None;
            bf.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(bf);
            bf.Show();
            
        }

        private void ButtonS_Click(object sender, EventArgs e)
        {
            // Farve skifter på knapper//
            ButtonB.BackColor = Color.FromArgb(35, 31, 80);
            ButtonB.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonS.BackColor = Color.FromArgb(229, 159, 0);
            ButtonS.ForeColor = Color.FromArgb(35, 31, 80);

            ButtonK.BackColor = Color.FromArgb(35, 31, 80);
            ButtonK.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonM.BackColor = Color.FromArgb(35, 31, 80);
            ButtonM.ForeColor = Color.FromArgb(229, 159, 0);
            ef.Hide();
            bf.Hide();
            kf.Hide();
            Lbl_Title.Text = "Sælger";

            //Åbner ny form
            sf.TopLevel = false;
            sf.FormBorderStyle = FormBorderStyle.None;
            sf.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(sf);
            sf.Show();
        }

        private void ButtonK_Click(object sender, EventArgs e)
        {
            // Farve skifter på knapper//
            ButtonB.BackColor = Color.FromArgb(35, 31, 80);
            ButtonB.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonS.BackColor = Color.FromArgb(35, 31, 80);
            ButtonS.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonK.BackColor = Color.FromArgb(229, 159, 0);
            ButtonK.ForeColor = Color.FromArgb(35, 31, 80);

            ButtonM.BackColor = Color.FromArgb(35, 31, 80);
            ButtonM.ForeColor = Color.FromArgb(229, 159, 0);
            ef.Hide();
            bf.Hide();
            sf.Hide();
            Lbl_Title.Text = "Køber";

            //Åbner ny form
            kf.TopLevel = false;
            kf.FormBorderStyle = FormBorderStyle.None;
            kf.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(kf);
            kf.Show();
        }

        private void ButtonM_Click(object sender, EventArgs e)
        {
            // Farve skifter på knapper//
            ButtonB.BackColor = Color.FromArgb(35, 31, 80);
            ButtonB.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonS.BackColor = Color.FromArgb(35, 31, 80);
            ButtonS.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonK.BackColor = Color.FromArgb(35, 31, 80);
            ButtonK.ForeColor = Color.FromArgb(229, 159, 0);

            ButtonM.BackColor = Color.FromArgb(229, 159, 0);
            ButtonM.ForeColor = Color.FromArgb(35, 31, 80);
            bf.Hide();
            sf.Hide();
            kf.Hide();
            Lbl_Title.Text = "Mægler";

            //Åbner ny form
            ef.TopLevel = false;
            ef.FormBorderStyle = FormBorderStyle.None;
            ef.Dock = DockStyle.Fill;
            this.ScreenPnl.Controls.Add(ef);
            ef.Show();
        }
    }
}
