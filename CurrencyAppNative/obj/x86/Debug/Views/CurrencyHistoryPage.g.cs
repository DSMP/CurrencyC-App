﻿#pragma checksum "C:\GitProjects\CurrencyAppNative\CurrencyAppNative\Views\CurrencyHistoryPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "19E03751C0FAAD013DA541A24BAE44B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CurrencyAppNative.Views
{
    partial class CurrencyHistoryPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Hub_Header(global::Windows.UI.Xaml.Controls.Hub obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Header = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Value = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Maximum(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Maximum = value;
            }
            public static void Set_Syncfusion_UI_Xaml_Charts_ChartBase_Header(global::Syncfusion.UI.Xaml.Charts.ChartBase obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Header = value;
            }
            public static void Set_Syncfusion_UI_Xaml_Charts_ChartSeriesBase_ItemsSource(global::Syncfusion.UI.Xaml.Charts.ChartSeriesBase obj, global::System.Collections.IEnumerable value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.IEnumerable) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.IEnumerable), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_DatePicker_Date(global::Windows.UI.Xaml.Controls.DatePicker obj, global::System.DateTimeOffset value)
            {
                obj.Date = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_DatePicker_Header(global::Windows.UI.Xaml.Controls.DatePicker obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Header = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CurrencyHistoryPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICurrencyHistoryPage_Bindings
        {
            private global::CurrencyAppNative.Views.CurrencyHistoryPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Hub obj4;
            private global::Windows.UI.Xaml.Controls.ProgressBar obj5;
            private global::Syncfusion.UI.Xaml.Charts.SfChart obj6;
            private global::Syncfusion.UI.Xaml.Charts.FastLineBitmapSeries obj7;
            private global::Windows.UI.Xaml.Controls.DatePicker obj8;
            private global::Windows.UI.Xaml.Controls.DatePicker obj9;

            private CurrencyHistoryPage_obj1_BindingsTracking bindingsTracking;

            public CurrencyHistoryPage_obj1_Bindings()
            {
                this.bindingsTracking = new CurrencyHistoryPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 4: // Views\CurrencyHistoryPage.xaml line 16
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Hub)target;
                        break;
                    case 5: // Views\CurrencyHistoryPage.xaml line 21
                        this.obj5 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
                        (this.obj5).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.ValueProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.Progress = this.obj5.Value;
                            }
                        });
                        (this.obj5).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.RangeBase.MaximumProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.MaxValue = this.obj5.Maximum;
                            }
                        });
                        break;
                    case 6: // Views\CurrencyHistoryPage.xaml line 22
                        this.obj6 = (global::Syncfusion.UI.Xaml.Charts.SfChart)target;
                        break;
                    case 7: // Views\CurrencyHistoryPage.xaml line 44
                        this.obj7 = (global::Syncfusion.UI.Xaml.Charts.FastLineBitmapSeries)target;
                        (this.obj7).RegisterPropertyChangedCallback(global::Syncfusion.UI.Xaml.Charts.ChartSeriesBase.ItemsSourceProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.Currencies = (global::System.Collections.ObjectModel.ObservableCollection<global::CurrencyAppShared.Models.Currency>)this.obj7.ItemsSource;
                            }
                        });
                        break;
                    case 8: // Views\CurrencyHistoryPage.xaml line 18
                        this.obj8 = (global::Windows.UI.Xaml.Controls.DatePicker)target;
                        (this.obj8).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.DatePicker.DateProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.DateTimeStart = this.obj8.Date;
                            }
                        });
                        break;
                    case 9: // Views\CurrencyHistoryPage.xaml line 19
                        this.obj9 = (global::Windows.UI.Xaml.Controls.DatePicker)target;
                        (this.obj9).RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.DatePicker.DateProperty,
                            (global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop) =>
                            {
                            if (this.initialized)
                            {
                                // Update Two Way binding
                                this.dataRoot.ViewModel.DateTimeFinish = this.obj9.Date;
                            }
                        });
                        break;
                    default:
                        break;
                }
            }

            // ICurrencyHistoryPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::CurrencyAppNative.Views.CurrencyHistoryPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::CurrencyAppNative.Views.CurrencyHistoryPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel(obj.ViewModel, phase);
                    }
                }
            }
            private void Update_ViewModel(global::CurrencyAppNative.ViewModels.CurrencyHistoryViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Header(obj.Header, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Progress(obj.Progress, phase);
                        this.Update_ViewModel_MaxValue(obj.MaxValue, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_SelectedCurrency(obj.SelectedCurrency, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_Currencies(obj.Currencies, phase);
                        this.Update_ViewModel_DateTimeStart(obj.DateTimeStart, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_HeaderFirst(obj.HeaderFirst, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_DateTimeFinish(obj.DateTimeFinish, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_HeaderLast(obj.HeaderLast, phase);
                    }
                }
            }
            private void Update_ViewModel_Header(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 16
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Hub_Header(this.obj4, obj, null);
                }
            }
            private void Update_ViewModel_Progress(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 21
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj5, obj);
                }
            }
            private void Update_ViewModel_MaxValue(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 21
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Maximum(this.obj5, obj);
                }
            }
            private void Update_ViewModel_SelectedCurrency(global::CurrencyAppShared.Models.Currency obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ViewModel_SelectedCurrency_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_ViewModel_SelectedCurrency_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 22
                    XamlBindingSetters.Set_Syncfusion_UI_Xaml_Charts_ChartBase_Header(this.obj6, obj, null);
                }
            }
            private void Update_ViewModel_Currencies(global::System.Collections.ObjectModel.ObservableCollection<global::CurrencyAppShared.Models.Currency> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_ViewModel_Currencies(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 44
                    XamlBindingSetters.Set_Syncfusion_UI_Xaml_Charts_ChartSeriesBase_ItemsSource(this.obj7, obj, null);
                }
            }
            private void Update_ViewModel_DateTimeStart(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 18
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_DatePicker_Date(this.obj8, obj);
                }
            }
            private void Update_ViewModel_HeaderFirst(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 18
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_DatePicker_Header(this.obj8, obj, null);
                }
            }
            private void Update_ViewModel_DateTimeFinish(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 19
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_DatePicker_Date(this.obj9, obj);
                }
            }
            private void Update_ViewModel_HeaderLast(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 19
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_DatePicker_Header(this.obj9, obj, null);
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CurrencyHistoryPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<CurrencyHistoryPage_obj1_Bindings> weakRefToBindingObj; 

                public CurrencyHistoryPage_obj1_BindingsTracking(CurrencyHistoryPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CurrencyHistoryPage_obj1_Bindings>(obj);
                }

                public CurrencyHistoryPage_obj1_Bindings TryGetBindingObject()
                {
                    CurrencyHistoryPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_ViewModel(null);
                    UpdateChildListeners_ViewModel_Currencies(null);
                }

                public void PropertyChanged_ViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CurrencyHistoryPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::CurrencyAppNative.ViewModels.CurrencyHistoryViewModel obj = sender as global::CurrencyAppNative.ViewModels.CurrencyHistoryViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_ViewModel_Progress(obj.Progress, DATA_CHANGED);
                                bindings.Update_ViewModel_MaxValue(obj.MaxValue, DATA_CHANGED);
                                bindings.Update_ViewModel_Currencies(obj.Currencies, DATA_CHANGED);
                                bindings.Update_ViewModel_DateTimeStart(obj.DateTimeStart, DATA_CHANGED);
                                bindings.Update_ViewModel_DateTimeFinish(obj.DateTimeFinish, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Progress":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Progress(obj.Progress, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "MaxValue":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_MaxValue(obj.MaxValue, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Currencies":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_Currencies(obj.Currencies, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "DateTimeStart":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_DateTimeStart(obj.DateTimeStart, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "DateTimeFinish":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_ViewModel_DateTimeFinish(obj.DateTimeFinish, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::CurrencyAppNative.ViewModels.CurrencyHistoryViewModel cache_ViewModel = null;
                public void UpdateChildListeners_ViewModel(global::CurrencyAppNative.ViewModels.CurrencyHistoryViewModel obj)
                {
                    if (obj != cache_ViewModel)
                    {
                        if (cache_ViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel).PropertyChanged -= PropertyChanged_ViewModel;
                            cache_ViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel;
                        }
                    }
                }
                public void PropertyChanged_ViewModel_Currencies(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CurrencyHistoryPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::CurrencyAppShared.Models.Currency> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::CurrencyAppShared.Models.Currency>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_ViewModel_Currencies(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    CurrencyHistoryPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::CurrencyAppShared.Models.Currency> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::CurrencyAppShared.Models.Currency>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::CurrencyAppShared.Models.Currency> cache_ViewModel_Currencies = null;
                public void UpdateChildListeners_ViewModel_Currencies(global::System.Collections.ObjectModel.ObservableCollection<global::CurrencyAppShared.Models.Currency> obj)
                {
                    if (obj != cache_ViewModel_Currencies)
                    {
                        if (cache_ViewModel_Currencies != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_ViewModel_Currencies).PropertyChanged -= PropertyChanged_ViewModel_Currencies;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_ViewModel_Currencies).CollectionChanged -= CollectionChanged_ViewModel_Currencies;
                            cache_ViewModel_Currencies = null;
                        }
                        if (obj != null)
                        {
                            cache_ViewModel_Currencies = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_ViewModel_Currencies;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_ViewModel_Currencies;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\CurrencyHistoryPage.xaml line 11
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element2 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element2).Click += this.Back_Click;
                }
                break;
            case 3: // Views\CurrencyHistoryPage.xaml line 12
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element3 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element3).Click += this.Exit_Click;
                }
                break;
            case 5: // Views\CurrencyHistoryPage.xaml line 21
                {
                    this.ProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 6: // Views\CurrencyHistoryPage.xaml line 22
                {
                    this.lineChart = (global::Syncfusion.UI.Xaml.Charts.SfChart)(target);
                }
                break;
            case 10: // Views\CurrencyHistoryPage.xaml line 49
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element10 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element10).Click += this.SaveChart_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\CurrencyHistoryPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    CurrencyHistoryPage_obj1_Bindings bindings = new CurrencyHistoryPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

