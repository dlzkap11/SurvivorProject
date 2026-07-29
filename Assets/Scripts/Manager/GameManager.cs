using UnityEngine;

public class GameManager
{
    public PlayerController player;
    public GameObject Player;

    public void GetPlayer()
    {
        Player = GameObject.FindWithTag("Player");
        player = Player.GetComponent<PlayerController>();
    }
}
