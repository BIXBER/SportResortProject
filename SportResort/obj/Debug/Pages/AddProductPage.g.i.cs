﻿#pragma checksum "..\..\..\Pages\AddProductPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC53E4823F98D0E86975E6CE0958D00196B13F2CF2678CBE8CBBE35E73773DEA"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SportResort.Pages;
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


namespace SportResort.Pages {
    
    
    /// <summary>
    /// AddProductPage
    /// </summary>
    public partial class AddProductPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 36 "..\..\..\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgPhoto;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonBrowseImage;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton yesRadioButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton noRadioButton;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productTitleTextBox;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productDescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\AddProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox productCostTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/SportResort;component/pages/addproductpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AddProductPage.xaml"
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
            this.imgPhoto = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.buttonBrowseImage = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\Pages\AddProductPage.xaml"
            this.buttonBrowseImage.Click += new System.Windows.RoutedEventHandler(this.buttonBrowseImage_onClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.yesRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.noRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.productTitleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.productDescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.productCostTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 69 "..\..\..\Pages\AddProductPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.buttonAddProduct_onClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

