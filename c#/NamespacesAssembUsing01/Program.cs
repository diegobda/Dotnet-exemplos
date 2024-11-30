using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Olà_Mundo
{
    class Program
    {       
        static void Main(string[] args) 
        {
            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();
    }

    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            base.OnFrameworkInitializationCompleted();

            // Cria uma janela
            var window = new Window
            {
                Width = 400,
                Height = 300,
                Title = "Olá Mundo - Avalonia"
            };

            // Exibe a janela
            window.Show();

            // Mostra uma mensagem em uma nova janela
            var textBlock = new TextBlock
            {
                Text = "Ooi, estou usando Avalonia!",
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
                FontSize = 24
            };

            var messageWindow = new Window
            {
                Width = 300,
                Height = 200,
                Content = textBlock,
                Title = "Mensagem"
            };

            messageWindow.Show();
        }
    }
}
