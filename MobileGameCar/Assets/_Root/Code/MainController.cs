using Game;
using Profile;
using System;
using System.Collections.Generic;
using UI;
using UnityEngine;


namespace Root
{
    internal class MainController : BaseController
    {
        private readonly Transform _placeForUI;
        private readonly ProfilePlayer _profilePlayer;

        private MainMenuController _mainMenuController;
        private GameController _gameController;

        public MainController(Transform placeForUI, ProfilePlayer profilePlayer)
        {
            _placeForUI = placeForUI;
            _profilePlayer = profilePlayer;

            profilePlayer.State.SubscribeOnChange(OnChangeGameState);
            OnChangeGameState(_profilePlayer.State.Value);
        }

        protected override void OnDispose()
        {
            _mainMenuController?.Dispose();
            _gameController?.Dispose();

            _profilePlayer.State.UnSubscribeOnChange(OnChangeGameState);
        }

        private void OnChangeGameState(GameState state)
        {
            switch (state)
            {
                case GameState.Start:
                    _mainMenuController = new MainMenuController(_placeForUI, _profilePlayer);
                    _gameController?.Dispose();
                    break;
                case GameState.Game:
                    _gameController = new GameController(_profilePlayer);
                    _mainMenuController?.Dispose();
                    break;
                default:
                    _mainMenuController?.Dispose();
                    _gameController?.Dispose();
                    break;
            }
        }
    }
}