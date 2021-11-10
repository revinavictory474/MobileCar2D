using Car;
using System.Collections;
using System.Collections.Generic;
using Tool;
using UnityEngine;

    namespace Game.InputGame
{
    internal class InputGameController : BaseController
    {
        public InputGameController(SubscriptionProperty<float> leftMove, SubscriptionProperty<float> rightMove, CarModel car)
        {
            _view = LoadView();
            _view.Init(leftMove, rightMove, car.Speed);
        }

        private readonly ResourcesPath _viewPath = new ResourcesPath { PathResource = "Prefabs/endlessMove" };
        private BaseInputView _view;

        private BaseInputView LoadView()
        {
            GameObject objView = Object.Instantiate(ResourcesLoader.LoadPrefab(_viewPath));
            AddGameObject(objView);
            return objView.GetComponent<BaseInputView>();
        }
    }
}