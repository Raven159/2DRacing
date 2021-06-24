using System.Collections.Generic;

public interface IItemRepository
{
    IReadOnlyDictionary<int, IItem> Items { get; }
}
