using UnityEngine;
using TMPro;

namespace Course.PatronesDiseno.Observer
{
    public class PlayerUI : MonoBehaviour
    {
        public TextMeshProUGUI healthTxt;

        public void UpdateHealth(int health)
        {
            healthTxt.text = $"Health: {health}";
        }
    }
}
