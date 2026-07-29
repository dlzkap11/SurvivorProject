using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //플레이어 이동 관련 로직
    //TODO 이동 애니메이션, 및 사운드
    private Rigidbody2D _rb;
    [SerializeField] private Vector2 _inputVec;
    [SerializeField] private float _speed;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rb.linearVelocity = _inputVec.normalized * _speed;
    }

    void OnMove(InputValue value)
    {
        _inputVec = value.Get<Vector2>();
    }

}
