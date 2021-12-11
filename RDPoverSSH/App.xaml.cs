﻿using System;
using System.Linq;
using System.Windows;
using System.Windows.Threading;
using CommandLine;
using RDPoverSSH.Arguments;
using RDPoverSSH.Common;
using RDPoverSSH.Controls;

namespace RDPoverSSH
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <inheritdoc/>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            if (e.Args.Any())
            {
                HasArgs = true;
                ParsedArgs = Parser.Default.ParseArguments<ShowMessageArgument, SaveKeyArgument, DeleteUserArgument>(e.Args);

                // Handle some args here, without ever going to the UI
                ParsedArgs.WithParsed<DeleteUserArgument>(arg =>
                {
                    UserUtils.DeleteWindowsUser(arg.Username);
                    Environment.Exit(0);
                });
            }

            // Handle global exceptions
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        public static bool HasArgs { get; private set; }

        public static ParserResult<object> ParsedArgs { get; private set; }

        private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            Dispatcher.Invoke(async () => await MessageBoxHelper.ShowCopyableText(RDPoverSSH.Properties.Resources.UnexpectedError, RDPoverSSH.Properties.Resources.Error, e.Exception.ToString()));

            // Don't kill the app
            e.Handled = true;
        }
    }
}
