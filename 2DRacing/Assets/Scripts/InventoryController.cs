using JetBrains.Annotations;
using System;

public class InventoryController : BaseController, IInventoryController
{
    private readonly IInventoryModel _inventoryModel;
    private readonly IItemRepository _itemRepository;
    private readonly IInventoryView _inventoryWindowView;

    public InventoryController(
        [NotNull] IInventoryModel inventoryModel,
        [NotNull] IItemRepository itemRepository,
        [NotNull] IInventoryView inventoryView)
    {
        _inventoryModel
            = inventoryModel ?? throw new ArgumentNullException(nameof(inventoryModel));
        _itemRepository
            = itemRepository ?? throw new ArgumentNullException(nameof(itemRepository));
        _inventoryWindowView
            = inventoryView ?? throw new ArgumentNullException(nameof(inventoryView));
    }

    public void HideInventory()
    {
        throw new NotImplementedException();
    }

    public void ShowInventory(Action callback)
    {
        throw new NotImplementedException();
    }
}

