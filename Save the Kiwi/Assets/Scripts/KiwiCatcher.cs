using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KiwiCatcher : MonoBehaviour {
    public Rigidbody kiwi;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
// OnCollisionEnter(kiwi);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Kiwi Cube")
        {
            kiwi.velocity = new Vector3(0, 10, 0);
            //kiwi.useGravity = false;
        }
    }
}
