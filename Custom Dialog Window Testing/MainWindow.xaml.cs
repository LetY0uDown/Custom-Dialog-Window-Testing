using System.Windows;

namespace Custom_Dialog_Window_Testing;

public partial class MainWindow : Window
{
    public MainWindow ()
    {
        InitializeComponent();
    }

    private void Button_Click (object sender, RoutedEventArgs e)
    {
        var res = Dialog.Show();

        text.Text = res switch {
            DialogWindow.DialogResult.Yes => "Вы нажали на кнопку да! Круто",
            DialogWindow.DialogResult.No => "Результат вышего выбора - нет. Мде :(",
            DialogWindow.DialogResult.Undefined => "Вы так и не смогли определится с выбором"
        };
    }
}