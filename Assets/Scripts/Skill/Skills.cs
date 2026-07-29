using UnityEngine;

public class Skills : MonoBehaviour
{
    //ScriptsObj로 만들어서 받아와도 괜춘
    
    protected int _damage;
    protected Transform _owner; //스킬 시전자
    protected Transform _target; // 특정 대상을 목표로 한다면

    public virtual void Initialize(Transform owner, Transform target = null)
    {
        //TODO 생성할 때 시전자랑 타겟 받아오기
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
