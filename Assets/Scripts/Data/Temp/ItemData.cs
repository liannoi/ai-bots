using UnityEngine;

namespace Data.Temp
{
    [CreateAssetMenu]
    public class ItemData : ScriptableObject
    {
        [SerializeField] private string itemName;
        [SerializeField] private ItemType type;
        [SerializeField] private float attack;

        public string ItemName => itemName;
        public ItemType Type => type;
        public float Attack => attack;

        public float GetPrice()
        {
            return attack * 40;
        }
    }

    public enum ItemType
    {
        Dagger = 0,
        Axe = 1,
        Sword = 2,
        Staff = 3
    }
}