namespace Wingmann.DesignPatterns.Solid.SingleResponsibilityPrinciple.CommonTypes;

/// <summary>
/// Implements mail customer.
/// </summary>
public class User
{
    /// <summary>
    /// Unique identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Email address.
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    /// Initializes the user data.
    /// </summary>
    /// <param name="name">Full name.</param>
    /// <param name="email">Email address.</param>
    public User(string name, string email)
    {
        Name = name;
        Email = email;
    }
}
