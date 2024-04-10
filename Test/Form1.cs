using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class frmDragon : Form
    {
        string playerName;
        string DragonName;

        public frmDragon()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            playerName = txtPlayerName.Text;
            DragonName = txtDragon.Text;

            rtbOut.Text = "Player Name: " + playerName + 
                "\nDragon Name: " + DragonName;
        }
    }
}
