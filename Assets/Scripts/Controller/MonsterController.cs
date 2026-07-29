using UnityEngine;

public class MonsterController : MonoBehaviour
{
    // 몬스터 기본 움직임 플레이어를 찾고 따라가기

    [SerializeField] private SpriteRenderer _sr;
    [SerializeField] private GameObject _player;
    MonsterStat _stat;

    private void Awake()
    {
        _sr = GetComponent<SpriteRenderer>();
        
    }

    void Start()
    {
        //TODO 더 좋은 찾는 방법을 찾으면 바꾸기 - Find는 효율적이지는 않는 것으로 앎
        _player = GameObject.FindWithTag("Player");
        /*
        if (_player != null)
        {
            _player = GameObject.FindWithTag("Player");
        }
        */

        _stat = GetComponent<MonsterStat>();
    }

    
    void Update()
    {
        ChasePlayer();
    }

    void ChasePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, _player.transform.position, _stat.Speed * Time.deltaTime);

        // 플레이어 방향으로 방향전환
        float direction = _player.transform.position.x - transform.position.x;

        if (direction != 0)
            _sr.flipX = direction > 0;

        //TODO 애니메이션
        //animator.Play(MoveHash);
        //animator.SetFloat("OnMove", 1f);
    }
}
