namespace Custom_Dialog_Window_Testing;

public static class Dialog
{
    public static DialogWindow.DialogResult Show()
    {
        var window = new DialogWindow();
        window.ShowDialog();

        return window.Result;
    }
}