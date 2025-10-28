using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InputHandler _inputHandler;
    public InputHandler InputHandler => _inputHandler;
    public int СoinCount { get; private set; }

    public void AddCoin(int value) => СoinCount++;
}
