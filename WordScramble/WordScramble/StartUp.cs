using System;
using System.Windows.Forms;

namespace Word_Scramble
{
    internal static class StartUp
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new IndexForm());
        }
    }
}