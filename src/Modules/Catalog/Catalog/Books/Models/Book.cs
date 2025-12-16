using Shared.DDD;

namespace Catalog.Books.Models;
public class Book : Entity<Guid>
{
    public string Title { get; set; } = default!;
    public List<string> Category { get; set; } = [];
    public string Description { get; set; } = default!;
    public string ImageFile { get; set; } = default!;
    public decimal Score { get; set; }

    // Create method fir initializin Book
    public static Book Create(Guid id, string title, List<string> category, string description, string imageFile, decimal score)
    {
        ArgumentException.ThrowIfNullOrEmpty(title);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(score);

        var book = new Book
        {
            Id = id,
            Title = title,
            Category = category,
            ImageFile = imageFile,
            Score = score
        };

        return book;
    }
    // Property setters private
    // Update method
}
