using CommandPattern.Switch;

ISwitchable lamp = new Light();
ICommand openCmd = new OpenSwitchCommand(lamp);
ICommand closeCmd = new CloseSwitchCommand(lamp);
var lampSwitch = new Switch(openCmd, closeCmd);
var isActive = false;

if (args.Length is > 0)
    isActive = string.Equals(args[0], "ON", StringComparison.OrdinalIgnoreCase);

if (isActive)
    lampSwitch.Open();
else
    lampSwitch.Close();
