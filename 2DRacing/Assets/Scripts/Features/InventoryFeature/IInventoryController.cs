using System;
using System.Collections.Generic;

namespace Company.Project.Features.Inventory
{
    public interface IInventoryController
    {
        IReadOnlyList<IItem> GetEquippedItems();
        void ShowInventory(Action hideAction);
        void HideInventory();
    }
}