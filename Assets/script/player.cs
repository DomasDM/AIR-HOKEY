using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    public float  speed=10;
    Camera cam;
    Rigidbody2D rb;
    private Vector3 worldPos;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        cam = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        worldPos= cam.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
       // transform.position= worldPos;
       rb.MovePosition(worldPos);

    }
    private void FixedUpdate()
    {
        var targetPos = Vector2.MoveTowards(rb.position, worldPos,speed* Time.deltaTime);
        rb.MovePosition(targetPos);
    }
}
