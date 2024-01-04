using UnityEngine;

namespace Course.PatronesDiseno.Factory
{
    public class DataBaseFactory
    {
        private DataBaseSO dataBase;

        public DataBaseFactory(DataBaseSO dataBase)
        {
            this.dataBase = dataBase;
        }

        public DataSO GetData(string id)
        {
            return dataBase.GetData(id);
        }

        public ItemSO GetData<ItemSO>(string id)
        {
            return dataBase.GetData<ItemSO>(id);
        }
    }
}
