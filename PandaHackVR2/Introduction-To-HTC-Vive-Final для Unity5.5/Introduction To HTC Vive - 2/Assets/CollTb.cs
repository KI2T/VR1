using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollTb : MonoBehaviour {

    public Rigidbody RwCube;
    public Transform cell;


    void OnTriggerEnter(Collider ControllerRight)
    {
        Instantiate(RwCube, cell.position, cell.rotation);  
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
