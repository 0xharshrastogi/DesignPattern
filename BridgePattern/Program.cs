using BridgePattern.Hardware;

IDevice radio = new Radio();
var remote = new AdvanceRemote(radio);
