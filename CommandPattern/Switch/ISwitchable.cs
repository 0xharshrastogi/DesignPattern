namespace CommandPattern.Switch;

/// <summary>
/// An interface that defines actions that the receiver can perform
/// </summary>
public interface ISwitchable
{
    void Enable();
    void Disable();
}
