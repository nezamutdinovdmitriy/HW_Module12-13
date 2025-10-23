using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Game _game;

    private void OnTriggerEnter(Collider other)
    {
        _game.RemoveCoin();
        Destroy(gameObject);
    }
}
