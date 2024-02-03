using ReactiveUI;

namespace Avalonia.DependencyInjectionPoc.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _mainV;
    public ViewModelBase MainV
    {
        get => _mainV;
        set => this.RaiseAndSetIfChanged(ref _mainV, value);
    }

    public MainWindowViewModel()
    {
        _mainV = DIContrainer.Instance.Container!.GetInstance<MainViewModel>();
    }
}
