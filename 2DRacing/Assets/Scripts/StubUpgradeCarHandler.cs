namespace Company.Project.Features.Shed
{
    public class StubUpgradeCarHandler : global::IUpgradeCarHandler
    {
        public static readonly global::IUpgradeCarHandler Default = new StubUpgradeCarHandler();

        public IUpgradebleCar Upgrade(IUpgradebleCar upgradebleCar)
        {
            return upgradebleCar;
        }
    }
}