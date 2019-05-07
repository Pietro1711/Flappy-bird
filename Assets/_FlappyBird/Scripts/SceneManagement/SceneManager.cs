using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FlappyBird.Events;
using System;

public class SceneManager : NvpAbstractEventHandler
{
    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    
    

    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        
    }




    // +++ event handler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private void OnGameInitialized(object arg1, object arg2)
    {
        Debug.Log("OnGameInitialized called");
    }

    private void OnMainStarted(object arg1, object arg2)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("_FlappyBird/Scenes/02_Hauptmenu", UnityEngine.SceneManagement.LoadSceneMode.Additive);
    }



    // +++ class member +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    protected override void SubscribeToEvents()
    {
        EventController.SubscribeToEvent(NvpGameEvents.OnGameInitialized, OnGameInitialized);
        EventController.SubscribeToEvent(NvpGameEvents.OnMainStarted, OnMainStarted);
    }

    

    protected override void UnsubscribeFromEvents()
    {
        EventController.SubscribeToEvent(NvpGameEvents.OnGameInitialized, OnGameInitialized);
        EventController.SubscribeToEvent(NvpGameEvents.OnMainStarted, OnMainStarted);

    }

}
