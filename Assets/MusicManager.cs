using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public Song[] songs;

	// Use this for initialization
	void Start () {
		foreach(Song s in songs)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.Play();
            while (s.source.isPlaying)
            {

            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
