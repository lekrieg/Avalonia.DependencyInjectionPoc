using ReactiveUI;
using System.Windows.Input;

namespace Avalonia.DependencyInjectionPoc.ViewModels;

public class MainViewModel : ViewModelBase
{
	private string _randomText = "u,u";
	public string RandomText
	{
		get => _randomText;
		set => this.RaiseAndSetIfChanged(ref _randomText, value);
	}

	public ICommand MyCommand { get; set; }

	public MainViewModel()
	{
		MyCommand = ReactiveCommand.Create(() => { RandomText = "Lol"; });
	}
}
