Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports DevExpress.Data.Filtering
Imports System.Collections
Imports DevExpress.Data.Filtering.Helpers
Imports DevExpress.Xpf.Editors.Filtering
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Editors.Settings
Imports DXSample


Namespace DXWpfApplication
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			DataContext = New TestDataViewsModel()
		End Sub

		Private window As FilterWindow
		Private Sub TableView_FilterEditorCreated(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.FilterEditorEventArgs)
			e.Handled = True
			ShowFilterEditor(e)
		End Sub

		Private Sub ShowFilterEditor(ByVal e As DevExpress.Xpf.Grid.FilterEditorEventArgs)
			If IsFilterWindowOpened Then
				Return
			End If
			Dim titleText As String = DevExpress.Xpf.Grid.GridControlLocalizer.Active.GetLocalizedString(GridControlStringId.FilterEditorTitle)
			window = New FilterWindow(e.FilterControl)
			window.Owner = Me
			AddHandler window.Closing, AddressOf OnFilterWindowClosing
			window.Title = titleText
			window.Icon = DevExpress.Xpf.Core.Native.ImageHelper.CreateImageFromCoreEmbeddedResource("Editors.Images.FilterControl.filter.png")
			window.Grid.Children.Add(e.FilterControl)
			window.ShowDialog()
		End Sub

		Private Sub OnFilterWindowClosing(ByVal sender As Object, ByVal e As CancelEventArgs)
			RemoveHandler window.Closing, AddressOf OnFilterWindowClosing
			window = Nothing
			tableView1.DataControl.Focus()
		End Sub

		Private ReadOnly Property IsFilterWindowOpened() As Boolean
			Get
				Return window IsNot Nothing
			End Get
		End Property
	End Class
End Namespace
