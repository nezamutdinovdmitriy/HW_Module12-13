using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    private const KeyCode JUMP_KEY = KeyCode.Space;

    public Vector3 Direction { get; private set; }
    public bool IsMoving { get; private set; }
    public bool IsJumpingKeyPressed { get; private set; }

    private void Update()
    {
        Direction = new Vector3(Input.GetAxisRaw(HORIZONTAL), 0, Input.GetAxisRaw(VERTICAL));

        IsMoving = Direction != Vector3.zero;

        IsJumpingKeyPressed = Input.GetKeyDown(JUMP_KEY);
    }
}
