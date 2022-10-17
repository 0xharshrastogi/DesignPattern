namespace BridgePattern.Hardware;

public abstract class Remote
{

    public IDevice Device { get; }

    private bool _isActive;

    private enum VolumeAction { Increase, Decrease }

    protected Remote(IDevice device)
    {
        Device = device;
    }

    public void TooglePower()
    {
        if (_isActive) Device.Disable();
        else Device.Enable();

        _isActive = !_isActive;
    }

    private void UpdateVolumeBy(VolumeAction volumeAction)
    {
        Device.SetVolume(Device.GetVolume() + (volumeAction is VolumeAction.Increase ? 1 : -1));
    }

    public void VolumeUp()
    {
        if (Device.GetVolume() is >= 0 and < 100)
            UpdateVolumeBy(VolumeAction.Increase);
    }

    public virtual void VolumeDown()
    {
        if (Device.GetVolume() is >= 1 and <= 100)
            UpdateVolumeBy(VolumeAction.Decrease);
    }

    public virtual void ChannelUp() => Device.SetChannel(Device.GetChannel() + 1);

    public virtual void ChannelDown()
    {
        if (Device.GetChannel() > 0)
            Device.SetChannel(Device.GetChannel() - 1);
    }
}
