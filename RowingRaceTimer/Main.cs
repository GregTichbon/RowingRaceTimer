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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            RegisterHotKey(this.Handle, 1, (int)KeyModifier.None, Keys.F1.GetHashCode());       // Register F1 as global hotkey. 
            RegisterHotKey(this.Handle, 2, (int)KeyModifier.None, Keys.F10.GetHashCode());       // Register F10 as global hotkey. 

        }

        private void Main_Load(object sender, EventArgs e)
        {
       
           
        }

        private void btn_StartTime_Click(object sender, EventArgs e)
        {
            recordstart();
        }

        public void recordstart()
        {
            //Write into database
            dg_starttime.Rows.Add(DateTime.Now.ToString("HH:mm:ss:ffff"));
            tabControl.SelectedIndex = 0;
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            recordend();
        }
        public void recordend()
        {
            //Write into database
            dg_endtime.Rows.Add(DateTime.Now.ToString("HH:mm:ss:ffff"));
            tabControl.SelectedIndex = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Timer.Text = DateTime.Now.ToString("HH:mm:ss:ffff");
        }

        private void btn_MaintToggle_Click(object sender, EventArgs e)
        {
            if(btn_MaintToggle.Text == "Allow Maintenance")
            {
                dg_starttime.AllowUserToAddRows = true;
                dg_starttime.AllowUserToDeleteRows = true;
                dg_starttime.AllowUserToAddRows = true;
                btn_MaintToggle.Text = "Disallow Maintenance";

            } else
            {
                dg_starttime.AllowUserToAddRows = false;
                dg_starttime.AllowUserToDeleteRows = false;
                dg_starttime.AllowUserToAddRows = false;
                btn_MaintToggle.Text = "Allow Maintenance";

            }

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }



        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.


                //MessageBox.Show(modifier + " " + key +      " has been pressed!");
                switch (id)
                {
                    case 1:
                        {
                            recordstart();
                            break;
                        }
                    case 2:
                        {
                            recordend();
                            break;
                        }
                }

            }
        }

        private void ExampleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
        }


    }
}
