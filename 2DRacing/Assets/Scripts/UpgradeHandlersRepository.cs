using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UnityEngine.SpatialTracking.TrackedPoseDriver;

public class UpgradeHandlersRepository : BaseController
{
    public IReadOnlyDictionary<int, IUpgradeCarHandler> UpgradeItems => _upgradeItemsMapById;
    private Dictionary<int, IUpgradeCarHandler> _upgradeItemsMapById = new Dictionary<int, IUpgradeCarHandler>();

    #region Life cycle

    public UpgradeHandlersRepository(List<UpgradeItemConfig> upgradeItemConfigs)
    {
        PopulateItems(ref _upgradeItemsMapById, upgradeItemConfigs);
    }

    #endregion

    #region Methods

    private void PopulateItems(
        ref Dictionary<int, IUpgradeCarHandler> upgradeHandlersMapByType,
        List<UpgradeItemConfig> configs)
    {
        foreach (var config in configs)
        {
            if (upgradeHandlersMapByType.ContainsKey(config.Id)) continue;
            upgradeHandlersMapByType.Add(config.Id, CreateHandlerByType(config));
        }
    }

    private IUpgradeCarHandler CreateHandlerByType(UpgradeItemConfig config)
    {
        switch (config.type)
        {
            case UpdateType.Speed:
                return new SpeedUpdateCarHandler(config.value);
            default:
                return StubUpgradeCarHandler.Default;
        }
    }

    #endregion
}
