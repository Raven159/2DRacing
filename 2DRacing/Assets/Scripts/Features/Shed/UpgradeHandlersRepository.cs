using System.Collections.Generic;

namespace Company.Project.Features.Shed
{
    public class UpgradeHandlersRepository : IRepository<int, IUpgradeCarHandler>
    {
        #region Fields

        private readonly Dictionary<int, global::IUpgradeCarHandler> _upgradeItemsMapById 
            = new Dictionary<int, global::IUpgradeCarHandler>();

        #endregion

        #region Life cycle

        public UpgradeHandlersRepository(List<UpgradeItemConfig> upgradeItemConfigs)
        {
            PopulateItems(ref _upgradeItemsMapById, upgradeItemConfigs);
        }

        #endregion

        #region Methods

        private void PopulateItems(
            ref Dictionary<int, global::IUpgradeCarHandler> upgradeHandlersMapByType,
            List<UpgradeItemConfig> configs)
        {
            foreach (var config in configs)
            {
                if (upgradeHandlersMapByType.ContainsKey(config.Id)) continue;
                upgradeHandlersMapByType.Add(config.Id, CreateHandlerByType(config));
            }
        }

        private global::IUpgradeCarHandler CreateHandlerByType(UpgradeItemConfig config)
        {
            switch (config.type)
            {
                case UpgradeType.Speed:
                    return new SpeedUpgradeHandler(config.value);
                default:
                    return StubUpgradeCarHandler.Default;
            }
        }

        #endregion

        #region IRepository

        public IReadOnlyDictionary<int, IUpgradeCarHandler> Collection => _upgradeItemsMapById;

        #endregion
    }
}