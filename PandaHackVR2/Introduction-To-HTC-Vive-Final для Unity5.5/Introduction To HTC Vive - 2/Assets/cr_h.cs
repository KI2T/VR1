using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cr_h : MonoBehaviour {

    public Rigidbody newelem;
    public Transform NEW_ELEM;


    void OnTriggerEnter()
    {
        Instantiate(newelem, NEW_ELEM.position, NEW_ELEM.rotation);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
