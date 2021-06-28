using System;

interface IInventoryController
{
    void ShowInventory(Action callback);
    void HideInventory();
}