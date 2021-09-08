using System.Collections.Generic;

namespace Company.Project.Features.Abilities
{
    public interface IAbilityRepository
    {
        IReadOnlyDictionary<int, IAbility> AbilityMapByItemId { get; }
    }
}