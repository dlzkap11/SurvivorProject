using UnityEngine;

[CreateAssetMenu(fileName = "NewPlayerData", menuName = "Game/Player Data")]
public class PlayerData : ScriptableObject
{
    [Header("Name")]
    public new string name;

    [Header("Stat")]
    public int level;
    public float speed;
    public int maxHp;
    public int atk;
    public int def;
    public int maxExp;
}
