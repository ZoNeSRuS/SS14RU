using Content.Client.UserInterface.Controls;
using Content.Shared.AWS.Economy;
using Content.Client.AWS.Economy.UI;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface.XAML;
using Robust.Client.UserInterface.Controls;

namespace Content.Client.AWS.Economy.UI;

[GenerateTypedNameReferences]
public sealed partial class EconomyTerminalMenu : FancyWindow
{
    private EconomyTerminalBoundUserInterface Owner { get; set; }

    public EconomyTerminalMenu(EconomyTerminalBoundUserInterface owner)
    {
        IoCManager.InjectDependencies(this);
        RobustXamlLoader.Load(this);

        Owner = owner;

        SetButton.OnPressed += _ => Owner.OnPayPressed((ulong) AmountBox.Value, ReasonField.Text);
    }
}
