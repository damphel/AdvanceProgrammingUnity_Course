using UnityEngine;

namespace Course.FundamentosBasicos
{
    public class Operadores : MonoBehaviour
    {
        int myInt;
        bool myBool;

        private void Start()
        {
            // Operadores Aritmeticos
            myInt = 2 + 2;
            myInt = 2 - 2;
            myInt = 2 * 2;
            myInt = 2 / 2;

            // Operadores de Asignacion
            myInt += 2;
            myInt -= 2;
            myInt *= 2;
            myInt /= 2;

            // Operadores Relacionales
            myBool = 2 > 1;
            myBool = 2 < 1;
            myBool = 2 == 1;
            myBool = 2 >= 1;
            myBool = 2 <= 1;
            myBool = 2 != 1;

            // Operadores Logicos
            myBool = 2 == 2 || 4 == 4;
            myBool = 2 == 2 && 4 == 4;
            myBool = !(2 == 2);
        }
    }
}
