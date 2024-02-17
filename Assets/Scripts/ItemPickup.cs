using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private Item item;

    private void Start()
    {
        item = GetComponent<ItemController>().item;
    }

    private void OnMouseDown()
    {
        Pickup();
    }

    public void Pickup()
    {
        InventoryManager.instance.AddItem(item);
        Destroy(gameObject);
    }
}
