﻿#pragma checksum "D:\SEM3\UWP\WPF\Food\Food\Pages\CategoryDetailPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C89013E089B0D2B5A61E25F5FAA93F00"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Food.Pages
{
    partial class CategoryDetailPage : 
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
            case 2: // Pages\CategoryDetailPage.xaml line 18
                {
                    this.CmBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 3: // Pages\CategoryDetailPage.xaml line 23
                {
                    this.gvFood = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.gvFood).Loaded += this.GridView_Loaded;
                }
                break;
            case 5: // Pages\CategoryDetailPage.xaml line 26
                {
                    global::Windows.UI.Xaml.Controls.GridViewItem element5 = (global::Windows.UI.Xaml.Controls.GridViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.GridViewItem)element5).RightTapped += this.GridViewItem_RightTapped;
                    ((global::Windows.UI.Xaml.Controls.GridViewItem)element5).Tapped += this.GridViewItem_Tapped;
                }
                break;
            case 10: // Pages\CategoryDetailPage.xaml line 20
                {
                    this.ButtonBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.ButtonBack).Click += this.ButtonBack_Click;
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

