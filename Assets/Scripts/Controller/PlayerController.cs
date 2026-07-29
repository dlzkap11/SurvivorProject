using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //플레이어 이동 관련 로직
    //TODO 이동 애니메이션, 및 사운드
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    private Animator _ani;

    public Vector2 InputVec { get; private set; }
    private PlayerStat _stat;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _ani = GetComponent<Animator>();
    }

    private void Start()
    {
        _stat = GetComponent<PlayerStat>();
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = InputVec.normalized * _stat.Speed;
    }

    private void Update()
    {
        
    }

    void OnMove(InputValue value)
    {
        InputVec = value.Get<Vector2>();
        if (InputVec.x == 0 && InputVec.y == 0)
        {
            _ani.Play("Idle");
            return;
        }
            


        _ani.Play("Move");
        if (InputVec.x > 0)
        {
            _sr.flipX = true;
        }
        else if (InputVec.x < 0)
        {
            _sr.flipX = false;
        }
        else
        {
        }
    }

}
