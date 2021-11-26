﻿using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using RDPoverSSH.DataStore;
using RDPoverSSH.Models;
using RDPoverSSH.Properties;

namespace RDPoverSSH.ViewModels
{
    /// <summary>
    /// Command that creates a new connection
    /// </summary>
    public class NewConnectionCommandViewModel : CommandViewModelBase
    {
        #region CommandViewModelBase members

        /// <inheritdoc/>
        public override string Name => Resources.NewConnection;

        /// <inheritdoc/>
        public override ICommand Command => _command ??= new RelayCommand(NewConnectionCommand);
        private RelayCommand _command;

        /// <inheritdoc/>
        public override string IconGlyph => "\xECC8";

        #endregion

        #region Commands

        private void NewConnectionCommand()
        {
            ConnectionModel connectionModel = new ConnectionModel();
            RootModel.Instance.Connections.Add(connectionModel);
            DatabaseEngine.ConnectionCollection.Insert(connectionModel);
        }

        #endregion
    }
}
