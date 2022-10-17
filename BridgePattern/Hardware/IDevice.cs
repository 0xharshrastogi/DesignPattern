namespace BridgePattern.Hardware;

public interface IDevice
{
    bool IsConnected();

    void Enable();

    void Disable();

    double GetVolume();

    void SetVolume(double volumePercentage);

    uint GetChannel();

    void SetChannel(uint channel);
}
