using Company.Project.UI;
using System;
using System.Collections.Generic;

namespace Company.Project.Features.Inventory
{
    public interface IInventoryView : IView
    {
        event EventHandler<IItem> Selected;
        event EventHandler<IItem> Deselected;
        void Display(List<IItem> itemInfoCollection);
    }
}