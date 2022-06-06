using Wingmann.DesignPatterns.Solid.SingleResponsibilityPrinciple.CommonTypes;

namespace Wingmann.DesignPatterns.Solid.SingleResponsibilityPrinciple;

/// <summary>
/// Implements mail service.
/// </summary>
public class MailService
{
    private MailClient _client;
    
    /// <summary>
    /// Initializes the mail client.
    /// </summary>
    /// <param name="client">Mail client.</param>
    public MailService(MailClient client) => _client = client;

    /// <summary>
    /// Checks the correctness of the email address.
    /// </summary>
    /// <param name="email">Email address.</param>
    /// <returns></returns>
    public static bool ValidateEmail(string email) => email.Contains('@');

    /// <summary>
    /// Sends email message.
    /// </summary>
    /// <param name="message"></param>
    /// <returns>Operation status.</returns>
    public bool SendMail(MailMessage message) => MailClient.Send(message);
}
