using UnityEngine;

namespace Data.Temp
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private ItemData[] items;
        private int _index;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) Next();
        }

        private void Next()
        {
            if (_index > items.Length - 1) _index = 0;

            var item = items[_index++];
            Debug.Log($"Item name: {item.ItemName}");
            Debug.Log($"Item attack: {item.Attack}");
            Debug.Log($"Item type: {item.Type}");
            Debug.Log($"Item price: {item.GetPrice()}");
        }
    }
}