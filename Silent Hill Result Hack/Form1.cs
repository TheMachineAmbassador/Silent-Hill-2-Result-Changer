using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Silent_Hill_Result_Hack.MemoryHackyThings;

namespace Silent_Hill_Result_Hack
{
    public partial class frm_firstOpen : Form
    {
        public frm_firstOpen()
        {
            InitializeComponent();
        }

        private void btn_StartHack_Click(object sender, EventArgs e)
        {

            if (BusinessThing.ReadMenuSwitch!=4 && BusinessThing.ReadMenuSwitch!=11 )
            {
                lbl_Status.Visible = true;
                lbl_Status.Text = "Please start game and try again";
            }
            else
            {
                BusinessThing.ReadMenuSwitch = 10;

                HackOpen hackOpen = new HackOpen();
                hackOpen.Show();
                this.Hide();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_firstOpen_Load(object sender, EventArgs e)
        {
            if(!BusinessThing.cheatActive())
            {
                MessageBox.Show("Plese Start Game and Open Program Again","Program can't found");
                this.Close();
            }
        }
    }
}
