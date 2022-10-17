namespace BridgePattern.Hardware;

public class Radio : IDevice
{
    private double _currentVolume = 0;

    private uint _currentChannel = 0;

    private bool _isConnected;

    public void Disable() => _isConnected = false;

    public void Enable() => _isConnected = true;

    public uint GetChannel() => _currentChannel;

    public double GetVolume() => _currentVolume;

    public bool IsConnected() => _isConnected;

    public void SetChannel(uint channel) => _currentChannel = channel;

    public void SetVolume(double volumePercentage)
    {
        Console.WriteLine($"Current Volume Is: {_currentVolume}");
        _currentVolume = volumePercentage;
    }
}
