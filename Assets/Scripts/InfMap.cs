using UnityEngine;

public class InfMap : MonoBehaviour
{

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Area"))
            return;


        Vector3 playerPos = Managers.Game.player.transform.position;
        Vector3 mapPos = transform.position;



        float dirX = playerPos.x - mapPos.x;
        float dirY = playerPos.y - mapPos.y;

        float diffX = Mathf.Abs(dirX);
        float diffY = Mathf.Abs(dirY);

        dirX = dirX > 0 ? 1 : -1;
        dirY = dirY > 0 ? 1 : -1;

        switch (transform.tag)
        {
            case "Ground":
                if (Mathf.Abs(diffX - diffY) <= 0.5f)
                {
                    transform.Translate(Vector3.up * dirY * 40);
                    transform.Translate(Vector3.right * dirX * 40);
                    Debug.Log($"{transform.name} : 대각선 이동");
                }
                else if(diffX > diffY)
                {
                    transform.Translate(Vector3.right * dirX * 40);
                    Debug.Log($"{transform.name} : 좌우 이동");
                }
                else if (diffX < diffY)
                {
                    transform.Translate(Vector3.up * dirY * 40);
                    Debug.Log($"{transform.name} : 상하 이동");
                }
                break;
            case "Enemy":
                break;

        }

    }
}

