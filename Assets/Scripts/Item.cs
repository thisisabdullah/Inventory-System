using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item/Create New Item")]
public class Item : ScriptableObject
{
    public enum ItemType
    {
        Consumable,
        Weapon
    }

    public int id;
    public int value;
    public int quantity = 1;
    public string itemName;
    public string description;
    public Sprite icon;
    public ItemType type;
}
