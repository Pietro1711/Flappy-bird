using FlappyBird.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestReceiver : NvpAbstractEventHandler
{
    protected override void SubscribeToEvents()
    {
        EventController.SubscribeToEvent(NvpGameEvents.OnDebugMsg, OnDebugMsg);
    }

    private void OnDebugMsg(object arg1, object arg2)
    {
        Debug.Log(arg2);
    }

    protected override void UnsubscribeFromEvents()
    {
        EventController.UnsubscribeFromEvent(NvpGameEvents.OnDebugMsg, OnDebugMsg);
    }

    
}
