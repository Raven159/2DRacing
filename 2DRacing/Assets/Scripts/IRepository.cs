using System.Collections.Generic;

public interface IRepository
{
    IReadOnlyDictionary<int, IItem> Items { get; }
}
