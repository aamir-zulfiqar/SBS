using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SBS {

    static class Program {
        [STAThread]
        static void Main() {

            try
            {
                DevExpress.UserSkins.BonusSkins.Register();
                DevExpress.Skins.SkinManager.EnableFormSkins();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                ////Application.Run(new frmMain());
                //Application.Run(new Startup());
                Application.Run(new frmLogin());
                

            }

            catch (Exception ex) 
            {
                //Record error in Log
            }

        }

    }
}
