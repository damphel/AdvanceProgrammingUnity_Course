using UnityEngine;

namespace Course.FundamentosBasicos
{
    public class Variables : MonoBehaviour
    {
        // - Modificador de Acceso
        // public
        // private
        // protected

        // - Tipo de Dato
        // int
        // float
        // bool
        // string

        // - Nombre

        // - Valor por Defecto (Opcional)

        public string playerName = "Mariano";
        private int age = 27;

        // Tipos de Datos (valor)
        private int myInt;
        private float myFloat;
        private double myDouble;
        private bool myBool;
        private char myChar;
        private Vector3 myStructVector;
        private Quaternion myStructQuaternion;

        // Tipos de Datos (Referencia)
        private Transform myClassTransform;
        private GameObject myClassGameObject;
        private Variables myClass;

        private void Start()
        {
            // Tipos de Datos (Valor)
            myInt = 5;
            myFloat = 2.5f;
            myDouble = 0.00000000000001;
            myBool = false;
            myChar = 'a';
            myStructVector = new Vector3(1, 2, 3);
            myStructQuaternion = new Quaternion(1, 2, 3, 4);

            // Tipos de Datos (Referencia)
            myClassTransform = this.transform;
            myClassGameObject = this.gameObject;
            myClass = this;
        }
    }
}
