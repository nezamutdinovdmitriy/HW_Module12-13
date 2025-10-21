using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    private const KeyCode JUMP_KEY = KeyCode.Space;

    public Vector3 Direction { get; private set; }
    public bool IsMoving { get; private set; }
    public bool IsJumping { get; private set; }
    public bool IsGrounded { get; private set; }

    private void Update()
    {
        Direction = new Vector3(Input.GetAxisRaw(HORIZONTAL), 0, Input.GetAxisRaw(VERTICAL));

        IsMoving = Direction != Vector3.zero;

        if (Input.GetKeyDown(JUMP_KEY) && IsGrounded)
            IsJumping = true;
    }

    private void OnCollisionStay(Collision collision) => IsGrounded = true;

    private void OnCollisionExit(Collision collision) => IsGrounded = false;

    public void ResetIsJumpingState() => IsJumping = false;
}
