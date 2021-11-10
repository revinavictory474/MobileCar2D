using System.Collections;
using System.Collections.Generic;
using Tool;
using Car;
using UnityEngine;
using Profile;
using Game.TapeBackground;
using Game.InputGame;

namespace Game
{
    internal class GameController : BaseController
    {
        public GameController(ProfilePlayer profilePlayer)
        {
            var leftMoveDiff = new SubscriptionProperty<float>();
            var rightMoveDiff = new SubscriptionProperty<float>();

            var tapeBackgroundController = new TapeBackgroundController(leftMoveDiff, rightMoveDiff);
            AddController(tapeBackgroundController);

            var inputGameController = new InputGameController(leftMoveDiff, rightMoveDiff, profilePlayer.CarModel);
            AddController(inputGameController);

            var carController = new CarController();
            AddController(carController);
        }
    }
}