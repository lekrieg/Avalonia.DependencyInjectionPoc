using Avalonia.Controls;
using Avalonia.DependencyInjectionPoc.ViewModels;
using Lamar;

namespace Avalonia.DependencyInjectionPoc.Views;

public abstract class WindowBase <T> : Window where T : ViewModelBase
{
	[SetterProperty]
	public T ViewModel
	{
		get => (T)DataContext!;
		set => DataContext = value;
	}
}

public abstract class UserControlBase<T> : UserControl where T : ViewModelBase
{
	[SetterProperty]
	public T ViewModel
	{
		get => (T)DataContext!;
		set => DataContext = value;
	}
}