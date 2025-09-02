using System.Runtime.CompilerServices;

namespace Galano_Activity
{
    public partial class Form1 : Form
    {
        double totalfee = 0, ftotalfee = 0;
        double disc = 0;
        double ylf = 0, rcf = 0;

        public Form1()
        {
            InitializeComponent();
            gendercbx1.SelectedIndex = 0;
            yrlvlcbx1.SelectedIndex = 0;
            studtypecbx1.SelectedIndex = 0;
            regclasscbx1.SelectedIndex = 0;
            seminarcbx1.SelectedIndex = 0;
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            //left side
            gendercbx1.SelectedIndex = 0;
            yrlvlcbx1.SelectedIndex = 0;
            studtypecbx1.SelectedIndex = 0;
            regclasscbx1.SelectedIndex = 0;
            seminarcbx1.SelectedIndex = 0;
            nametxtbx1.Clear();
            sntxtbx1.Clear();
            schooltxtbx1.Clear();
            seminartxtbx1.Clear();
            speakertxtbx1.Clear();
            dttxtbx1.Clear();
            placetxtbx1.Clear();
            totaltxtbx.Clear();

            //right side
            gendertxtbx2.Clear();
            yrlvltxtbx2.Clear();
            studtypetxtbx2.Clear();
            regclasstxtbx2.Clear();
            nametxtbx2.Clear();
            sntxtbx2.Clear();
            schooltxtbx2.Clear();
            seminartxtbx2.Clear();
            speakertxtbx2.Clear();
            dttxtbx2.Clear();
            placetxtbx2.Clear();
            totaltxtbx2.Clear();
            paymenttxtbx.Clear();
            changetxtbx.Clear();
            totalfee = 0;
            disc = 0;
            ylf = 0;
            rcf = 0;
            computebtn.Enabled = false;
            othertxtbx.Visible = false;
        }

