﻿#pragma checksum "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "95176868921F18456F1E25AD990631F0B143EE574628EDDC300A64C0A54968B4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SportMaster.Views.Pages.AdminPages;
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


namespace SportMaster.Views.Pages.AdminPages {
    
    
    /// <summary>
    /// ProductDataPage
    /// </summary>
    public partial class ProductDataPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBack;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbSearchProduct;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSearchCategory;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddProductBtn;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditProductBtn;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteProductBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/SportMaster;component/views/pages/adminpages/productdatapage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
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
            
            #line 8 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
            ((SportMaster.Views.Pages.AdminPages.ProductDataPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnBack = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
            this.BtnBack.Click += new System.Windows.RoutedEventHandler(this.BtnBack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txbSearchProduct = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
            this.txbSearchProduct.SelectionChanged += new System.Windows.RoutedEventHandler(this.txbSearchProduct_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbSearchCategory = ((System.Windows.Controls.ComboBox)(target));
            
            #line 24 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
            this.cmbSearchCategory.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbSearchCategory_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddProductBtn = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
            this.AddProductBtn.Click += new System.Windows.RoutedEventHandler(this.AddProductBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EditProductBtn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
            this.EditProductBtn.Click += new System.Windows.RoutedEventHandler(this.EditProductBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.DeleteProductBtn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\..\..\Views\Pages\AdminPages\ProductDataPage.xaml"
            this.DeleteProductBtn.Click += new System.Windows.RoutedEventHandler(this.DeleteProductBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

