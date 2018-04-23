using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Xpf.Core;

namespace DXSample
{
    /// <summary>
    /// Interaction logic for FilterWindow.xaml
    /// </summary>
    public partial class FilterWindow : DXWindow
    {
        FilterControl filterControl;
        public FilterWindow(FilterControl filterControl)
        {
            InitializeComponent();
            this.filterControl = filterControl;
        }

        private void OnOkClick(object sender, RoutedEventArgs e)
        {
            filterControl.ApplyFilter();
            Close();
        }

        private void OnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnCustomActionClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Custom Action");
        }
    }
}
