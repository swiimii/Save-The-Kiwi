using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainsawAudioRandomizer : MonoBehaviour {

    public AudioSource source1;
    public AudioSource source2;
    public AudioSource source3;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!source1.isPlaying && !source2.isPlaying && !source3.isPlaying)
        {
            var num = Random.Range(0, 3);
            if (num == 0)
            {
                source1.Play();
            }
            else if (num == 1)
            {
                source2.Play();
            }
            else if (num == 2)
            {
                source3.Play();
            }
        }
		
	}
}
