using Avalonia.Controls;
using Avalonia.DependencyInjectionPoc.ViewModels;

namespace Avalonia.DependencyInjectionPoc.Views
{
	public partial class MainView : UserControlBase<MainViewModel>
	{
		public MainView()
		{
			InitializeComponent();
		}
	}
}