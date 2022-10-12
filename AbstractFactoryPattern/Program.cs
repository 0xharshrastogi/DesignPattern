using AbstractFactoryPattern;
using AbstractFactoryPattern.GuiFactory.Macbook;
using AbstractFactoryPattern.GuiFactory.Windows;

var windowGUI = new WinGUIFactory();
var macbookGUI = new MacGUIFactory();

var application = new Application(windowGUI);

application.ShowAlert();
application.CloseAlert();

application.UpdateGUI(macbookGUI);

application.ShowAlert();
application.CloseAlert();
