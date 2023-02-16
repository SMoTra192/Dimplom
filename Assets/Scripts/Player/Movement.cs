using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private float playerSpeed;
    void Update()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * playerSpeed, _rigidbody.velocity.y,
            _joystick.Vertical * playerSpeed);
        if (_joystick.Horizontal != 0 && _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("isRunning",true );
        }
        else
        {
            _animator.SetBool("isRunning",false);
            
        } 
    }
}
