public class SpeedUpgradeHandler : IUpgradeCarHandler
{
    #region Fields

    private readonly float _speed;

    #endregion

    #region Life cycle

    public SpeedUpgradeHandler(float speed)
    {
        _speed = speed;
    }

    #endregion

    #region IUpdateHandler

    public IUpgradebleCar Upgrade(IUpgradebleCar upgradableCar)
    {
        upgradableCar.Speed = _speed;
        return upgradableCar;
    }

    #endregion
}