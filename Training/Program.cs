using Training;

public class Program
{
    public static void Main()
    {
        // Create a Button instance
        Button button = new Button();

        // Subscribe methods to the event
        button.ButtonClicked += button.ShowMessage;
        button.ButtonClicked += button.LogClick;

        // Simulate button click
        button.OnButtonClick();
    }
}