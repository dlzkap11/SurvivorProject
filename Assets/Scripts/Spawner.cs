using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private ObjectPool objpool;
    [SerializeField] float radius; //스폰 범위
    [SerializeField] GameObject monsterPrefab; //소환할 몬스터

    void Start()
    {
        transform.position = _player.position;
    }
   

    void Update()
    {
        // 스폰 위치는 중앙을 기준으로 원

        //TODO 시간이 지나면 알아서 생성하기 + 옵젝풀링으로 만들기
        if (Input.GetKeyDown(KeyCode.K))
        {
            GameObject go = objpool.GetObj();

            float rad = Random.Range(0f, 360f);
            float x = radius * Mathf.Sin(rad);
            float y = radius * Mathf.Cos(rad);
            go.transform.position = transform.position + new Vector3(x, y);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
