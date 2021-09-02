Imports System.Windows

Namespace PrintingExporting
	Public Enum PrintMetod
		RibbonPreview
		RibbonPreviewDialog
		Preview
		PreviewDialog
	End Enum

	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'			#Region "#PrintMethods"
			Select Case CType(cbPrintingMethod.SelectedItem, PrintMetod)
				Case (PrintMetod.RibbonPreview)
					mapControl.ShowRibbonPrintPreview(Me)
				Case (PrintMetod.RibbonPreviewDialog)
					mapControl.ShowRibbonPrintPreviewDialog(Me)
				Case (PrintMetod.Preview)
					mapControl.ShowPrintPreview(Me)
				Case (PrintMetod.PreviewDialog)
					mapControl.ShowPrintPreviewDialog(Me)
			End Select
'			#End Region ' #PrintMethods
		End Sub
	End Class
End Namespace
