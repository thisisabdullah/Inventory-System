using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryManager : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public Transform itemContent;
    public ItemUi itemUiPrefab;
    public Toggle removeToggle;

    public static InventoryManager instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        removeToggle.onValueChanged.AddListener((value) => EnableRemove());
        LoadItems();
    }

    public void AddItem(Item item)
    {
        Item existingItem = items.Find(i => i.id == item.id);
        if (existingItem != null)
        {
            existingItem.quantity++;
        }
        else
        {
            items.Add(item);
        }
        SaveItems();
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
        SaveItems();
    }

    public void ListItemsInUi()
    {
        foreach (Transform item in itemContent)
        {
            Destroy(item.gameObject);
        }

        foreach (var item in items)
        {
            ItemUi itemUi = Instantiate(itemUiPrefab, itemContent);

            // Populate the UI with item data
            itemUi.nameText.text = item.itemName;
            itemUi.quqntityText.text = item.quantity.ToString();
            itemUi.descriptionText.text = item.description;
            itemUi.iconImg.sprite = item.icon;
            itemUi.item = item;
        }
    }

    public void EnableRemove()
    {
        if (removeToggle.isOn)
        {
            foreach (Transform item in itemContent)
            {
                ItemUi itemUi = item.GetComponent<ItemUi>();
                itemUi.removeBtn.gameObject.SetActive(true);
            }
        }
        else
        {
            foreach (Transform item in itemContent)
            {
                ItemUi itemUi = item.GetComponent<ItemUi>();
                itemUi.removeBtn.gameObject.SetActive(false);
            }
        }
    }

    public void SaveItems()
    {
        string json = JsonUtility.ToJson(new SerializableList<Item>(items));
        string savePath = Application.persistentDataPath + "/inventory.json";
        File.WriteAllText(savePath, json);
    }

    public void LoadItems()
    {
        string savePath = Application.persistentDataPath + "/inventory.json";
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            SerializableList<Item> itemList = JsonUtility.FromJson<SerializableList<Item>>(json);
            items.Clear();
            items.AddRange(itemList.list);
        }
    }
}

[Serializable]
public class SerializableList<T>
{
    public List<T> list;

    public SerializableList(List<T> list)
    {
        this.list = list;
    }
}