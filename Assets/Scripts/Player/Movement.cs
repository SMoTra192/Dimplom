using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField] private GiveBoost _giveBoost;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private float playerSpeed;
    
    private float constPlayerSpeed,constTimeForBoostOut;
    private float boostValue; 
    private float timeForBoostOut;
    private bool isBoosted = false
        ,isGetBoost = false;

    private void Awake()
    {
        _giveBoost.GetComponent<GiveBoost>();
        
        timeForBoostOut = _giveBoost.getTimeforboostout();
        boostValue = _giveBoost.getBoostValue();
        
        constTimeForBoostOut = timeForBoostOut;
        constPlayerSpeed = playerSpeed;
        
        _giveBoost.TakenBoost.AddListener(() =>
            {
                timeForBoostOut = constTimeForBoostOut;
                if (isGetBoost == false)
                {
                    print("boosted");
                    isBoosted = true;
                    getBoost();
                    isGetBoost = true;
                }
            }
            );
    }

    private void getBoost()
    {
        playerSpeed *= boostValue;
    }
    

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
        
        if (timeForBoostOut > 0 && isBoosted == true)
        {
            timeForBoostOut -= Time.deltaTime;
        }
        else
        {
            isGetBoost = false;
            isBoosted = false;
            playerSpeed = constPlayerSpeed;
            timeForBoostOut = constTimeForBoostOut;
        }
    }
}
