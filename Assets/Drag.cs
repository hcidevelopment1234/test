using UnityEngine;
using System.Collections;

public class Drag : MonoBehaviour {

    private Vector3 screenPoint;
    private Vector3 offset;

    void Start()
    {
        Debug.Log("drag script");

    }

    void OnMouseDown()
    {
        Debug.Log("Mouse down");
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Debug.Log("Dragging");
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }

    
}
