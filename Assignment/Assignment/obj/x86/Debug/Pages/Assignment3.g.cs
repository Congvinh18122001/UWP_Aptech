﻿#pragma checksum "D:\SEM3\UWP\UWP_Aptech\Assignment\Assignment\Pages\Assignment3.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9B72B99660D6CBA770214F84B519D411"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment.Pages
{
    partial class Assignment3 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Assignment3.xaml line 13
                {
                    this.slvMenu = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // Pages\Assignment3.xaml line 17
                {
                    this.LV = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.LV).Loaded += this.ListView_Loaded;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.LV).Tapped += this.LV_Tapped;
                }
                break;
            case 4: // Pages\Assignment3.xaml line 19
                {
                    this.btn = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btn).Click += this.Button_Click;
                }
                break;
            case 6: // Pages\Assignment3.xaml line 25
                {
                    global::Windows.UI.Xaml.Controls.ListViewItem element6 = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)element6).Tapped += this.ListViewItem_Tapped;
                }
                break;
            case 7: // Pages\Assignment3.xaml line 36
                {
                    global::Windows.UI.Xaml.Controls.ScrollViewer element7 = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                    ((global::Windows.UI.Xaml.Controls.ScrollViewer)element7).Loaded += this.ScrollViewer_Loaded;
                    ((global::Windows.UI.Xaml.Controls.ScrollViewer)element7).Tapped += this.ScrollViewer_Tapped;
                }
                break;
            case 8: // Pages\Assignment3.xaml line 37
                {
                    this.frMenu = (global::Windows.UI.Xaml.Controls.Frame)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
