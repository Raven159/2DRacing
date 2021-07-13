public class StubUpgradeCarHandler : IUpgradeCarHandler
{
    public static readonly IUpgradeCarHandler Default = new StubUpgradeCarHandler(); 

    public IUpgradebleCar Upgrade(IUpgradebleCar upgradebleCar)
    {
        return upgradebleCar;
    }
}