using Microsoft.AspNetCore.Components.WebView.Maui;
using CPRG211_FinalProject.Data;
using System;
using SQLite;
using SQLitePCL;

namespace CPRG211_FinalProject;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();

		/*
		builder.Services.AddSingleton<TodoListPage>();
		builder.Services.AddTransient<TodoItemPage>();
		

		builder.Services.AddSingleton<TodoItemDatabase>();
		*/
		return builder.Build();
	}
}
