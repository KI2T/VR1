using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_connection : MonoBehaviour {

        public Rigidbody newelem;
        public Transform lastpos;


        void OnTriggerEnter()
        {
            Instantiate(newelem, lastpos.position, newelem.rotation);

        }



        // Use this for initialization
        void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
