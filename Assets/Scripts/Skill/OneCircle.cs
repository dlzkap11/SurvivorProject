using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
public class OneCircle : Skills
{
    // 플레이어 주변을 돌아가는 투사체
    public Transform centerPoint;
    [SerializeField] private List<GameObject> circle;

    private void Awake()
    {
        
    }

    void Start()
    {

        //생성될 때 플레이어에게 종속시키기?
        transform.position = GetComponentsInParent<Transform>()[1].position;
        //transform.position = GetComponentInParent<Transform>().position; // 본인 Transform가져옴;; 에바

        //transform.position = centerPoint.position; //TODO 나중에 centerPoint 받아오기
    }

    

    void Update()
    {
        Circling();
    }

    [SerializeField] private float circleR;
    [SerializeField] private float deg;
    [SerializeField] private float objSpeed;

    public void Circling()
    {
        deg += Time.deltaTime * objSpeed;
        if (deg < 360)
        {
            for (int i = 0; i < circle.Count; i++)
            {
                float rad = Mathf.Deg2Rad * (deg + (i * (360 / circle.Count)));
                float x = circleR * Mathf.Sin(rad);
                float y = circleR * Mathf.Cos(rad);
                circle[i].transform.position = transform.position + new Vector3(x, y);
                circle[i].transform.rotation = Quaternion.Euler(0, 0, (deg + (i * (360 / circle.Count))) * -1);
            }

        }
        else
        {
            deg = 0;
        }
    }
}
