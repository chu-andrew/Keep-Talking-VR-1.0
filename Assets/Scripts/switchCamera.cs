using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchCamera : MonoBehaviour {
    public static int difficulty = 0;
    public static int modulesSolved = 0;
    public AudioClip explosionClip;
    public AudioSource explosion;
    private Scene currentScene;
    private string sceneName;

    void Start()
    {
        modulesSolved = 0;
        explosion.clip = explosionClip;
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (sceneName == "Keep Talking Nobody Explodes easy")
        {
            difficulty = 1;
        }
        if (sceneName == "Keep Talking Nobody Explodes medium")
        {
            difficulty = 2;
        }
        if (sceneName == "Keep Talking Nobody Explodes hard")
        {
            difficulty = 3;
        }
    }
    private void destroyClones()
    {
        var clones = GameObject.FindGameObjectsWithTag("destroy");
        foreach (var clone in clones)
        {
            Destroy(clone);
        }
    }

    private GameObject FindGameObjectsWithTag(string v)
    {
        throw new NotImplementedException();
    }

    private void Update()
    {
        if (sceneName == "Keep Talking Nobody Explodes easy" && modulesSolved >= 4)
        {
            countdown.mainTimer = 300;
            destroyClones();
            SteamVR_LoadLevel.Begin("Win");
        }
        if (sceneName == "Keep Talking Nobody Explodes medium" && modulesSolved >= 6)
        {
            countdown.mainTimer = 200;
            destroyClones();
            SteamVR_LoadLevel.Begin("Win");
        }
        if (sceneName == "Keep Talking Nobody Explodes hard" && modulesSolved >= 8)
        {
            countdown.mainTimer = 100;
            ventingcountdown.mainVentTimer = 60.0f;
            ventingwarning.delay = true;
            destroyClones();
            SteamVR_LoadLevel.Begin("Win");
        }
        if (mistakes.mistakeNum >= 3 || countdown.mainTimer <= 0 || ventingcountdown.mainVentTimer <= 0)
        {
            if (explosion.isPlaying == false)
            {
                explosion.Play();
            }
            destroyClones();
            ventingcountdown.mainVentTimer = 60.0f;
            ventingwarning.delay = true;
            SteamVR_LoadLevel.Begin("Lose");
        }
    }
}
