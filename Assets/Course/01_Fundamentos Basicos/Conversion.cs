using UnityEngine;

namespace Course.FundamentosBasicos
{
    public class Conversion : MonoBehaviour
    {
        private void Start()
        {
            // Conversion (Cast)
            int myCastInt = (int)2.55f;

            Collider myCollider = GetComponent<Collider>();
            BoxCollider myBoxCollider;
            myBoxCollider = (BoxCollider)myCollider;
            myBoxCollider = myCollider as BoxCollider;

            // Conversion (Parse)
            string myStringInt = "128";
            int myIntParsed;

            myIntParsed = int.Parse(myStringInt); // 128
            bool resultParse = int.TryParse(myStringInt, out myIntParsed);

            // Conversion (Enum)
            string myStringEnum = "Fire";

            AttackType myEnum;
            myEnum = (AttackType)System.Enum.Parse(typeof(AttackType), myStringEnum);
        }


    }
}
