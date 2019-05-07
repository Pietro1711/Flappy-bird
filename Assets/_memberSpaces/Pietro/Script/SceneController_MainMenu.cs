using FlappyBird.Events;
using System;
using System.Threading.Tasks;

public class SceneController_MainMenu : NvpAbstractEventHandler
{

     async void Start()
    {
        // Wait for all general scripts to be initialized
        await Task.Delay(TimeSpan.FromSeconds(1));

        EventController.InvokeEvent(NvpGameEvents.OnDebugMsg, this, 42);
    }

    protected override void SubscribeToEvents()
    {
        
    }

    protected override void UnsubscribeFromEvents()
    {
        
    }

}
