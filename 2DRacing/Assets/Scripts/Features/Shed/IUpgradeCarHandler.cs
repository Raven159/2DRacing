namespace Company.Project.Features.Shed
{
    public interface IUpgradeCarHandler
    {
        IUpgradable Upgrade(IUpgradable upgradeble);
    }
}