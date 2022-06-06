using Wingmann.DesignPatterns.Solid.SingleResponsibilityPrinciple.CommonTypes;

namespace Wingmann.DesignPatterns.Solid.SingleResponsibilityPrinciple;

/// <summary>
/// Implements mail client.
/// </summary>
public class MailClient
{
    /// <summary>
    /// Send an email message.
    /// </summary>
    /// <param name="message">Email message.</param>
    /// <returns>Operation status.</returns>
    public static bool Send(MailMessage message) => true;
}
