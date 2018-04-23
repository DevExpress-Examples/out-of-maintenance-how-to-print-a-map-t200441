using System.Windows;

namespace PrintingExporting {
    public enum PrintMetod { RibbonPreview, RibbonPreviewDialog, Preview, PreviewDialog };
        
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            #region #PrintMethods
            switch ((PrintMetod)cbPrintingMethod.SelectedItem) {
                case (PrintMetod.RibbonPreview):
                    mapControl.ShowRibbonPrintPreview(this);
                    break;
                case (PrintMetod.RibbonPreviewDialog):
                    mapControl.ShowRibbonPrintPreviewDialog(this);
                    break;
                case (PrintMetod.Preview):
                    mapControl.ShowPrintPreview(this);
                    break;
                case (PrintMetod.PreviewDialog):
                    mapControl.ShowPrintPreviewDialog(this);
                    break;
            }
            #endregion #PrintMethods
        }
    }
}
