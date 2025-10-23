using UnityEngine;

public class CoinRotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        transform.Rotate(new Vector3(0, _rotateSpeed, 0));
    }
}
