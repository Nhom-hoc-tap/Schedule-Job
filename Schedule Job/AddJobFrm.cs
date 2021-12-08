using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Job
{
    public partial class AddJobFrm : Form
    {
        public AddJobFrm()
        {
            InitializeComponent();
        }

        private void btnThemLoaiCV_Click(object sender, EventArgs e)
        {
            AddTypeofJobFrm addtypeFrm = new AddTypeofJobFrm();
            addtypeFrm.Show();
        }

        private void AddJobFrm_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void AddJobFrm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private Job GetJob()
        {
            return new Job()
            {

            };
        }
    }
}
