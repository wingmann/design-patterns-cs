namespace Wingmann.DesignPatterns.Solid.SingleResponsibilityPrinciple.CommonTypes;

/// <summary>
/// Implements data base context.
/// </summary>
public class DbContext
{
    /// <summary>
    /// Inserts a value in the database
    /// </summary>
    /// <param name="user">User data.</param>
    /// <returns>Operation status.</returns>
    public bool Insert(User user) => true;
}
