using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public static AudioClip CAudio, CSharpAudio, DAudio, DSharpAudio, EAudio, FAudio, FSharpAudio, GAudio, GSharpAudio, AAudio, ASharpAudio, BAudio;
    static AudioSource audioSRC;

	// Use this for initialization
	void Start () {

        CAudio = Resources.Load<AudioClip>("CAudio");
        CSharpAudio = Resources.Load<AudioClip>("CSharpAudio");
        DAudio = Resources.Load<AudioClip>("DAudio");
        DSharpAudio = Resources.Load<AudioClip>("DSharpAudio");
        EAudio = Resources.Load<AudioClip>("EAudio");
        FAudio = Resources.Load<AudioClip>("FAudio");
        FSharpAudio = Resources.Load<AudioClip>("FSharpAudio");
        GAudio = Resources.Load<AudioClip>("GAudio");
        GSharpAudio = Resources.Load<AudioClip>("GSharpAudio");
        AAudio = Resources.Load<AudioClip>("AAudio");
        ASharpAudio = Resources.Load<AudioClip>("ASharpAudio");
        BAudio = Resources.Load<AudioClip>("BAudio");




        audioSRC = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "CPlayed":
                audioSRC.PlayOneShot(CAudio);
                break;
            case "CSharpPlayed":
                audioSRC.PlayOneShot(CSharpAudio);
                break;
            case "DPlayed":
                audioSRC.PlayOneShot(DAudio);
                break;
            case "DSharpPlayed":
                audioSRC.PlayOneShot(DSharpAudio);
                break;
            case "EPlayed":
                audioSRC.PlayOneShot(EAudio);
                break;
            case "FPlayed":
                audioSRC.PlayOneShot(FAudio);
                break;
            case "FSharpPlayed":
                audioSRC.PlayOneShot(FSharpAudio);
                break;
            case "GPlayed":
                audioSRC.PlayOneShot(GAudio);
                break;
            case "GSharpPlayed":
                audioSRC.PlayOneShot(GSharpAudio);
                break;
            case "APlayed":
                audioSRC.PlayOneShot(AAudio);
                break;
            case "ASharpPlayed":
                audioSRC.PlayOneShot(ASharpAudio);
                break;
            case "BPlayed":
                audioSRC.PlayOneShot(BAudio);
                break;
        }
    }
}
