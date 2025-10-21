using System.Collections;
using System.Collections.Generic;
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

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (_inputHandler.IsMoving)
            _rigidbody.AddForce(_characterRotator.CameraDirection * _force, ForceMode.Impulse);

        if (_inputHandler.IsMoving == false && _inputHandler.IsGrounded)
            _rigidbody.velocity *= 0.5f;

        if (_inputHandler.IsJumping)
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _inputHandler.ResetIsJumpingState();
        }
    }
}
