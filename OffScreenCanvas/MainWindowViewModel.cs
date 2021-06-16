using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OffScreenCanvas
{
    public partial class MainWindowViewModel : DependencyObject
    {
        public System.Windows.Controls.Image Image { get; set; }

        public string Text {
            get
            {
                return (string)GetValue(NameProperty);
            }
            set
            {
                SetValue(NameProperty, value);
            }
        }

        public static readonly DependencyProperty NameProperty = DependencyProperty.Register("Text", typeof(string), typeof(MainWindowViewModel), new PropertyMetadata(null));

        public MainWindowViewModel()
        {
            Text = "Hello World";
        }

    }
}
