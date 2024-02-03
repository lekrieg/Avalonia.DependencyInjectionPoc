using Avalonia.DependencyInjectionPoc.ViewModels;

namespace Avalonia.DependencyInjectionPoc.Views
{
	public partial class MainWindow : WindowBase<MainWindowViewModel>
	{
		public MainWindow()
		{
			InitializeComponent();
		}
	}
}