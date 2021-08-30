using System;
using System.Collections.Generic;

namespace Company.Project.Features.Inventory
{
    interface IInventoryController
    {
        IReadOnlyList<IItem> GetEquippedItems();
        void ShowInventory(Action hideAction);
        void HideInventory();
    }
}