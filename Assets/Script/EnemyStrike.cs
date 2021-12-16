using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStrike : MonoBehaviour
{
    public string colname;
    public Vector2 worldObjectPosition;
    public Vector2 mouseDragPosition;
    public static Vector2 PrefabPos;
    Animator ani;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        
    }

    private IEnumerator OnMouseDrag() // 콜리더를 누르고있을떄 호출
    {
            if (Input.GetMouseButton(0))
            {
                PrefabPos = this.transform.position;
                mouseDragPosition = new Vector2(Input.mousePosition.x,
                    Input.mousePosition.y);// 위치 마우스 x,y값 좌표로 저장
                worldObjectPosition = Camera.main.ScreenToWorldPoint(mouseDragPosition);
                //월드 포지션을 내가 보고있는 카메라 시점으로 저장
                this.transform.position = worldObjectPosition; //계속 포지션 호출
            yield return null;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        GameObject.Find("GM").GetComponent<GM>().minigameStart();
        Destroy(gameObject);
    }
}


