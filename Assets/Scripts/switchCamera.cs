﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.LSL4Unity.Scripts;

public class switchCamera : MonoBehaviour {
    public static int difficulty = 0;
    private LSLMarkerStream marker;
    public static int modulesSolved = 0;
    public AudioClip explosionClip;
    public AudioSource explosion;
    private Scene currentScene;
    private string sceneName;
    private bool stop;

    void Start()
    {
        stop = false;
        modulesSolved = 0;
        marker = FindObjectOfType<LSLMarkerStream>();
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
        if(sceneName == "Keep Talking Nobody Explodes test")
        {
            difficulty = 4;
        }
        if (sceneName == "Keep Talking Nobody Explodes test 2")
        {
            difficulty = 5;
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
        if (sceneName == "Keep Talking Nobody Explodes easy" && modulesSolved >= 4 && !stop)
        {
            marker.Write("easy ends");
            Debug.Log("easy ends");
            stop = true;
            countdown.mainTimer = 300;
            destroyClones();
            SteamVR_LoadLevel.Begin("Win");
        }
        if (sceneName == "Keep Talking Nobody Explodes medium" && modulesSolved >= 6 && !stop)
        {
            marker.Write("medium ends");
            Debug.Log("medium ends");
            stop = true;
            countdown.mainTimer = 200;
            destroyClones();
            SteamVR_LoadLevel.Begin("Win");
            //sceneName = "";
        }
        if (sceneName == "Keep Talking Nobody Explodes hard" && modulesSolved >= 8 && !stop)
        {
            marker.Write("hard ends");
            Debug.Log("hard ends");
            stop = true;
            countdown.mainTimer = 10;
            ventingcountdown.mainVentTimer = 60.0f;
            ventingwarning.delay = true;
            destroyClones();
            SteamVR_LoadLevel.Begin("Win");
        }
        if (sceneName == "Keep Talking Nobody Explodes test" && modulesSolved >= 2)// greater than or equal to 2 modules so player cant win and skip session
        {
            countdown.mainTimer = 10;
            ventingcountdown.mainVentTimer = 60.0f;
            ventingwarning.delay = true;
            destroyClones();
            SteamVR_LoadLevel.Begin("Win");
        }
        if (sceneName == "Keep Talking Nobody Explodes test 2" && modulesSolved >= 2) // greater than or equal to 2 modules so player cant win and skip session
        {
            countdown.mainTimer = 10;
            ventingcountdown.mainVentTimer = 60.0f;
            ventingwarning.delay = true;
            destroyClones();
            SteamVR_LoadLevel.Begin("Win");
        }
        if (sceneName == "Keep Talking Nobody Explodes easy" && !stop && countdown.mainTimer <= 0 || mistakes.mistakeNum >= 3) //"explosion" switch camera scene for easy
        {
            if (explosion.isPlaying == false)
            {
                explosion.Play();
            }
            marker.Write("easy ends");
            Debug.Log("easy game ends");
            stop = true;
            countdown.mainTimer = 10;
            destroyClones();
            SteamVR_LoadLevel.Begin("Lose");
        }
        if (sceneName == "Keep Talking Nobody Explodes medium" && !stop && countdown.mainTimer <= 0 || mistakes.mistakeNum >= 3) //"explosion" switch camera scene for medium
        {
            if (explosion.isPlaying == false)
            {
                explosion.Play();
            }
            marker.Write("medium ends");
            Debug.Log("medium game ends");
            stop = true;
            countdown.mainTimer = 10;
            destroyClones();
            SteamVR_LoadLevel.Begin("Lose");
        }
        if (sceneName == "Keep Talking Nobody Explodes hard" && !stop && countdown.mainTimer <= 0 || mistakes.mistakeNum >= 3) //"explosion" switch camera scene for hard
        {
            if (explosion.isPlaying == false)
            {
                explosion.Play();
            }
            marker.Write("hard ends");
            Debug.Log("hard game ends");
            stop = true;
            countdown.mainTimer = 10;
            destroyClones();
            SteamVR_LoadLevel.Begin("Lose");
        }
        //if (mistakes.mistakeNum >= 3 || countdown.mainTimer <= 0 || ventingcountdown.mainVentTimer <= 0) for real game
        /*if (countdown.mainTimer <= 0) //for experiment, so sessions are accurate
        {
            if (explosion.isPlaying == false)
            {
                explosion.Play();
            }
            destroyClones();
            ventingcountdown.mainVentTimer = 60.0f;
            ventingwarning.delay = true;
            if (sceneName == "Keep Talking Nobody Explodes test 2" && !stop)
            {
                marker.Write("2 min end");
                stop = true;
                SteamVR_LoadLevel.Begin("Lose");

            }
            else if (sceneName == "Keep Talking Nobody Explodes test" && !stop)
            {
                marker.Write("20 sec end");
                stop = true;
                SteamVR_LoadLevel.Begin("Lose");
            }
        } */
    }
}
