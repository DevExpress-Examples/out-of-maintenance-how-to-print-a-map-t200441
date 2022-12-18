Imports System.Windows

Namespace PrintingExporting

    Public Enum PrintMetod
        RibbonPreview
        RibbonPreviewDialog
        Preview
        PreviewDialog
    End Enum

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
'#Region "#PrintMethods"
            Select Case CType(Me.cbPrintingMethod.SelectedItem, PrintMetod)
                Case PrintMetod.RibbonPreview
                    Me.mapControl.ShowRibbonPrintPreview(Me)
                Case PrintMetod.RibbonPreviewDialog
                    Me.mapControl.ShowRibbonPrintPreviewDialog(Me)
                Case PrintMetod.Preview
                    Me.mapControl.ShowPrintPreview(Me)
                Case PrintMetod.PreviewDialog
                    Me.mapControl.ShowPrintPreviewDialog(Me)
            End Select
'#End Region  ' #PrintMethods
        End Sub
    End Class
End Namespace
