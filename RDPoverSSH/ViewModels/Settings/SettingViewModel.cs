﻿using System;
using System.Linq;
using RDPoverSSH.DataStore;
using RDPoverSSH.Models;

namespace RDPoverSSH.ViewModels.Settings
{
    /// <summary>
    /// The UI representation of a Setting
    /// </summary>
    public abstract class SettingViewModelBase : MyObservableObject
    {
        #region Public properties

        /// <summary>
        /// A user-translated representation of the setting name
        /// </summary>
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private string _name;

        /// <summary>
        /// A user-translated representation of the category. Use identical categories to group settings.
        /// </summary>
        public string Category
        {
            get => _category;
            set => SetProperty(ref _category, value);
        }
        private string _category;

        /// <summary>
        /// A user-translated description of the setting (tooltip)
        /// </summary>
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }
        private string _description;

        public abstract bool IsBinary { get; }

        #endregion
    }

    /// <inheritdoc/>
    public class SettingViewModel<T> : SettingViewModelBase
    {
        #region Constructor

        public SettingViewModel(Guid settingModelGuid, string category, string name, T defaultValue, string description = default)
        {
            _model = DatabaseEngine.GetCollection<SettingModel>().Find(setting => setting.Guid == settingModelGuid).FirstOrDefault() ?? new SettingModel {Guid = settingModelGuid};
            Name = name;
            Category = category;
            Description = description;
            _defaultValue = defaultValue;
        }

        #endregion

        #region SettingViewModelBase members

        public override bool IsBinary => typeof(bool).IsAssignableFrom(typeof(T));

        #endregion

        #region Public properties

        public T Value
        {
            get
            {
                try
                {
                    return (T)Convert.ChangeType(_model.Value, typeof(T));
                }
                catch
                {
                    return _defaultValue;
                }
            }
            set
            {
                _model.Value = value.ToString();
                DatabaseEngine.GetCollection<SettingModel>().Upsert(_model);
                OnPropertyChanged(nameof(Value));
            }
        }

        #endregion

        #region Private fields

        private readonly SettingModel _model;
        private readonly T _defaultValue;

        #endregion
    }
}
