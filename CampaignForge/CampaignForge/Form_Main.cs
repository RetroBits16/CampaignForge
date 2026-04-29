using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampaignForge
{
    public partial class Form_Main : Form
    {
        private UserControl _currentControl;
        public Form_Main()
        {
            InitializeComponent();
            ShowControl(new UserControl_Campaign());
        }

        private void ShowControl(UserControl control)
        {
            if (_currentControl != null)
            {
                Box_Main.Controls.Remove(_currentControl);
                _currentControl.Dispose();
            }

            control.Dock = DockStyle.Fill;
            Box_Main.Controls.Add(control);
            _currentControl = control;
        }

        private void btt_Campaign_Click(object sender, EventArgs e)
        {
            ShowControl(new UserControl_Campaign());
        }

        private void btt_System_Click(object sender, EventArgs e)
        {
            ShowControl(new UserControl_System());
        }
    }
}
