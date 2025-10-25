using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Player>(out Player player))
        {
            _player.AddCoin();
            Destroy(gameObject);
        }
    }
}
