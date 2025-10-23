using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private float _timer = 5f;
    [SerializeField] private List<Coin> _coins = new List<Coin>();
    [SerializeField] private InputHandler _inputHandler;

    private float _currentTimer;
    private bool _isGameOver;

    private void Awake()
    {
        _currentTimer = _timer;
    }

    private void Update()
    {
        if (_isGameOver)
        {
            if (_inputHandler.IsRestartKeyPressed)
                RestartGame();

            return;
        }

        if (_currentTimer > 0)
            _currentTimer -= Time.deltaTime;

        if (_coins.Count == 0 && _currentTimer > 0)
            GameOver("GAME WIN");
        else
            GameOver("GAME LOOSE");
    }

    private void RestartGame()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }

    private void GameOver(string message)
    {
        _currentTimer = 0;
        _isGameOver = true;
        Debug.Log(message);
    }

    public void RemoveCoin() => _coins.RemoveAt(0);

}
