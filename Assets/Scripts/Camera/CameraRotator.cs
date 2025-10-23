using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    private const string MOUSE_AXIS_NAME_X = "Mouse X";
    private const string MOUSE_AXIS_NAME_Y = "Mouse Y";

    [SerializeField] private float _sensetivity;
    [SerializeField] private float _cameraClamp;

    private float _aroundXRotation;
    private float _aroundYRotation;

    private void Awake()
    {
        _aroundXRotation = transform.eulerAngles.x;
        _aroundYRotation = transform.eulerAngles.y;
    }

    private void FixedUpdate()
    {
        float mouseDeltaX = Input.GetAxis(MOUSE_AXIS_NAME_X) * _sensetivity;
        float mouseDeltaY = Input.GetAxis(MOUSE_AXIS_NAME_Y) * _sensetivity;

        _aroundXRotation += mouseDeltaX;
        _aroundYRotation += mouseDeltaY;

        _aroundYRotation = Mathf.Clamp(_aroundYRotation, -_cameraClamp, _cameraClamp);

        Quaternion rotation = Quaternion.Euler(-_aroundYRotation, _aroundXRotation, 0);

        transform.rotation = rotation;
    }
}
