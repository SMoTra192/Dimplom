using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float playerSpeed;
    void Update()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * playerSpeed, _rigidbody.velocity.y,
            _joystick.Vertical * playerSpeed);
    }
}
