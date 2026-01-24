namespace Phase11MVP3.Services.Inventory;
public readonly record struct ItemDefinition(string ItemName, EnumInventoryStorageCategory Storage, EnumInventoryItemCategory ItemCategory);