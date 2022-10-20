namespace ChainOfResponsiblityPattern.Authentication;

public abstract class AuthProcessorBase
{
    protected AuthProcessorBase? NextHandler { set; get; }

    protected AuthProcessorBase(AuthProcessorBase? nextHandler)
    {
        NextHandler = nextHandler;
    }

    public abstract bool IsAuthorized(Credential credential);
}
