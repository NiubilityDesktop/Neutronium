﻿using System;
using Chromium;

namespace ChromiumFXRenderProcess 
{
    static class Program 
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            CfxRuntime.LibCefDirPath = @"cef\Release";
            int retval = CfxRuntime.ExecuteProcess();
            Environment.Exit(retval);
        }
    }
}
