namespace Wingmann.DesignPatterns.Solid.SingleResponsibilityPrinciple.CommonTypes;

/// <summary>
/// Implements email message.
/// </summary>
public class MailMessage
{
    /// <summary>
    /// Email address.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Email message.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Initializes message data.
    /// </summary>
    /// <param name="email">Email address.</param>
    /// <param name="message">Email message.</param>
    public MailMessage(string email, string message)
    {
        Email = email;
        Message = message;
    }
}
