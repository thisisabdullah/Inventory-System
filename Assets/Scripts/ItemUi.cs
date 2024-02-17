using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemUi : MonoBehaviour
{
    public Image iconImg;
    public TMP_Text quqntityText;
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public Button useBtn;
    public Button removeBtn;

    [HideInInspector] public Item item;

    private void Start()
    {
        removeBtn.onClick.AddListener(RemoveItem);
        useBtn.onClick.AddListener(UseItem);
    }

    private void RemoveItem()
    {
        InventoryManager.instance.RemoveItem(item);
        Destroy(gameObject);
    }

    public void UseItem()
    {
        switch (item.type)
        {
            case Item.ItemType.Consumable:
                GameManager.instance.IncreaseHealth(item.value);
                break;

            case Item.ItemType.Weapon:
                GameManager.instance.IncreaseXp(item.value);
                break;
        }

        item.quantity--;

        if (item.quantity <= 0)
        {
            RemoveItem();
        }
        else
        {
            InventoryManager.instance.ListItemsInUi();
            InventoryManager.instance.SaveItems();
        }
    }
}
