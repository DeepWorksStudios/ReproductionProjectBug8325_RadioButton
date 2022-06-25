using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace ReproductionProjectBug8325_RadioButton;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
