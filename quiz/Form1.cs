using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class frmhome : Form
    {
        public int resTrue;
        public int resFalse;
        public int clicks = 0;
        public int counter = 20;

        public frmhome()
        {
            InitializeComponent();
            InitialConfig();
        }

        public void InitialConfig()
        {
            lbltimer.Visible = false;
            questionpic2.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            btnstart.FlatAppearance.BorderSize = 0;
            btnexit.FlatAppearance.BorderSize = 0;
            btninfo.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnfalse1.FlatAppearance.BorderSize = 0;
            btntrue1.FlatAppearance.BorderSize = 0;
            btntrue2.FlatAppearance.BorderSize = 0;
            btnfalse2.FlatAppearance.BorderSize = 0;
            btntrue3.FlatAppearance.BorderSize = 0;
            btnfalse3.FlatAppearance.BorderSize = 0;
            btnresult.FlatAppearance.BorderSize = 0;
            btnresult.FlatAppearance.BorderSize = 0;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btntrue1_Click(object sender, EventArgs e)
        {
            clicks++;
            resTrue++;
            btntrue1.Enabled = false;
            btnfalse1.Enabled = false;
        }

        private void btnfalse2_Click(object sender, EventArgs e)
        {
            clicks++;
            resTrue++;
            btnfalse2.Enabled = false;
            btntrue2.Enabled = false;
        }

        private void btnfalse1_Click(object sender, EventArgs e)
        {
            clicks++;
            resFalse++;
            btntrue1.Enabled = false;
            btnfalse1.Enabled = false;
        }

        private void btntrue2_Click(object sender, EventArgs e)
        {
            clicks++;
            resFalse++;
            btntrue2.Enabled = false;
            btnfalse2.Enabled = false;
        }

        private void btntrue3_Click(object sender, EventArgs e)
        {
            clicks++;
            resTrue++;
            btntrue3.Enabled = false;
            btnfalse3.Enabled = false;

        }

        private void btnfalse3_Click(object sender, EventArgs e)
        {
            clicks++;
            resFalse++;
            btnfalse3.Enabled = false;
            btntrue3.Enabled = false;
        }

        private void btnresult_Click(object sender, EventArgs e)
        {
            lblcert.Visible = true;
            lblerr.Visible = true;
            lblcountfalse.Visible = true;
            lblcounttrue.Visible = true;
            resultpanel.Visible = true;

            lblcounttrue.Text = Convert.ToString(resTrue);
            lblcountfalse.Text = Convert.ToString(resFalse);
            btnresult.Enabled = false;

        }

        private void photostimer_Tick(object sender, EventArgs e)
        {
            if (questionpic1.Visible == true)
            {
                questionpic1.Visible = false;
                questionpic2.Visible = true;
            }else if(questionpic2.Visible == true){
                questionpic2.Visible = false;
                questionpic1.Visible = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            timer.Stop();
            lbltimer.Text = counter.ToString();

            if (counter == 0)
            {
                btnfalse1.Enabled = false;
                btntrue1.Enabled = false;
                btntrue2.Enabled = false;
                btnfalse2.Enabled = false;
                btntrue3.Enabled = false;
                btnfalse3.Enabled = false;
                btnresult.Enabled = true;

                btnresult.Visible = true;

            }

            if (clicks == 3)
            {
                timer.Stop();
                btnresult.Visible = true;
            }

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            lbltimer.Visible = true;
            resTrue = 0;
            resFalse = 0;

            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = 1000;
            timer.Start();
            lbltimer.Text = counter.ToString();

            questionpic1.Visible = true;

            btnstart.Enabled = false;
            btnfalse1.Enabled = true;
            btntrue1.Enabled = true;
            btntrue2.Enabled = true;
            btnfalse2.Enabled = true;
            btntrue3.Enabled = true;
            btnfalse3.Enabled = true;
            btnresult.Enabled = true;
        }

        private void btnexit_MouseMove(object sender, MouseEventArgs e)
        {
            sidepanel.Top = btnexit.Top;
        }

        private void btninfo_MouseMove(object sender, MouseEventArgs e)
        {
            sidepanel.Top = btninfo.Top;
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            frmabout fbo = new frmabout();
            fbo.ShowDialog();
        }
    }
}
