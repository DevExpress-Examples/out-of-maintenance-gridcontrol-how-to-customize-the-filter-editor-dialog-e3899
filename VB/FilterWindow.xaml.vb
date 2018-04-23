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
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Editors.Filtering
Imports DevExpress.Xpf.Core

Namespace DXSample
	''' <summary>
	''' Interaction logic for FilterWindow.xaml
	''' </summary>
	Partial Public Class FilterWindow
		Inherits DXWindow
		Private filterControl As FilterControl
		Public Sub New(ByVal filterControl As FilterControl)
			InitializeComponent()
			Me.filterControl = filterControl
		End Sub

		Private Sub OnOkClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
			filterControl.ApplyFilter()
			Close()
		End Sub

		Private Sub OnCancelClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Close()
		End Sub

		Private Sub OnCustomActionClick(ByVal sender As Object, ByVal e As RoutedEventArgs)
			MessageBox.Show("Custom Action")
		End Sub
	End Class
End Namespace
