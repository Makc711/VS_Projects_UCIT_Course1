using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Lab2_2
{
    class CueTextBox : TextBox
    {
        private string _mCue;

        [Localizable(true)]
        public string Cue
        {
            get => _mCue;
            set { _mCue = value; UpdateCue(); }
        }

        private void UpdateCue()
        {
            if (IsHandleCreated && _mCue != null)
            {
                SendMessage(Handle, 0x1501, (IntPtr)1, _mCue);
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            UpdateCue();
        }

        // PInvoke
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, string lp);
    }
}
