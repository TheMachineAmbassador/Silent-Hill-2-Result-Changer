using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Silent_Hill_Result_Hack.MemoryHackyThings;
namespace Silent_Hill_Result_Hack
{
    public partial class HackOpen : Form
    {
        string[] clocks = FuncsForCalc.TimeCalc(BusinessThing.TotalTime);
        string[] clockForBoatStageTime = FuncsForCalc.TimeCalc(BusinessThing.BoatStageTime);

        int EndingIndex = FuncsForCalc.EndingCalculation(BusinessThing.EndingType, BusinessThing.UFOEnding);

        public HackOpen()
        {
            InitializeComponent();
        }

        private void HackOpen_Load(object sender, EventArgs e)
        {
            cmb_ActionLevel.DataSource = new BindingSource(BusinessThing.d_actionLevel, null);
            cmb_ActionLevel.DisplayMember = "Value";
            cmb_ActionLevel.SelectedIndex = BusinessThing.ActionLevel;

            cmb_RiddleLevel.DataSource = new BindingSource(BusinessThing.d_riddleLevel,null);
            cmb_RiddleLevel.DisplayMember = "Value";
            cmb_RiddleLevel.SelectedIndex = BusinessThing.RiddleLevel;

            cmb_EndingType.DataSource = new BindingSource(BusinessThing.d_endingType,null);
            cmb_EndingType.DisplayMember = "Value";
            cmb_EndingType.SelectedIndex = EndingIndex;

            cmb_EndOfClear.DataSource = new BindingSource(BusinessThing.d_endingClear, null);
            cmb_EndOfClear.DisplayMember = "Value";
            cmb_EndOfClear.SelectedIndex = BusinessThing.d_endingClear.Keys.ToList().IndexOf(BusinessThing.EndingClear);

            cmb_ItemsPlus.DataSource = new BindingSource(BusinessThing.d_ItemPlus, null);
            cmb_ItemsPlus.DisplayMember = "Value";
            cmb_ItemsPlus.SelectedIndex = FuncsForCalc.GetItemsPlus(BusinessThing.EndOfResultItemsPlus);


            tbx_Saves.Text = BusinessThing.Saves.ToString();
            tbx_TotalTime.Text = BusinessThing.TotalTime.ToString();
            tbx_BoatStageTime.Text = BusinessThing.BoatStageTime.ToString();
            tbx_WalkingDistance.Text = FuncsForCalc.CalcDistance(BusinessThing.WalkingDistance).ToString("0.00");
            tbx_RunningDistance.Text = FuncsForCalc.CalcDistance(BusinessThing.RunningDistance).ToString("0.00");
            tbx_Items.Text = BusinessThing.EndOfResultItems.ToString();
            tbxDefeatedByShooting.Text = BusinessThing.DefeatedEnemyByShooting.ToString();
            tbx_DefeatedByFighting.Text = BusinessThing.DefeatedEnemyByFighting.ToString();
            tbx_BoatMaxSpeed.Text = BusinessThing.BoatMaxSpeed.ToString("0.00");
            tbx_TotalDamage.Text = BusinessThing.TotalDamage.ToString();

            lbl_Time.Text = string.Format("{0}:{1}:{2}", clocks[0], clocks[1], clocks[1]);
            lbl_BoatTimeShow.Text = string.Format("{0}:{1}:{2}", clockForBoatStageTime[0], clockForBoatStageTime[1], clockForBoatStageTime[2]);
        }

        private void HackOpen_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessThing.ActionLevel = cmb_ActionLevel.SelectedIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            BusinessThing.SaveChanges = 3;
            Application.Exit();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            BusinessThing.ReadMenuSwitch = 1;
            Application.Exit();
        }

        private void btn_ChangeRiddleLevel_Click(object sender, EventArgs e)
        {
            BusinessThing.RiddleLevel = cmb_RiddleLevel.SelectedIndex;
        }

        private void btn_EndingType_Click(object sender, EventArgs e)
        {
            FuncsForCalc.SetEndingByIndex(cmb_EndingType.SelectedIndex);
        }

        private void btn_EndingClear_Click(object sender, EventArgs e)
        {
            BusinessThing.EndingClear = BusinessThing.d_endingClear.ElementAt(cmb_EndOfClear.SelectedIndex).Key;
        }

        private void btn_Saves_Click(object sender, EventArgs e)
        {
            BusinessThing.Saves = Convert.ToInt32(tbx_Saves.Text);
        }

        private void btn_TotalTime_Click(object sender, EventArgs e)
        {
            BusinessThing.TotalTime = (float)Convert.ToDouble(tbx_TotalTime.Text);
            
            clocks = FuncsForCalc.TimeCalc(BusinessThing.TotalTime);
            lbl_Time.Text = string.Format("{0}:{1}:{2}", clocks[0], clocks[1], clocks[2]);
        }

        private void btn_WalkingDistance_Click(object sender, EventArgs e)
        {
            BusinessThing.WalkingDistance = FuncsForCalc.ReverseCalcDistance((float)Convert.ToDouble(tbx_WalkingDistance.Text));
        }

        private void btn_RunningDistance_Click(object sender, EventArgs e)
        {
            BusinessThing.RunningDistance = FuncsForCalc.ReverseCalcDistance((float)Convert.ToDouble(tbx_RunningDistance.Text));
        }

        private void btn_Items_Click(object sender, EventArgs e)
        {
            BusinessThing.EndOfResultItems = Convert.ToInt16(tbx_Items.Text);
        }

        private void btn_ItemsPlus_Click(object sender, EventArgs e)
        {
            FuncsForCalc.setItemPlus(Convert.ToByte(cmb_ItemsPlus.SelectedIndex));
        }

        private void btnDefeatedByShooting_Click(object sender, EventArgs e)
        {
            BusinessThing.DefeatedEnemyByShooting = Convert.ToInt16(tbxDefeatedByShooting.Text);
        }

        private void btn_DefeatedByFighting_Click(object sender, EventArgs e)
        {
            BusinessThing.DefeatedEnemyByFighting = Convert.ToInt16(tbx_DefeatedByFighting.Text);
        }

        private void btn_BoatStageTime_Click(object sender, EventArgs e)
        {
            BusinessThing.BoatStageTime = (float)Convert.ToDouble(tbx_BoatStageTime.Text);

            clockForBoatStageTime = FuncsForCalc.TimeCalc(BusinessThing.BoatStageTime);
            lbl_BoatTimeShow.Text = string.Format("{0}:{1}:{2}", clockForBoatStageTime[0], clockForBoatStageTime[1], clockForBoatStageTime[2]);
        }

        private void btn_BoatMaxSpeed_Click(object sender, EventArgs e)
        {
            BusinessThing.BoatMaxSpeed = (float)Convert.ToDouble(tbx_BoatMaxSpeed.Text);
        }

        private void btn_TotalDamage_Click(object sender, EventArgs e)
        {
            BusinessThing.TotalDamage = (float)Convert.ToDouble(tbx_TotalDamage.Text);
        }
    }
}
