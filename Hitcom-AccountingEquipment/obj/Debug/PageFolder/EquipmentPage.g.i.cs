﻿#pragma checksum "..\..\..\PageFolder\EquipmentPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "912638A6B444A4634CAA3A12DBA167BB8F6D7CC517E2DF1028189E5E84B79BB0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Hitcom_AccountingEquipment;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Hitcom_AccountingEquipment {
    
    
    /// <summary>
    /// EquipmentPage
    /// </summary>
    public partial class EquipmentPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 16 "..\..\..\PageFolder\EquipmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DgridMyPage;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\PageFolder\EquipmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTxt;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\PageFolder\EquipmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FilteCmb;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\PageFolder\EquipmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\PageFolder\EquipmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Hitcom-AccountingEquipment;component/pagefolder/equipmentpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageFolder\EquipmentPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\PageFolder\EquipmentPage.xaml"
            ((Hitcom_AccountingEquipment.EquipmentPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.Page_IsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DgridMyPage = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.SearchTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\PageFolder\EquipmentPage.xaml"
            this.SearchTxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.FilteCmb = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\..\PageFolder\EquipmentPage.xaml"
            this.FilteCmb.DropDownClosed += new System.EventHandler(this.FilteCmb_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\PageFolder\EquipmentPage.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnDel = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\PageFolder\EquipmentPage.xaml"
            this.BtnDel.Click += new System.Windows.RoutedEventHandler(this.BtnDel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 27 "..\..\..\PageFolder\EquipmentPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
