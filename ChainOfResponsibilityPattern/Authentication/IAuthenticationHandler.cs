namespace ChainOfResponsiblityPattern.Authentication;

public interface IAuthenticationProcessor
{
    void SetNextHandler(IAuthenticationProcessor handler);

    void NextAuthenticationProcessor();
}
