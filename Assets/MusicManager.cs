using UnityEngine.Audio;
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
            
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
