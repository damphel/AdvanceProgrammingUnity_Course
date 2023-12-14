using UnityEngine;

namespace Course.AccionesEventosDelegados
{
    public class Delegates : MonoBehaviour
    {
        // Void
        public delegate void MyDelegate();
        public MyDelegate myDelegateVar;

        // Return
        public delegate int MyDelegateInt();
        public MyDelegateInt myDelegateIntVar;

        // Params
        public delegate void MyDelegateOneParam(string myString);
        public MyDelegateOneParam myDelegateOneParamVar;

        // Multicast
        public delegate void MyDelegateMulticast();
        public MyDelegateMulticast myDelegateMulticastVar;

        // Callback
        public delegate void MyDelegateCallback(bool success);
        public MyDelegateCallback myDelegateCallbackVar;

        private void Start()
        {
            // Void
            myDelegateVar = PrintMessage;
            //myDelegateVar();
            //myDelegateVar.Invoke();

            // Return
            myDelegateIntVar = GetWeaponId;
            int myWeapon;
            //myWeapon = myDelegateIntVar();
            //myWeapon = myDelegateIntVar.Invoke();

            // Params
            myDelegateOneParamVar = PrintMessageWithValue;
            //myDelegateOneParamVar("World");
            //myDelegateOneParamVar.Invoke("World");

            // Multicast
            myDelegateMulticastVar += PrintMessage;
            myDelegateMulticastVar += ChangeWeapon;
            myDelegateMulticastVar += Heal;
            //myDelegateMulticastVar();
            //myDelegateMulticastVar.Invoke();

            // Callback
            myDelegateCallbackVar = RequestCompleted;
            RequestConnection(myDelegateCallbackVar);
        }

        private void PrintMessage()
        {
            Debug.Log("Hello World!");
        }

        private void PrintMessageWithValue(string message)
        {
            Debug.Log($"Hello {message}!");
        }

        private int GetWeaponId()
        {
            return 5;
        }

        private void ChangeWeapon()
        {
            Debug.Log("Change Weapon!");
        }

        private void Heal()
        {
            Debug.Log("Heal!");
        }

        bool connectionReady = true;

        private void RequestConnection(MyDelegateCallback callback)
        {
            if (connectionReady)
            {
                callback(true);
                //callback.Invoke(true);
            }
            else
            {
                callback(false);
                //callback.Invoke(false);
            }
        }

        private void RequestCompleted(bool success)
        {
            Debug.Log($"Connection Ready: {success}");
        }



    }
}
