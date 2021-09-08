using Company.Project.UI;
using System;
using System.Collections.Generic;

namespace Company.Project.Features.Abilities
{
    public interface IAbilityCollectionView : IView
    {
        event EventHandler<IItem> UseRequested;
        void Display(IReadOnlyList<IItem> abilityItems);
    }
}