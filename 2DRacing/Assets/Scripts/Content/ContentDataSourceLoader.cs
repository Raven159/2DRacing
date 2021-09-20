using Company.Project.Features.Abilities;
using System.Collections.Generic;
using System.Linq;
using Tools;

namespace Company.Project.ContentData
{
    public static class ContentDataSourceLoader
    {
        public static List<UpgradeItemConfig> LoadUpgradeItemConfigs(ResourcePath resourcePath)
        {
            var config = ResourceLoader.LoadObject<UpgradeItemConfigDataSource>(resourcePath);
            return config == null ? new List<UpgradeItemConfig>() : config.itemConfig.ToList();
        }

        public static List<AbilityItemConfig> LoadAbilityItemConfigs(ResourcePath resourcePath)
        {
            var config = ResourceLoader.LoadObject<AbilityItemConfigDataSource>(resourcePath);
            return config == null ? new List<AbilityItemConfig>() : config.itemConfig.ToList();
        }
    }
}