using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zaber;

namespace Zaber
{
    public partial class ZaberControler : Form
    {
        Zaber.GetComPort myZaber = null;
        
        public ZaberControler()
        {
            InitializeComponent();
            buttonRun.Enabled = false;
            buttonHome.Enabled = false;
            buttonEnd.Enabled = false;
            buttonMoveNegative.Enabled = false;
            buttonMovePositive.Enabled = false;

        }



        private void buttonHome_Click(object sender, EventArgs e)
        {
            myZaber.MoveTo(0, 50);

        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            myZaber.MoveTo(300, 50);
        }

        private void buttonMoveNegative_Click(object sender, EventArgs e)
        {
            const double MMPS_TO_SPEED = 825.6504;
            const double MM_TO_POS = 503.9370;

            // Calcualte the speed value and set the speed
            int stage_speed = (int)System.Math.Round(50 * MMPS_TO_SPEED);
            myZaber.SendCMD(42, stage_speed);

            // Calculate the stage position and move the stage

            myZaber.SendCMD(21, -1 * (int)numericUpDownStepSize.Value  *  (int) MM_TO_POS);

        }

        private void buttonMovePositive_Click(object sender, EventArgs e)
        {

            const double MMPS_TO_SPEED = 825.6504;
            const double MM_TO_POS = 503.9370;

            // Calcualte the speed value and set the speed
            int stage_speed = (int)System.Math.Round(50 * MMPS_TO_SPEED);
            myZaber.SendCMD(42, stage_speed);

            // Calculate the stage position and move the stage

            myZaber.SendCMD(21, (int)numericUpDownStepSize.Value * (int)MM_TO_POS);

        }
 

        private void buttonRun_Click(object sender, EventArgs e)
        {
            myZaber.MoveTo((int)numericUpDownStartPosition.Value, (int)numericUpDownStartSpeed.Value);

            double endPosition = (int)numericUpDownStartPosition.Value + (int)numericUpDownScanLength.Value;
            myZaber.MoveTo(endPosition, (int)numericUpDownScanSpeed.Value);
        }

        private void button1GetPort(object sender, EventArgs e)
        {
            labelPort.Text = "";
            myZaber = new Zaber.GetComPort();


            labelPort.Text = myZaber.DeviceFinder();

            buttonRun.Enabled = true;
            buttonHome.Enabled = true;
            buttonEnd.Enabled = true;
            buttonMoveNegative.Enabled = true;
            buttonMovePositive.Enabled = true;
        }
    }
}
