﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDisplay
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            AppDomain root = AppDomain.CurrentDomain;
            var aData = root.SetupInformation.ActivationArguments?.ActivationData;
            if (aData == null)
                aData = args;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(aData));
        }
    }
}
