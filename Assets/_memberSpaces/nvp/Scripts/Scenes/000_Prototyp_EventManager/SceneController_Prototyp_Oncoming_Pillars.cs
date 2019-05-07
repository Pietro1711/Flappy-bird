using nvp_AbstractBaseClasses;
using nvp.Tools.Events;

namespace nvp.Prototypes.Prototy_000
{
    public class SceneController_Prototyp_Oncoming_Pillars : NvpAbstractEventHandler
    {
        // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++




        // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        void Awake()
        {
            SubscribeToEvents();
        }

        void Start()
        {
            EventController.InvokeEvent(NvpGameEvents.OnDebugMsg, this, "Hello, World!");
        }


        void Update()
        {

        }




        // +++ event handler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        protected override void OnDisable()
        {
            base.OnDisable();
            UnsubscribeFromEvents();
        }




        // +++ class member +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        protected override void SubscribeToEvents()
        {

        }

        protected override void UnsubscribeFromEvents()
        {

        }
    }
}