        private void continuebtn_Click(object sender, EventArgs e)
        {
            //total w/disc
            if (studtypecbx1.SelectedIndex == 1)
            {
                ftotalfee = totalfee;
            }
            else if (studtypecbx1.SelectedIndex == 2)
            {
                disc = totalfee * 0.30;
                ftotalfee = totalfee - disc;
            }
            else if (studtypecbx1.SelectedIndex == 3)
            {
                disc = totalfee * 0.60;
                ftotalfee = totalfee - disc;
            }
            else if (studtypecbx1.SelectedIndex == 4)
            {
                disc = totalfee * 0.80;
                ftotalfee = totalfee - disc;
            }
            else if (studtypecbx1.SelectedIndex == 5)
            {
                disc = totalfee * 0.90;
                ftotalfee = totalfee - disc;
            }

            //handling error inputs
            if (gendercbx1.SelectedIndex == 0 || yrlvlcbx1.SelectedIndex == 0 ||
                studtypecbx1.SelectedIndex == 0 || regclasscbx1.SelectedIndex == 0 || seminarcbx1.SelectedIndex == 0 ||
                nametxtbx1.Text == "" || sntxtbx1.Text == "" || schooltxtbx1.Text == "")
            {
                MessageBox.Show("Incomplete Input", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            //panel color change
            if (studtypecbx1.SelectedIndex == 1)
            {
                this.BackColor = ColorTranslator.FromHtml("#fcfce3");
                summarypanel.BackColor = ColorTranslator.FromHtml("#fcfce3");
            }
            if (studtypecbx1.SelectedIndex == 2)
            {
                this.BackColor = ColorTranslator.FromHtml("#defaf8");
                summarypanel.BackColor = ColorTranslator.FromHtml("#defaf8");
            }
            if (studtypecbx1.SelectedIndex == 3)
            {
                this.BackColor = ColorTranslator.FromHtml("#fae4dc");
                summarypanel.BackColor = ColorTranslator.FromHtml("#fae4dc");
            }
            if (studtypecbx1.SelectedIndex == 4)
            {
                this.BackColor = ColorTranslator.FromHtml("#ffe8f5");
                summarypanel.BackColor = ColorTranslator.FromHtml("#ffe8f5");
            }
            if (studtypecbx1.SelectedIndex == 5)
            {
                this.BackColor = ColorTranslator.FromHtml("#ebdcfc");
                summarypanel.BackColor = ColorTranslator.FromHtml("#ebdcfc");
            }

            //text color change
            if (yrlvlcbx1.SelectedIndex == 1)
            {
                namelbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                namelbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                snlbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                snlbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                schoollbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                schoollbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                seminarlbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                seminarlbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                speakerlbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                speakerlbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                dtlbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                dtlbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                placelbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                placelbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                totallbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                genderlbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                genderlbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                yrlvllbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                yrlvllbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                studtypelbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                studtypelbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                regclasslbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                regclasslbl2.ForeColor = ColorTranslator.FromHtml("#a61403");
                paymentlbl.ForeColor = ColorTranslator.FromHtml("#a61403");
                changelbl.ForeColor = ColorTranslator.FromHtml("#a61403");
            }
            if (yrlvlcbx1.SelectedIndex == 2)
            {
                namelbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                namelbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                snlbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                snlbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                schoollbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                schoollbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                seminarlbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                seminarlbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                speakerlbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                speakerlbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                dtlbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                dtlbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                placelbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                placelbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                totallbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                genderlbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                genderlbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                yrlvllbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                yrlvllbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                studtypelbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                studtypelbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                regclasslbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                regclasslbl2.ForeColor = ColorTranslator.FromHtml("#8ba603");
                paymentlbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
                changelbl.ForeColor = ColorTranslator.FromHtml("#8ba603");
            }
            if (yrlvlcbx1.SelectedIndex == 3)
            {
                namelbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                namelbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                snlbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                snlbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                schoollbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                schoollbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                seminarlbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                seminarlbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                speakerlbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                speakerlbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                dtlbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                dtlbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                placelbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                placelbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                totallbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                genderlbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                genderlbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                yrlvllbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                yrlvllbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                studtypelbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                studtypelbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                regclasslbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                regclasslbl2.ForeColor = ColorTranslator.FromHtml("#032ca6");
                paymentlbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
                changelbl.ForeColor = ColorTranslator.FromHtml("#032ca6");
            }
            if (yrlvlcbx1.SelectedIndex == 4)
            {
                namelbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                namelbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                snlbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                snlbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                schoollbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                schoollbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                seminarlbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                seminarlbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                speakerlbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                speakerlbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                dtlbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                dtlbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                placelbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                placelbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                totallbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                genderlbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                genderlbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                yrlvllbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                yrlvllbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                studtypelbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                studtypelbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                regclasslbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                regclasslbl2.ForeColor = ColorTranslator.FromHtml("#037da6");
                paymentlbl.ForeColor = ColorTranslator.FromHtml("#037da6");
                changelbl.ForeColor = ColorTranslator.FromHtml("#037da6");
            }
            if (yrlvlcbx1.SelectedIndex == 5)
            {
                namelbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                namelbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                snlbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                snlbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                schoollbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                schoollbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                seminarlbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                seminarlbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                speakerlbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                speakerlbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                dtlbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                dtlbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                placelbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                placelbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                totallbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                genderlbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                genderlbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                yrlvllbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                yrlvllbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                studtypelbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                studtypelbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                regclasslbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                regclasslbl2.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                paymentlbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
                changelbl.ForeColor = ColorTranslator.FromHtml("#8f5b01");
            }

            //printing and enabling
            nametxtbx2.Text = (nametxtbx1.Text);
            sntxtbx2.Text = (sntxtbx1.Text);
            schooltxtbx2.Text = (schooltxtbx1.Text);
            if (gendercbx1.SelectedIndex == 4)
            {
                gendertxtbx2.Text = othertxtbx.Text;
            }
            else
            {
                gendertxtbx2.Text = gendercbx1.SelectedItem.ToString();
            }
            yrlvltxtbx2.Text = yrlvlcbx1.SelectedItem.ToString();
            studtypetxtbx2.Text = studtypecbx1.SelectedItem.ToString();
            regclasstxtbx2.Text = regclasscbx1.SelectedItem.ToString();
            seminartxtbx2.Text = (seminartxtbx1.Text);
            speakertxtbx2.Text = (speakertxtbx1.Text);
            placetxtbx2.Text = (placetxtbx1.Text);
            dttxtbx2.Text = (dttxtbx1.Text);
            totaltxtbx2.Text = ftotalfee.ToString();
            computebtn.Enabled = true;
        }

        private void seminarcbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seminarcbx1.SelectedIndex == 1)
            {
                seminartxtbx1.Text = ("Google Glass Project: Better but banned!");
                speakertxtbx1.Text = ("Rosa Parks");
                dttxtbx1.Text = ("June 5, 2022");
                placetxtbx1.Text = ("LCT Building");
            }
            if (seminarcbx1.SelectedIndex == 2)
            {
                seminartxtbx1.Text = ("Future of Communication");
                speakertxtbx1.Text = ("Jerry Hanna");
                dttxtbx1.Text = ("July 16, 2022");
                placetxtbx1.Text = ("LCT Building");
            }
            if (seminarcbx1.SelectedIndex == 3)
            {
                seminartxtbx1.Text = ("Distance Education");
                speakertxtbx1.Text = ("Martha Thompson");
                dttxtbx1.Text = ("August 20, 2022");
                placetxtbx1.Text = ("TYK Building");
            }
            if (seminarcbx1.SelectedIndex == 4)
            {
                seminartxtbx1.Text = ("Importance of Corporate Communications");
                speakertxtbx1.Text = ("Percy Jackson");
                dttxtbx1.Text = ("September 31, 2022");
                placetxtbx1.Text = ("Engineering Building");
            }
            if (seminarcbx1.SelectedIndex == 5)
            {
                seminartxtbx1.Text = ("Child Labor and related issues");
                speakertxtbx1.Text = ("Pedro San Vicente");
                dttxtbx1.Text = ("October 19, 2022");
                placetxtbx1.Text = ("TYK Building");
            }
            if (seminarcbx1.SelectedIndex == 6)
            {
                seminartxtbx1.Text = ("Smart antenna for mobile communication");
                speakertxtbx1.Text = ("Juan Dela Cruz");
                dttxtbx1.Text = ("November 10, 2022");
                placetxtbx1.Text = ("Engineering Building");
            }
            if (seminarcbx1.SelectedIndex == 7)
            {
                seminartxtbx1.Text = ("Low energy efficiency wireless");
                speakertxtbx1.Text = ("Harry Potter");
                dttxtbx1.Text = ("December 9,2022");
                placetxtbx1.Text = ("Engineering Building");
            }
            if (seminarcbx1.SelectedIndex == 8)
            {
                seminartxtbx1.Text = ("Communication network design");
                speakertxtbx1.Text = ("Sheldon Copper");
                dttxtbx1.Text = ("January 7, 2023");
                placetxtbx1.Text = ("TYK Building");
            }
            if (seminarcbx1.SelectedIndex == 9)
            {
                seminartxtbx1.Text = ("Plastic Solar Cell Technology");
                speakertxtbx1.Text = ("Walter White");
                dttxtbx1.Text = ("February 14, 2023");
                placetxtbx1.Text = ("Engineering Building");
            }
        }

