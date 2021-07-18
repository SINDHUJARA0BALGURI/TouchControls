using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControlls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Debug.Log(Input.GetTouch(0).position);
            Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Debug.Log(ray.origin);
            Debug.DrawLine(ray.origin, ray.direction * 10, Color.red);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                Debug.Log("hit something");
                Debug.Log(hit.transform.gameObject);
            }
        }
    }
}