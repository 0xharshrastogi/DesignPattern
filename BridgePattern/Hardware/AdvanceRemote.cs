namespace BridgePattern.Hardware;

public class AdvanceRemote : Remote
{
    const int MIN_VOLUME = 0;

    public AdvanceRemote(IDevice device) : base(device)
    { }

    public void Mute() => Device.SetVolume(MIN_VOLUME);
}
