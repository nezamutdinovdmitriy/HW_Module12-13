using UnityEngine;

public class CharacterRotator : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Player _player;

    public Vector3 CameraDirection { get; private set; }

    private void Update()
    {
        if (_player.InputHandler.IsMoving)
        {
            Quaternion flatCameraRotation = Quaternion.Euler(0, _camera.transform.eulerAngles.y, 0);

            CameraDirection = flatCameraRotation * _player.InputHandler.Direction.normalized;
        }
    }
}
