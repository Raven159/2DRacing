using Company.Project.Features.Inventory;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;

namespace Company.Project.Features.Shed
{
    public class ShedController : BaseController, IShedController
    {
        #region Fields
        private readonly IUpgradable _upgradable;

        private readonly IRepository<int, IUpgradeCarHandler> _upgradeHandlersRepository;
        private readonly IInventoryController _inventoryController;
        #endregion

        #region Life cucle
        public ShedController(
            [NotNull] IRepository<int, IUpgradeCarHandler> upgradeHandlersRepository,
            [NotNull] IInventoryController inventoryController,
            [NotNull] IUpgradable upgradable)
        {
            _upgradeHandlersRepository
                = upgradeHandlersRepository ?? throw new ArgumentNullException(nameof(upgradeHandlersRepository));
            _inventoryController
                = inventoryController ?? throw new ArgumentNullException(nameof(inventoryController));
            _upgradable = upgradable ?? throw new ArgumentNullException(nameof(upgradable));
        }
        #endregion

        #region Methods
        private void UpgradeCarWithEquippedItems(
            IUpgradable upgradable,
            IReadOnlyList<IItem> equippedItems,
            IReadOnlyDictionary<int, IUpgradeCarHandler> upgradeHandlers)
        {
            foreach (var equippedItem in equippedItems)
            {
                if (upgradeHandlers.TryGetValue(equippedItem.Id, out var handler))
                {
                    handler.Upgrade(upgradable);
                }
            }
        }
        #endregion

        #region IShedController
        public void Enter()
        {
            _inventoryController.ShowInventory(Exit);
        }

        public void Exit()
        {
            UpgradeCarWithEquippedItems(
                _upgradable, _inventoryController.GetEquippedItems(),
                _upgradeHandlersRepository.Collection);
        }
        #endregion
    }
}