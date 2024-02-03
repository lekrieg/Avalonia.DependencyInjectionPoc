using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.DependencyInjectionPoc.ViewModels;
using Avalonia.DependencyInjectionPoc.Views;
using Avalonia.Markup.Xaml;

namespace Avalonia.DependencyInjectionPoc
{
	public partial class App : Application
	{
		public override void Initialize()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public override void OnFrameworkInitializationCompleted()
		{
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
			{
				desktop.MainWindow = new MainWindow
				{
					DataContext = new MainViewModel()
				};
			}
			else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
			{
				singleViewPlatform.MainView = new MainView
				{
					DataContext = new MainViewModel()
				};
			}

			base.OnFrameworkInitializationCompleted();
		}
	}
}