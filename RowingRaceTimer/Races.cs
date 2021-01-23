using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowingRaceTimer
{
    public partial class Races : Form
    {
        public Races()
        {
            InitializeComponent();
        }

        private void Races_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rowingRaceTimerDataSet2.Race' table. You can move, or remove it, as needed.
            this.raceTableAdapter.Fill(this.rowingRaceTimerDataSet2.Race);

        }

        private void raceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
