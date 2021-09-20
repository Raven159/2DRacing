﻿using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Company.Project.Features.Inventory
{
    public class InventoryController : BaseController, IInventoryController
    {
        #region Fields

        private readonly IRepository<int, IItem> _itemsRepository;
        private readonly IInventoryModel _inventoryModel;
        private readonly IInventoryView _inventoryView;
        private Action _hideAction;

        #endregion

        #region Life cycle

        public InventoryController(
            [NotNull] IRepository<int, IItem> itemsRepository,
            [NotNull] IInventoryModel inventoryModel,
            [NotNull] IInventoryView inventoryView)
        {
            _inventoryModel
                = inventoryModel ?? throw new ArgumentNullException(nameof(inventoryModel));

            _itemsRepository
                = itemsRepository ?? throw new ArgumentNullException(nameof(itemsRepository));

            _inventoryView
                = inventoryView ?? throw new ArgumentNullException(nameof(inventoryView));
        }

        protected override void OnDispose()
        {
            CleanupView();
            base.OnDispose();
        }

        #endregion

        #region IInventoryController

        public IReadOnlyList<IItem> GetEquippedItems()
        {
            return _inventoryModel.GetEquippedItems();
        }

        public void ShowInventory(Action hideAction)
        {
            _hideAction = hideAction;
            _inventoryView.Show();
            _inventoryView.Display(_itemsRepository.Collection.Values.ToList());
        }

        public void HideInventory()
        {
            _inventoryView.Hide();
            _hideAction?.Invoke();
        }

        #endregion

        #region Methods

        private void SetupView(IInventoryView inventoryView)
        {
            inventoryView.Selected += OnItemSelected;
            inventoryView.Deselected += OnItemDeselected;
        }

        private void CleanupView()
        {
            _inventoryView.Selected -= OnItemSelected;
            _inventoryView.Deselected -= OnItemDeselected;
        }

        private void OnItemSelected(object sender, IItem item)
        {
            _inventoryModel.EquipItem(item);
        }

        private void OnItemDeselected(object sender, IItem item)
        {
            _inventoryModel.UnequipItem(item);
        }

        #endregion
    }
}