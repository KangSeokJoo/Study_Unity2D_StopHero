using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EnemyStrike : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler {

    public static Vector2 PrePafsPos; // 드롭하면
    public GameObject bullet = null;
    public static Vector2 returnToPos;


    // Use this for initialization
    void Start () {

	}

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator OnMouseDrag()
    {
        while (Input.GetMouseButton(0))
        {
            Vector2 mouseDragPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 worldObjectPosition = Camera.main.ScreenToWorldPoint(mouseDragPosition);
            this.transform.position = worldObjectPosition;
            yield return null;
        }
    }

    public void OnBeginDrag(PointerEventData eventData) //드래그 시작할때
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(bullet, transform.position, transform.rotation);
            PrePafsPos = this.transform.position;   // 프리팹 포지션 저장
        }
        returnToPos = this.transform.position; // 이건 원래 본체가 프리팹 위치로 돌아갔으면해서 만든 변수이름
        
    }

    public void OnDrag(PointerEventData eventData) // 드래그 중일 때
    {
        Vector2 currentPos = Input.mousePosition;
        this.transform.position = currentPos;
    }

    public void OnEndDrag(PointerEventData eventData) // 드래그 끝났을때
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }
}