#pragma checksum "..\..\index.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D287ADE94A4436FCEA1F658E5416A25CF065A4C"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using survey_wpf;


namespace survey_wpf {
    
    
    /// <summary>
    /// index
    /// </summary>
    public partial class index : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridTitle;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonFechar;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button listbutton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button maincreatebutton;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createbutton;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button create_mutli;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\index.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame changeFrame;
        
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
            System.Uri resourceLocater = new System.Uri("/survey_wpf;component/index.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\index.xaml"
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
            this.GridTitle = ((System.Windows.Controls.Grid)(target));
            
            #line 20 "..\..\index.xaml"
            this.GridTitle.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.GridTitle_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonFechar = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\index.xaml"
            this.ButtonFechar.Click += new System.Windows.RoutedEventHandler(this.ButtonFechar_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listbutton = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\index.xaml"
            this.listbutton.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.maincreatebutton = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\index.xaml"
            this.maincreatebutton.Click += new System.Windows.RoutedEventHandler(this.Maincreatebutton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.createbutton = ((System.Windows.Controls.Button)(target));
            
            #line 66 "..\..\index.xaml"
            this.createbutton.Click += new System.Windows.RoutedEventHandler(this.createbutton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.create_mutli = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\index.xaml"
            this.create_mutli.Click += new System.Windows.RoutedEventHandler(this.create_mutli_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.changeFrame = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

