﻿using ESAPIX.AppKit.Splash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ESAPIX.AppKit.Splash
{
    /// <summary>
    /// Contains methods to help with the splash screen
    /// </summary>
    public class Splasher
    {
        /// <summary>
        /// Provides a quick method for the constructor of the ScriptBootstrapper, or AppBootstrapper classes which take a Func of return type window
        /// </summary>
        /// <returns>the splash screen to show</returns>
        public static Window GetSplash()
        {
                var calling = Assembly.GetExecutingAssembly();
                var name = calling.GetName().Name;
                var version = calling.GetName().Version;
                var label = string.Format("{0} {1}", name, version);
                var s = new SplashScreen(label);
                return s;
        }
    }
}
