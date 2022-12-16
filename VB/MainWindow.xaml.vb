Imports System.Windows
Imports System.Windows.Controls
Imports System.ComponentModel
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.Xpf.Editors.Filtering
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports DXSample

Namespace DXWpfApplication

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            DataContext = New TestDataViewsModel()
        End Sub

        Private window As FilterWindow

        Private Sub TableView_FilterEditorCreated(ByVal sender As Object, ByVal e As FilterEditorEventArgs)
            e.Handled = True
            ShowFilterEditor(e)
        End Sub

        Private Sub ShowFilterEditor(ByVal e As FilterEditorEventArgs)
            If IsFilterWindowOpened Then Return
            Dim titleText As String = GridControlLocalizer.Active.GetLocalizedString(GridControlStringId.FilterEditorTitle)
            window = New FilterWindow(e.FilterControl)
            window.Owner = Me
            AddHandler window.Closing, AddressOf OnFilterWindowClosing
            window.Title = titleText
            window.Icon = Native.ImageHelper.CreateImageFromCoreEmbeddedResource("Editors.Images.FilterControl.filter.png")
            window.Grid.Children.Add(e.FilterControl)
            window.ShowDialog()
        End Sub

        Private Sub OnFilterWindowClosing(ByVal sender As Object, ByVal e As CancelEventArgs)
            RemoveHandler window.Closing, AddressOf OnFilterWindowClosing
            window = Nothing
            Me.tableView1.DataControl.Focus()
        End Sub

        Private ReadOnly Property IsFilterWindowOpened As Boolean
            Get
                Return window IsNot Nothing
            End Get
        End Property
    End Class
End Namespace
