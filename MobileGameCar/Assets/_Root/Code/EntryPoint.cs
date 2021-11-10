using Profile;
using Root;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class EntryPoint : MonoBehaviour
{
    private const GameState InitialGameState = GameState.Start;
    private const float CarSpeed = 5f;

    [SerializeField] private Transform _plaseForUI;
    private MainController _mainController;

    private void Awake()
    {
        var profilerPlayer = new ProfilePlayer(InitialGameState, CarSpeed);
        _mainController = new MainController(_plaseForUI, profilerPlayer);
    }

    private void OnDestroy()
    {
        _mainController.Dispose();
    }
}