        private void regclasscbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //regclass fee
            if (regclasscbx1.SelectedIndex == 1)
            {
                rcf = 150;
            }
            else if (regclasscbx1.SelectedIndex == 2)
            {
                rcf = 130;
            }
            else if (regclasscbx1.SelectedIndex == 3)
            {
                rcf = 100;
            }
            else if (regclasscbx1.SelectedIndex == 4)
            {
                rcf = 200;
            }

            //yrlvl fee
            if (yrlvlcbx1.SelectedIndex == 1)
            {
                ylf = 180;
            }
            else if (yrlvlcbx1.SelectedIndex == 2)
            {
                ylf = 220;
            }
            else if (yrlvlcbx1.SelectedIndex == 3)
            {
                ylf = 280;
            }
            else if (yrlvlcbx1.SelectedIndex == 4)
            {
                ylf = 320;
            }
            else if (yrlvlcbx1.SelectedIndex == 5)
            {
                ylf = 400;
            }

            //calculate initial total
            totalfee = ylf + rcf;
            totaltxtbx.Text = totalfee.ToString();
        }

        private void yrlvlcbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //regclass fee
            if (regclasscbx1.SelectedIndex == 1)
            {
                rcf = 150;
            }
            else if (regclasscbx1.SelectedIndex == 2)
            {
                rcf = 130;
            }
            else if (regclasscbx1.SelectedIndex == 3)
            {
                rcf = 100;
            }
            else if (regclasscbx1.SelectedIndex == 4)
            {
                rcf = 200;
            }

            //yrlvl fee
            if (yrlvlcbx1.SelectedIndex == 1)
            {
                ylf = 180;
            }
            else if (yrlvlcbx1.SelectedIndex == 2)
            {
                ylf = 220;
            }
            else if (yrlvlcbx1.SelectedIndex == 3)
            {
                ylf = 280;
            }
            else if (yrlvlcbx1.SelectedIndex == 4)
            {
                ylf = 320;
            }
            else if (yrlvlcbx1.SelectedIndex == 5)
            {
                ylf = 400;
            }

            //calculate initial total
            totalfee = ylf + rcf;
            totaltxtbx.Text = totalfee.ToString();

        }

        private void computebtn_Click(object sender, EventArgs e)
        {
            //computation
            double payment = 0;
            double change = 0;
            if (paymenttxtbx.Text == "")
            {
                MessageBox.Show("Insufficient Payment", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            payment = Convert.ToDouble(paymenttxtbx.Text);
            if (payment > 0 && payment >= ftotalfee)
            {
                change = payment - ftotalfee;
                changetxtbx.Text = change.ToString();
            }
            else
            {
                MessageBox.Show("Insufficient Payment", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }

        private void gendercbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //other is selected
            if (gendercbx1.SelectedIndex == 4)
            {
                othertxtbx.Visible = true;
            }
        }
    }
}
