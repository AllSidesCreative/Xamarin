using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace moshbasic
{
    public partial class GreetPage : ContentPage
    {
        string[] quotes = new string[] { "Insanity: doing the same thing over and over again and expecting different results.",
            "Imagination is more important than knowledge.", 
            "The important thing is not to stop questioning. Curiosity has its own reason for existing." };
        private int current = 0;
        const int i = 0;

        public GreetPage()
        {
            InitializeComponent();
             slider.Value = 0;
             
            //Padding = Device.OnPlatform(
                //iOS: new Thickness(0, 20, 0, 0), 
                //Android: new Thickness(0, 20, 0, 0), 
                //WinPhone: new Thickness(0, 20, 0, 0));


              }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        { //doesn't use data binding, not the preferred method
            Debug.WriteLine("Text here");
            label1.Text = String.Format("Value is {0:F2}", e.NewValue);
        }

        void Handle_Clicked(Object sender, System.EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "OK");
        }

        void myValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {          
            myLabel.FontSize =  e.NewValue * 20;
        }
        void Handle_Clicked1(Object sender, System.EventArgs e)
        {
            if (current == 2) {
                current = 0;
            }
            else {
                current += 1;
            }
            myLabel.Text = quotes[current];
        }
    }
}
