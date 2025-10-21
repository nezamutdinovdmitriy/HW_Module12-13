using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotator : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private InputHandler _inputHandler;

    public Vector3 CameraDirection { get; private set; }

    private void Update()
    {
        if (_inputHandler.IsMoving)
        {
            Quaternion flatCameraRotation = Quaternion.Euler(0, _camera.transform.eulerAngles.y, 0);

            CameraDirection = flatCameraRotation * _inputHandler.Direction.normalized;
        }
    }
}
