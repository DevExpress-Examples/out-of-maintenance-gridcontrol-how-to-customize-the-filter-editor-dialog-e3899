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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;
using DevExpress.Data.Filtering;
using System.Collections;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.Xpf.Editors.Filtering;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Editors.Settings;
using DXSample;


namespace DXWpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new TestDataViewsModel();
        }

        FilterWindow window;
        private void TableView_FilterEditorCreated(object sender, DevExpress.Xpf.Grid.FilterEditorEventArgs e)
        {
            e.Handled = true;
            ShowFilterEditor(e);
        }

        private void ShowFilterEditor(DevExpress.Xpf.Grid.FilterEditorEventArgs e)
        {
            if (IsFilterWindowOpened)
                return;
            string titleText = DevExpress.Xpf.Grid.GridControlLocalizer.Active.GetLocalizedString(GridControlStringId.FilterEditorTitle);
            window = new FilterWindow(e.FilterControl);
            window.Owner = this;
            window.Closing += OnFilterWindowClosing;
            window.Title = titleText;
            window.Icon = DevExpress.Xpf.Core.Native.ImageHelper.CreateImageFromCoreEmbeddedResource("Editors.Images.FilterControl.filter.png");
            window.Grid.Children.Add(e.FilterControl);
            window.ShowDialog();
        }

        void OnFilterWindowClosing(object sender, CancelEventArgs e)
        {
            window.Closing -= OnFilterWindowClosing;
            window = null;
            tableView1.DataControl.Focus();
        }

        bool IsFilterWindowOpened
        {
            get { return window != null; }
        }
    }
}
