using Profile;
using Tools;
using UnityEngine;

namespace Game.ImputLogic
{
    internal class InputGameController : BaseController
    {
        private readonly ResourcePath _viewPath;
        private BaseInputView _view;

        public InputGameController(SubscriptionProperty<float> leftMove, SubscriptionProperty<float> rightMove, Car car)
        {
            _view = LoadView();
            _view.Init(leftMove, rightMove, car.Speed);
        }

        private BaseInputView LoadView()
        {
            GameObject objectView = Object.Instantiate(ResourceLoader.LoadPrefab(_viewPath));
            AddGameObjects(objectView);
            return objectView.GetComponent<BaseInputView>();
        }
    }
}
