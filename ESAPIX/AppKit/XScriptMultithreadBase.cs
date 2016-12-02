﻿using ESAPIX.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using VMS.TPS.Common.Model.API;

namespace ESAPIX.AppKit
{
    public abstract class XScriptMultithreadBase
    {
        public void Execute(ScriptContext context, Window window)
        {
            //Get this window barely visible so that when it does show, it isn't ugly ;)
            window.Height = window.Width = 0;
            window.WindowStyle = WindowStyle.None;
            window.Hide();
            window.Loaded += Window_Loaded;

            var plugCtx = new PluginContext(context, window);
            DispatcherFrame frame = new DispatcherFrame();
            XExecute(plugCtx, frame);
            Dispatcher.PushFrame(frame);
        }

        #region WINDOW PLUMBING
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var win = sender as Window;
            win.Loaded += Window_Loaded;
            win.Close();
        }
        #endregion

        public abstract void XExecute(PluginContext ctx, DispatcherFrame frame);
    }
}
