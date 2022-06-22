using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float PlayerPositionYAxis;
    Vector3 mouseScreenPosition;
    Vector3 mouseWorldPosition;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPositionYAxis = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        mouseScreenPosition = Input.mousePosition;
        mouseScreenPosition.z = Camera.main.nearClipPlane;
        // Debug.Log(mouseScreenPosition.y);
        mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        mouseWorldPosition.y = PlayerPositionYAxis;
        transform.position = mouseWorldPosition;
    }
}
