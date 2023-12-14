using UnityEngine;

namespace Course.FundamentosBasicos
{
    public class CadenasDeTexto : MonoBehaviour
    {
        string myString;

        private void Start()
        {
            myString = "Mariano";
            myString = "Mariano" + " " + "Sosa";

            int age = 27;
            myString = "Mariano's Birthday: " + age.ToString();

            myString = string.Format("{0}'s Birthday: {1}", "Mariano", age);
            myString = $"Mariano's Birthday: {age}";

            myString = "27_Mariano_Rifle";
            string[] characterInfo = myString.Split('_');
            // characterInfo[0] = "27";
            // characterInfo[1] = "Mariano";
            // characterInfo[2] = "Rifle";
        }
    }
}
