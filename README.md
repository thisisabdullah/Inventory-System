# Inventory-System
Generic Inventory System 
This generic inventory system is based on the Item class, which inherits from ScriptableObject. This allows you to create and customize different types of items with properties such as ID, value, name, description, icon, and type.

The InventoryManager class serves as the central component of the inventory system. It manages the list of items in the inventory and provides methods for adding, removing, and using items. The ListItemsInUi() method populates the UI with the items in the inventory.

When adding an item to the inventory, the AddItem() method is called. It checks if an item with the same ID already exists. If it does, the quantity count of the existing item is increased; otherwise, the new item is added to the inventory list. The SaveItems() method is called after adding or removing items to persist the changes.

The RemoveItem() method removes an item from the inventory. It is called when the user wants to remove an item from the UI.

The UseItem() method is called when the user wants to use an item. Depending on the item's type (consumable or weapon), it performs specific actions such as increasing health or experience points. After using the item, the quantity count is decreased by one. If there are no remaining items, the item is removed from the inventory; otherwise, the UI is updated to reflect the new quantity.

The inventory system also includes a SerializableList<T> class, which is used to serialize and deserialize the list of items when saving and loading from a JSON file. The LoadItems() method loads the saved items from the file when the game starts.

Overall, this generic inventory system allows you to manage items, add them to the inventory, remove them, use them, and persist the inventory data using JSON serialization.
