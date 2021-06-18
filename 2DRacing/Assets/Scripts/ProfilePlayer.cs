using Profile.Analitic;
using Tools;

namespace Profile
{
    internal class ProfilePlayer
    {
        public ProfilePlayer(float speedCar, IAnaliticTools analiticTools)
        {
            CurrentState = new SubscriptionProperty<GameState>();
            CurrentCar = new Car(speedCar);
            AnaliticTools = analiticTools;
        }

        public SubscriptionProperty<GameState> CurrentState { get; }

        public Car CurrentCar { get; }

        public IAnaliticTools AnaliticTools;
    }
}