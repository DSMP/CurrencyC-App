﻿using CurrencyAppShared.Models;
using CurrencyAppShared.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyAppNative.ViewModels
{
    class CurrencyHistoryViewModel : ViewModelBase
    {
        Currency _selectedCurrency;
        public Currency SelectedCurrency { get { return _selectedCurrency; } set { SetProperty(ref _selectedCurrency, value); localsettings.Values["selected_currency"] = _xMLParser.ObjToXML<Currency>(value); } }
        string _header;
        public string Header { get { return _header == null ? "Historia kursu " + _selectedCurrency.Name : _header; } set { SetProperty(ref _header, value); } }
        DateTime _dateTimeStart;
        public DateTime DateTimeStart { get { return _dateTimeStart; } set { SetProperty(ref _dateTimeStart, value); } }
        DateTime _dateTimeFinish;
        public DateTime DateTimeFinish { get { return _dateTimeFinish; } set { SetProperty(ref _dateTimeFinish, value); } }
        double _progress;
        public double Progress { get { return _progress; } set { SetProperty(ref _progress, value); } }
        Windows.Storage.StorageFolder localFolder;
        Windows.Storage.ApplicationDataContainer localsettings;
        IXMLParser _xMLParser;

        public CurrencyHistoryViewModel()
        {
            localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            localsettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            _xMLParser = new XMLParser();
            localsettings.Values["page"] = 2;
            if (localsettings.Values["selected_currency"] == null)
            {
                _selectedCurrency = new Currency { Name = "undifined", Code = "DSMP" };
            }
            else
            {
                Debug.WriteLine((string)localsettings.Values["selected_currency"]);
                var obj = _xMLParser.DeserializeXMLFileToObject<Currency>((string)localsettings.Values["selected_currency"]);
                SelectedCurrency = obj;
            }
        }
    }
}
