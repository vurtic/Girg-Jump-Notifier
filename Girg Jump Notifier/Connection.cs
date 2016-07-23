using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Girg_Jump_Notifier
{
    class Connection
    {
        private IntPtr _wndHandle;
        private IntPtr _alissaHandle;

        public Connection(IntPtr handle)
        {
            _wndHandle = handle;
        }

        public void Connect()
        {

            var alissaWindows = WinApi.FindAllWindows("mod_Alissa");

            if (alissaWindows.Count == 0)
            {
                //MainFrm.Log("No packet provider found.");
                return;
            }

            _alissaHandle = alissaWindows[0].HWnd;
            SendAlissa(_alissaHandle, 100);
        }

        public void Disconnect()
        {
            SendAlissa(_alissaHandle, 101);
        }

        private void SendAlissa(IntPtr hWnd, int op)
        {
            WinApi.COPYDATASTRUCT cds;
            cds.dwData = (IntPtr)op;
            cds.cbData = 0;
            cds.lpData = IntPtr.Zero;

            var cdsBuffer = Marshal.AllocHGlobal(Marshal.SizeOf(cds));
            Marshal.StructureToPtr(cds, cdsBuffer, false);

            //Dispatcher.Invoke(delegate
            //{
            WinApi.SendMessage(hWnd, WinApi.WM_COPYDATA, _wndHandle, cdsBuffer);
            //});
        }

    }
}
