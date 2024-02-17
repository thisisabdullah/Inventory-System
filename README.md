# Inventory-System
# Generic Inventory System
The Generic Inventory System is a flexible inventory management solution that allows you to handle different types of items in your game or application. This system is implemented using C# and Unity's ScriptableObject feature, providing a convenient way to create, customize, and manage items within the inventory.

# Features
Add various types of items to the inventory, such as consumables and weapons.
Items are uniquely identified by an ID and can have additional properties like value, name, description, and icon.
Track the quantity of each item in the inventory.
Increase or decrease item quantities based on usage or removal.
Automatically save and load the inventory to persist data between sessions.
Dynamically update the user interface (UI) to reflect changes in the inventory.
Prevent duplicate items with the same ID from being instantiated, instead increasing the quantity count.

# How to Use
Attach the provided Item scriptable object to your game objects or assets to define specific items. Customize the properties of each item according to your requirements.
Create an instance of the InventoryManager class in your game or application to manage the inventory.
Use the AddItem() method to add items to the inventory. If an item with the same ID already exists, the quantity count will be increased instead of instantiating a new item.
Use the RemoveItem() method to remove items from the inventory. The associated UI element will also be destroyed.
Use the UseItem() method to consume or utilize items from the inventory. The quantity count will decrease accordingly. If no items remain, they will be removed from the inventory.
Implement the UpdateItemUi() method to update the UI when the quantity of an item changes.
Customize the UI using the provided ItemUi prefab and associated UI elements (name, description, icon, etc.).
Save the inventory using the SaveItems() method to persist inventory data between sessions. The inventory will be loaded automatically when the game starts.

# Acknowledgments
The Generic Inventory System was inspired by the need for a flexible and reusable inventory management solution in game development.
Feel free to customize and extend the Generic Inventory System to suit your specific needs. Enjoy using the inventory system in your projects!

## Example Usage

```csharp
// Adding an item to the inventory
Item newItem = CreateNewItem(); // Create a new item instance
InventoryManager.instance.AddItem(newItem); // Add the item to the inventory

// Removing an item from the inventory
Item itemToRemove = GetItemToRemove(); // Get the item to remove
InventoryManager.instance.RemoveItem(itemToRemove); // Remove the item from the inventory

// Using an item from the inventory
Item itemToUse = GetItemToUse(); // Get the item to use
InventoryManager.instance.UseItem(itemToUse); // Use the item from the inventory







