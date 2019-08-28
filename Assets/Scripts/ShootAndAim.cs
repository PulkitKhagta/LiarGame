using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAndAim : MonoBehaviour
{
    public GameObject shot;
    private Transform GunPos;

    private void Start()
    {
        GunPos = GetComponent<Transform>();
    }

    private void Update()
    {
        faceCursor();
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(shot, GunPos.position, Quaternion.identity);
        }
    }

    void faceCursor()
    {
        Vector2 CursorPos = Input.mousePosition;
        CursorPos = Camera.main.ScreenToWorldPoint(CursorPos);

        Vector2 Direction = new Vector2(
            CursorPos.x - transform.position.x,
            CursorPos.y - transform.position.y
            );

        transform.right = Direction;
        
    }
}
