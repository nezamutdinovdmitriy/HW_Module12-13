using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CharacterMover : MonoBehaviour
{

    [SerializeField] private InputHandler _inputHandler;
    [SerializeField] private CharacterRotator _characterRotator;

    [SerializeField] private float _force;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _speedRotation;

    private Rigidbody _rigidbody;
    private bool _isJumping;
    private bool _isGrounded;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(_inputHandler.IsJumpingKeyPressed && _isGrounded)
            _isJumping = true;
    }

    private void FixedUpdate()
    {
        if (_inputHandler.IsMoving)
            Move();

        if (_isJumping)
            Jump();
    }

    private void Move() => _rigidbody.AddForce(_characterRotator.CameraDirection * _force, ForceMode.Impulse);

    private void Jump()
    {
        _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        _isJumping = false;
    }
    private void OnCollisionStay(Collision collision) => _isGrounded = true;
    private void OnCollisionExit(Collision collision) => _isGrounded = false;
}
