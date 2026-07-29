using System.Collections;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{

    [SerializeField] private PlayerData _data;

    [SerializeField] private int _level;
    [SerializeField] private int _hp;
    [SerializeField] private int _exp;


    private SpriteRenderer _sr;
    public float Speed { get; private set; }

    private Coroutine _blinkCoroutine;

    private void Awake()
    {
        _level = _data.level;
        _hp = _data.maxHp;
        _exp = 0;
        Speed = _data.speed;
        _sr = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Wall")) return;
        if (_blinkCoroutine != null) return;

        _blinkCoroutine = StartCoroutine(BlinkRoutine());
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (_blinkCoroutine != null)
        {
            StopCoroutine(_blinkCoroutine);
            _blinkCoroutine = null;
            _sr.enabled = true;
        }
    }

    private IEnumerator BlinkRoutine()
    {
        WaitForSeconds wait = new WaitForSeconds(0.15f);
        while (true)
        {
            _sr.enabled = !_sr.enabled;
            yield return wait;
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
