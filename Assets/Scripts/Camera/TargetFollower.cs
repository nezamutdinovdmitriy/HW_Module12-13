using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _offsetZ;

    private void Update()
    {
        Vector3 offset = transform.rotation * new Vector3(0, 0, _offsetZ);
        transform.position = _target.position + offset;
    }
}