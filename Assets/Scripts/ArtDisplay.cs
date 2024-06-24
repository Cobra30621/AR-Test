using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ArtDisplay : MonoBehaviour
{
    public GameObject light, blueTear;

    public VideoPlayer SunVideoPlayer;

    private void Awake()
    {
        SunVideoPlayer.Prepare();
        
    }


    public void ShowSun()
    {
        SunVideoPlayer.gameObject.SetActive(true);
        StartCoroutine(SunCoroutine());
    }
    
    private IEnumerator SunCoroutine()
    {
        SunVideoPlayer.Play();
        
        yield return new WaitUntil(()=>SunVideoPlayer.frame == 300);
        SunVideoPlayer.Pause();
        SunVideoPlayer.gameObject.SetActive(false);
    }
    
    
    public void ShowLight(bool show)
    {
        light.SetActive(show);
        StartCoroutine(LightCoroutine());
    }

    private IEnumerator LightCoroutine()
    {   
        
        yield return new WaitForSeconds(5f);
        light.SetActive(false);
    }


    public void ShowBlueTear(bool show)
    {
        
        StartCoroutine(BlueTearCoroutine());
    }
    
    private IEnumerator BlueTearCoroutine()
    {
        blueTear.SetActive(true);
        
        yield return new WaitForSeconds(5f);
        blueTear.SetActive(false);
    }
}
