using UnityEngine;

public class MonsterStat : MonoBehaviour
{
    [SerializeField] private MonsterData _data;

    [SerializeField] private int _level;
    [SerializeField] private int _hp;
    public float Speed { get; private set; }

    private void Awake()
    {
        _level = _data.level;
        _hp = _data.maxHp;
        Speed = _data.speed;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
