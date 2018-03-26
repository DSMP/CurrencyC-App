﻿#pragma checksum "C:\GitProjects\CurrencyAppNative\CurrencyAppNative\Views\CurrencyHistoryPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5DF4533A435190D2CBB80086E5941425"
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
            public static void Set_WinRTXamlToolkit_Controls_DataVisualization_Charting_Series_Title(global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Series obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Title = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Value = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_DatePicker_Date(global::Windows.UI.Xaml.Controls.DatePicker obj, global::System.DateTimeOffset value)
            {
                obj.Date = value;
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
            private global::WinRTXamlToolkit.Controls.DataVisualization.Charting.LineSeries obj7;
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
                    case 4: // Views\CurrencyHistoryPage.xaml line 17
                        this.obj4 = (global::Windows.UI.Xaml.Controls.Hub)target;
                        break;
                    case 5: // Views\CurrencyHistoryPage.xaml line 22
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
                        break;
                    case 7: // Views\CurrencyHistoryPage.xaml line 24
                        this.obj7 = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.LineSeries)target;
                        break;
                    case 8: // Views\CurrencyHistoryPage.xaml line 19
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
                    case 9: // Views\CurrencyHistoryPage.xaml line 20
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
                        this.Update_ViewModel_DateTimeStart(obj.DateTimeStart, phase);
                        this.Update_ViewModel_DateTimeFinish(obj.DateTimeFinish, phase);
                    }
                }
            }
            private void Update_ViewModel_Header(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 17
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Hub_Header(this.obj4, obj, null);
                    // Views\CurrencyHistoryPage.xaml line 24
                    XamlBindingSetters.Set_WinRTXamlToolkit_Controls_DataVisualization_Charting_Series_Title(this.obj7, obj, null);
                }
            }
            private void Update_ViewModel_Progress(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 22
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj5, obj);
                }
            }
            private void Update_ViewModel_DateTimeStart(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 19
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_DatePicker_Date(this.obj8, obj);
                }
            }
            private void Update_ViewModel_DateTimeFinish(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\CurrencyHistoryPage.xaml line 20
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_DatePicker_Date(this.obj9, obj);
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
            case 2: // Views\CurrencyHistoryPage.xaml line 12
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element2 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element2).Click += this.Back_Click;
                }
                break;
            case 3: // Views\CurrencyHistoryPage.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element3 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element3).Click += this.Exit_Click;
                }
                break;
            case 6: // Views\CurrencyHistoryPage.xaml line 23
                {
                    this.LineChart = (global::WinRTXamlToolkit.Controls.DataVisualization.Charting.Chart)(target);
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

