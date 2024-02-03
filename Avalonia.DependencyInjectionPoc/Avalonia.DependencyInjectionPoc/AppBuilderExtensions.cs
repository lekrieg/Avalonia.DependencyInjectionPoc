using Avalonia.DependencyInjectionPoc.ViewModels;
using Lamar;

namespace Avalonia.DependencyInjectionPoc;

public static class AppBuilderExtensions
{
	public static AppBuilder UseLamar(this AppBuilder builder)
	{
		return builder.AfterPlatformServicesSetup(_ =>
		{
			DIContrainer.Instance.Container = new Container(config =>
			{
				config.Scan(scan =>
				{
					scan.AssemblyContainingType<DIContrainer>();
					scan.AddAllTypesOf<ViewModelBase>();
					scan.WithDefaultConventions();
				});
			});
		});
	}
}
