using UnityEngine;
using System.Collections;
[RequireComponent( typeof( AudioSource ) )]
public class SoundBase : MonoBehaviour {
	public static SoundBase Instance;
	public AudioClip click;
	public AudioClip[] swish;
 	public AudioClip[] drop;
 	public AudioClip alert;
 	public AudioClip timeOut;
 	public AudioClip[] star;
 	public AudioClip[] gameOver;
 	public AudioClip cash;

 	public AudioClip[] destroy;
 	public AudioClip boostBomb;
 	public AudioClip boostColorReplace;
 	public AudioClip explosion;
 	public AudioClip getStarIngr;
 	public AudioClip strippedExplosion;
 	public AudioClip[] complete;
 	public AudioClip block_destroy;
 	public AudioClip wrongMatch;
 	public AudioClip noMatch;
 	public AudioClip appearStipedColorBomb;
 	public AudioClip appearPackage;
 	public AudioClip destroyPackage;
 	public AudioClip colorBombExpl;

    ///SoundBase.Instance.audio.PlayOneShot( SoundBase.Instance.kreakWheel );

   // Use this for initialization
	void Awake () {
		DontDestroyOnLoad(gameObject);
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
