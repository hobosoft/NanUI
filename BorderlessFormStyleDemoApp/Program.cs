﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chromium.Remote;
using NetDimension.NanUI;

namespace BorderlessFormStyleDemoApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");

            if (Bootstrap.Load(settings=> {
                settings.LogSeverity = Chromium.CfxLogSeverity.Disable;
            }))
            {
                //Register html/css/javascript/image resources in current executing assembly. 
                //If you want to embed any kind of resource in your app, just add it to your project and set the Build Action to Embedded Resource.
                //System.Reflection.Assembly.GetExecutingAssembly();
                Bootstrap.RegisterAssemblyResources(System.Reflection.Assembly.GetExecutingAssembly(), "assets");
                Bootstrap.RegisterFolderResources(Application.StartupPath);
                
                Application.Run(new Form1());
            }

        }
    }
}
