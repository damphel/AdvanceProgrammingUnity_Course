using UnityEngine;

namespace Course.PatronesDiseno.Factory
{
    public class Inventory : MonoBehaviour
    {
        public DataBaseSO itemDataBase;
        public string itemId;

        private DataBaseFactory factory;

        private void Start()
        {
            factory = new DataBaseFactory(Instantiate(itemDataBase));
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UpdateItem(itemId);
            }
        }

        private void UpdateItem(string id)
        {
            ItemSO item = factory.GetData<ItemSO>(id);

            Debug.Log($"Item: {item.title}, ${item.price}");
        }

    }
}
