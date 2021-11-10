using Car;
using Profile;
using System.Collections;
using System.Collections.Generic;
using Tool;
using UnityEngine;

namespace Profile
{
    public class ProfilePlayer : MonoBehaviour
    {
        public readonly SubscriptionProperty<GameState> State;
        public readonly CarModel CarModel;

        public ProfilePlayer(GameState state, float speed)
        {
            State = new SubscriptionProperty<GameState>();
            State.Value = state;
            CarModel = new CarModel(5);
        }
    }
}