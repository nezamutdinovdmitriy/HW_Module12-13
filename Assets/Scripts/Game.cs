using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    [SerializeField] private float _timer = 5f;
    [SerializeField] private int _targetCoinCount;
    [SerializeField] private Player _player;
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
        else
            GameOver("GAME LOOSE");

        if (_player.СoinCount == _targetCoinCount && _currentTimer > 0)
            GameOver("GAME WIN");
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
}
