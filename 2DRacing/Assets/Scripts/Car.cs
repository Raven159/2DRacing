namespace Profile
{
    internal class Car : IUpgradebleCar
    {
        #region Fields

        private readonly float _defaultSpeed;

        #endregion

        #region Life cycle

        public Car(float speed)
        {
            _defaultSpeed = speed;
            Restore();
        }

        #endregion

        #region IUpgradebleCar

        public float Speed { get; set; }

        public void Restore()
        {
            Speed = _defaultSpeed;
        }

        #endregion
    }
}
