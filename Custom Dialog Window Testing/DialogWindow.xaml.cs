using System.Windows;

namespace Custom_Dialog_Window_Testing;

public partial class DialogWindow : Window
{
    public DialogWindow ()
    {
        InitializeComponent();
    }

    public DialogResult Result { get; private set; } = DialogResult.Undefined;

    private void YesButtonClick (object sender, RoutedEventArgs e)
    {
        Result = DialogResult.Yes;
        Close();
    }

    private void NoButtonClick (object sender, RoutedEventArgs e)
    {
        Result = DialogResult.No;
        Close();
    }

    public enum DialogResult
    {
        Yes,
        No,
        Undefined
    }
}