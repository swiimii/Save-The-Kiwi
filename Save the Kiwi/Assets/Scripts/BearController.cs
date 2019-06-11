using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearController : MonoBehaviour {

    // Use this for initialization
    Rigidbody bear;
    bool finished = false;
    public Rigidbody tree;
    public Rigidbody kiwi;
	void Start () {
        bear = GetComponent<Rigidbody>();
	}
    private void FixedUpdate()
    {
        if(finished == false)
            bear.position = Vector3.MoveTowards(bear.position, tree.position, .05f);
    }
    // Update is called once per frame
    void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Tree")
        {
            kiwi.constraints = RigidbodyConstraints.None;
            finished = true;
        }
    }

}
