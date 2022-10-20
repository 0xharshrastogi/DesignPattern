namespace ChainOfResponsiblityPattern.Authentication;

public class CredentialValidatorAuthProcess : AuthProcessorBase
{
    public CredentialValidatorAuthProcess(AuthProcessorBase? handler) : base(handler)
    { }

    public override bool IsAuthorized(Credential credential)
        => credential.Password == "1234" && (NextHandler?.IsAuthorized(credential) ?? true);
}
