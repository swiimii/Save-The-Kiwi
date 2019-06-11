using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishCheck : MonoBehaviour {

    // Use this for initialization
    bool finished = false;
    public GameObject VictoryScreen;
    public GameObject FailureScreen;
    

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(finished == true)
        {
            if(Input.GetKeyUp("r"))
            {
                SceneManager.LoadScene("Level 1");
            }
            else if(Input.GetKeyUp("escape"))
            {
                Application.Quit();
            }
        }
	}

    private void OnCollisionEnter(Collision col)
    {
        if (finished == false)
        {
            if (col.gameObject.tag == "Floor")
            {
                finished = true;
                FailureScreen.SetActive(true);
                
            }
            else if (col.gameObject.tag == "Trampoline")
            {
                finished = true;
                VictoryScreen.SetActive(true);
            }
        }
    }
}
