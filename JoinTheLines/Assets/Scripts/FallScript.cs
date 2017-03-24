using UnityEngine;
using System.Collections;

public class FallScript : MonoBehaviour {
    public GameObject Plane;
    public GameObject SpawnPoint;

    void Start()
    {

    }

    void Update ()
    {
        if(transform.position.y < Plane.transform.position.y - 10)
        {
            transform.position = SpawnPoint.transform.position;
        }
    }	
}
