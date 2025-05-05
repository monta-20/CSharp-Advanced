using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    public class Button
    {
        
        // Delegate for the button click
        public delegate void ButtonClickHandler();

        // Event triggered when button is clicked
        public event ButtonClickHandler ButtonClicked;

        // Method to simulate a button click
        public void OnButtonClick()
        {
            Console.WriteLine("🔘 Button was clicked!");
            ButtonClicked?.Invoke(); // Notify all subscribers
        }

        // Subscriber methods
        public void ShowMessage()
        {
            Console.WriteLine("💬 Hello, World!");
        }

        public void LogClick()
        {
            Console.WriteLine("📝 Button click logged.");
        }
    }

   

}

