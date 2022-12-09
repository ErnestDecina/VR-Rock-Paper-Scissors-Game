using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class userInterfaceFollower : MonoBehaviour
{
    public GameObject headCamera;

    // Variables
    private GameObject obj;
    private float distance = 0;
    private float distanceOutAdjust;


    // Start is called before the first frame update
    void Start()
    {
        obj = GetComponent<GameObject>();
        transform.position = new Vector3(transform.position.x, headCamera.transform.position.y, transform.position.z);
        distance = 36;
        distanceOutAdjust = 60;
    }

    private void Update()
    {
        if(!obj.activeSelf)
        {
            matchAxis();
        }
    }

    void matchAxis()
    {
        transform.position = new Vector3(transform.position.x, headCamera.transform.position.y, transform.position.z);
    }
}
