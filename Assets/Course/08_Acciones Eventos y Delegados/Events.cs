using UnityEngine;
using UnityEngine.Events;

namespace Course.AccionesEventosDelegados
{
    public class Events : MonoBehaviour
    {
        // Event
        public delegate void MyDelegateEvent();

        //public MyDelegateEvent myDelegateEventVar; // Delegate
        public event MyDelegateEvent myEventVar; // Event

        // UnityEvents
        public UnityEvent myUnityEventVar;
        public UnityEvent<bool> myUnityEventOneParamVar;
        public UnityEvent<bool, int, string> myUnityEventThreeParamVar;

        private void Start()
        {
            // Event
            myEventVar += PrintMessage;
            //myEventVar();
            //myEventVar.Invoke();

            // UnityEvents
            myUnityEventVar.AddListener(PrintMessage); // +=
            myUnityEventVar.RemoveListener(PrintMessage); // -=
            myUnityEventVar.Invoke();

            myUnityEventOneParamVar.Invoke(true);
            myUnityEventThreeParamVar.Invoke(true, 5, "Test");
        }

        private void PrintMessage()
        {
            Debug.Log("Hello World!");
        }
    }
}
