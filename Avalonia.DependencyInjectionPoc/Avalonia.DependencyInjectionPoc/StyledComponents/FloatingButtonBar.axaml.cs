using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Layout;
using Avalonia.Media;

namespace Avalonia.DependencyInjectionPoc.StyledComponents;

public enum FloatingButtonBarExpandDirection
{
	ToLeft,
	ToRight,
	ToTop,
	ToBottom
}

public class FloatingButtonBar : ItemsControl
{
	/* REFERENCE
	 * https://github.com/PieroCastillo/Aura.UI/tree/master
	 * https://github.com/PieroCastillo/Aura.UI/blob/master/src/Aura.UI.FluentTheme/Controls/FloatingButtonBar.xaml
	 * https://github.com/PieroCastillo/Aura.UI/blob/master/src/Aura.UI/Controls/FloatingButtonBar/FloatingButtonBar.cs
	 * https://github.com/PieroCastillo/Aura.UI/blob/master/samples/Aura.UI.Gallery/Controls/CodeExample.axaml
	 */
	static FloatingButtonBar()
	{
		FocusableProperty.OverrideDefaultValue<FloatingButtonBar>(false);
	}

	public static readonly StyledProperty<bool> IsExpandedProperty =
		AvaloniaProperty.Register<FloatingButtonBar, bool>(nameof(IsExpanded), false);

	public bool IsExpanded
	{
		get => GetValue(IsExpandedProperty);
		set => SetValue(IsExpandedProperty, value);
	}

	public static readonly StyledProperty<FloatingButtonBarExpandDirection> ExpandDirectionProperty =
		AvaloniaProperty.Register<FloatingButtonBar, FloatingButtonBarExpandDirection>(nameof(ExpandDirection), FloatingButtonBarExpandDirection.ToRight);

	public FloatingButtonBarExpandDirection ExpandDirection
	{
		get => GetValue(ExpandDirectionProperty);
		set => SetValue(ExpandDirectionProperty, value);
	}

	public static readonly StyledProperty<object> IconProperty =
		AvaloniaProperty.Register<FloatingButtonBar, object>(nameof(Icon));

	public object Icon
	{
		get => GetValue(IconProperty);
		set => SetValue(IconProperty, value);
	}

	public static readonly StyledProperty<IDataTemplate> IconTemplateProperty =
		AvaloniaProperty.Register<FloatingButtonBar, IDataTemplate>(nameof(IconTemplate), null);

	public IDataTemplate IconTemplate
	{
		get => GetValue(IconTemplateProperty);
		set => SetValue(IconTemplateProperty, value);
	}

	public static readonly StyledProperty<HorizontalAlignment> HorizontalIconAlignmentProperty =
		AvaloniaProperty.Register<FloatingButtonBar, HorizontalAlignment>(nameof(HorizontalIconAlignment), HorizontalAlignment.Stretch);

	public HorizontalAlignment HorizontalIconAlignment
	{
		get => GetValue(HorizontalIconAlignmentProperty);
		set => SetValue(HorizontalIconAlignmentProperty, value);
	}


	public static readonly StyledProperty<VerticalAlignment> VerticalIconAlignmentProperty =
		AvaloniaProperty.Register<FloatingButtonBar, VerticalAlignment>(nameof(VerticalIconAlignment), VerticalAlignment.Stretch);

	public VerticalAlignment VerticalIconAlignment
	{
		get => GetValue(VerticalIconAlignmentProperty);
		set => SetValue(VerticalIconAlignmentProperty, value);
	}

	public static readonly StyledProperty<Thickness> IconMarginProperty =
		AvaloniaProperty.Register<FloatingButtonBar, Thickness>(nameof(IconMargin), new Thickness());

	public Thickness IconMargin
	{
		get => GetValue(IconMarginProperty);
		set => SetValue(IconMarginProperty, value);
	}

	public static readonly StyledProperty<IBrush> IconForegroundProperty =
		AvaloniaProperty.Register<FloatingButtonBar, IBrush>(nameof(IconForeground), null);

	public IBrush IconForeground
	{
		get => GetValue(IconForegroundProperty);
		set => SetValue(IconForegroundProperty, value);
	}

	public static readonly StyledProperty<IBrush> IconBackgroundProperty =
		AvaloniaProperty.Register<FloatingButtonBar, IBrush>(nameof(IconBackground), null);

	public IBrush IconBackground
	{
		get => GetValue(IconBackgroundProperty);
		set => SetValue(IconBackgroundProperty, value);
	}

	public readonly static StyledProperty<double> OpenLengthProperty =
		AvaloniaProperty.Register<FloatingButtonBar, double>(nameof(OpenLength));

	public double OpenLength
	{
		get => GetValue(OpenLengthProperty);
		set => SetValue(OpenLengthProperty, value);
	}
}