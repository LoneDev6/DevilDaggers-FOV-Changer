using Binarysharp.MemoryManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevilDaggers_FOV_Changer
{
    public partial class Form1 : Form
    {
        private string text_ddRunning = "DD is running";
        private string text_ddNotRunning = "DD NOT running";


        private MemorySharp m;
        private Process dd;

        private static int OFFSET_FOV = 0x14C;
        private int pFov = -1;

        public Form1()
        {
            InitializeComponent();
            initMemory();
            if (isDDRunning())
                numericUpDown_fov.Value = m.Read<int>(new IntPtr(pFov + OFFSET_FOV), false);

            numericUpDown_fov.Enabled = isDDRunning();

        }

        private bool isDDRunning() 
        {
            return dd != default(Process);
        }

        private void initMemory()
        {
            dd = findProcess("dd");
            if (dd == null) return;
            m = new MemorySharp(dd);

            if (pFov == -1)
                pFov = m.Read<int>(new IntPtr(0x1F4AA0), true);
        }

        /// <summary>
        /// Locates a process.
        /// </summary>
        /// <param name="ProcessName"></param>
        /// <returns></returns>
        private Process findProcess(String processName)
        {
            return Process.GetProcessesByName(processName).FirstOrDefault();
        }

        private void numericUpDown_fov_ValueChanged(object sender, EventArgs e)
        {
            if (!isDDRunning()) return;
            m.Write<int>(new IntPtr(pFov + 0x14C), (int)((NumericUpDown)sender).Value, false);
        }

        private void timer_ddRunning_Tick(object sender, EventArgs e)
        {
            initMemory();
            label_ddOpened.Text = isDDRunning() ? text_ddRunning : text_ddNotRunning;
        }

    }
}
