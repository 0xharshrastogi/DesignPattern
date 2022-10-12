using AbstractFactoryPattern.GuiFactory;

namespace AbstractFactoryPattern;

public class Application
{
    private Button? _openDialogButton;

    private Button? _closeDialogButton;

    private Dialog? _dialog;

    public Application(GUIFactory uiFactory)
    {
        SetupGUI(uiFactory);
    }

    private void SetupGUI(GUIFactory uiFactory)
    {
        _dialog = uiFactory.CreateDialog();

        _openDialogButton = uiFactory.CreateButton();
        _closeDialogButton = uiFactory.CreateButton();

        _openDialogButton.OnClick += () => _dialog.Open();
        _closeDialogButton.OnClick += () => _dialog.Close();
    }

    public void ShowAlert() => _openDialogButton!.Click();

    public void CloseAlert() => _closeDialogButton!.Click();

    public void UpdateGUI(GUIFactory uiFactory) => SetupGUI(uiFactory);
}
