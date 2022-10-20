using ChainOfResponsiblityPattern.Authentication;

var credentialHandler = new CredentialValidatorAuthProcess(handler: default);
var emailHandler = new EmailValidatorAuthProcess(handler: credentialHandler);
var credential = new Credential("user@example.com", "1234");

Console.WriteLine("IS Authorized: {0}", emailHandler.IsAuthorized(credential));
