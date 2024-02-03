using Lamar;

namespace Avalonia.DependencyInjectionPoc;

public class DIContrainer
{
	private static DIContrainer? _instance;
    public static DIContrainer Instance
	{
		get
		{
			if(_instance == null)
			{
				_instance = new();
			}
			return _instance;
		}
	}

	public IContainer? Container { get; set; } = null;
}
