using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace SRC_system_of_registration_of_conscripts_
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
