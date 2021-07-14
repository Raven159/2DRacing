﻿using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AbilitiesController : BaseController
{
    private readonly IInventoryModel _inventoryModel;
    private readonly IAbilityRepository _abilityRepository;
    private readonly IAbilityCollectionView _abilityCollectionView;
    private readonly IAbilityActivator _abilityActivator;

    public AbilitiesController(
        [NotNull] IAbilityActivator abilityActivator,
        [NotNull] IInventoryModel inventoryModel,
        [NotNull] IAbilityRepository abilityRepository,
        [NotNull] IAbilityCollectionView abilityCollectionView)
    {
        _abilityActivator = abilityActivator ?? throw new ArgumentNullException(nameof(abilityActivator));
        _inventoryModel = inventoryModel ?? throw new ArgumentNullException(nameof(abilityActivator));
        _abilityRepository = abilityRepository ?? throw new ArgumentNullException(nameof(abilityRepository));
        _abilityCollectionView = abilityCollectionView ?? throw new ArgumentNullException(nameof(abilityCollectionView));
        _abilityCollectionView.Display(_inventoryModel.GetEquippedItems());
    }

    private void OnAbilityUseREquested(object sender, IItem e)
    {
        if (_abilityRepository.AbilityMapByItemId.TryGetValue(e.Id, out var ability))
            ability.Apply(_abilityActivator);
    }
}
