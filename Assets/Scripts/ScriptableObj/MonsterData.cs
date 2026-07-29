using UnityEngine;

[CreateAssetMenu(fileName = "NewMonsterData", menuName = "Game/Monster Data")]
public class MonsterData : ScriptableObject
{
    [Header("Stat")]
    public int level;
    public float speed;
    public int maxHp;
    public int damage;

}
