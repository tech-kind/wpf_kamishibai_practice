using WpfKamishibaiPractice;
using WpfKamishibaiPractice.View;
using Kamishibai;
using Microsoft.Extensions.Hosting;
using WpfKamishibaiPractice.ViewModel;

// Create a builder by specifying the application and main window.
var builder = KamishibaiApplication<App, MainWindow>.CreateBuilder();

builder.Services.AddPresentation<MainWindow, MainViewModel>();
builder.Services.AddPresentation<FirstPage, FirstViewModel>();

// Build and run the application.
var app = builder.Build();
app.RunAsync();
