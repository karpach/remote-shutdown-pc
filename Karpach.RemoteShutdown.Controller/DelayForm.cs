using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karpach.RemoteShutdown.Controller.Interfaces;
using Karpach.RemoteShutdown.Controller.Properties;

namespace Karpach.RemoteShutdown.Controller
{
    public partial class DelayForm : Form, IDelayForm
    {
        private readonly ITrayCommandHelper _trayCommandHelper;
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TrayCommandType CommandType { get; set; }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Delay { get; set; }

        public DelayForm(ITrayCommandHelper trayCommandHelper)
        {
            _trayCommandHelper = trayCommandHelper;

            InitializeComponent();
        }

        protected async override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            BringToForeground();

            for(int i = Delay; i > 0; i--)
            {
                labelDelay.Text = $"Operation '{_trayCommandHelper.GetText(CommandType)}' is delayed for {i} seconds.";

                await Task.Delay(1000);
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// The form is shown from a background (HTTP) thread, so Windows' foreground lock
        /// prevents it from being activated normally. Force it to the top of the z-order
        /// and temporarily attach to the foreground thread's input to grab focus.
        /// </summary>
        private void BringToForeground()
        {
            TopMost = true;

            IntPtr foregroundWindow = GetForegroundWindow();
            uint foregroundThread = GetWindowThreadProcessId(foregroundWindow, IntPtr.Zero);
            uint currentThread = GetCurrentThreadId();
            bool attached = foregroundThread != currentThread && AttachThreadInput(currentThread, foregroundThread, true);
            try
            {
                SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
                SetForegroundWindow(Handle);
                Activate();
                btnAbort.Focus();
            }
            finally
            {
                if (attached)
                {
                    AttachThreadInput(currentThread, foregroundThread, false);
                }
            }
        }

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint SWP_SHOWWINDOW = 0x0040;

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr lpdwProcessId);

        [DllImport("kernel32.dll")]
        private static extern uint GetCurrentThreadId();

        [DllImport("user32.dll")]
        private static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint uFlags);
    }
}

