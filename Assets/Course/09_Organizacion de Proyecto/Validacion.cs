 using UnityEngine;

namespace Course.OrganizacionProyecto
{
    public class Validacion : MonoBehaviour
    {
        [SerializeField] private Sprite sprite;
        [SerializeField] private SpriteRenderer spriteRenderer;

        private void OnValidate()
        {
            if (!spriteRenderer)
            {
                spriteRenderer = GetComponent<SpriteRenderer>();
            }

            if (!sprite)
            {
                Debug.Log("Missing Sprite!");
                return;
            }

            spriteRenderer.sprite = sprite;
        }
    }
}
