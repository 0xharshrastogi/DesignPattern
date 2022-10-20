namespace ChainOfResponsiblityPattern.Authentication;

public class EmailValidatorAuthProcess : AuthProcessorBase
{
    public EmailValidatorAuthProcess(AuthProcessorBase? handler) : base(handler)
    { }

    public override bool IsAuthorized(Credential credential)
    {
        const bool cTRUTHY_VALUE = true;
        const string cUSER_EMAIL = "user@example.com";
        return credential.Email == cUSER_EMAIL && (NextHandler?.IsAuthorized(credential) ?? cTRUTHY_VALUE);
    }
}
