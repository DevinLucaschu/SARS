﻿using System;
using System.Windows.Forms;

namespace ARC
{
    internal static class Program
    {
        nut
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AvatarSystem());
        }
    }
}