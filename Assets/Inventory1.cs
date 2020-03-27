using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory1 : MonoBehaviour
{
    Dictionary<ItemTypes, List<string>> inventory = new Dictionary<ItemTypes, List<string>>();

    enum ItemTypes
    {
        WALLS,
        GHOSTS,
        COINS,
        POWERUPS
    }
    // Start is called before the first frame update
    void Start()
    {
        inventory.Add(ItemTypes.WALLS, new List<string>());
        inventory.Add(ItemTypes.GHOSTS, new List<string>());
        inventory.Add(ItemTypes.COINS, new List<string>());
        inventory.Add(ItemTypes.POWERUPS, new List<string>());

        AddWalls("groenemuur");
        AddWalls("rodemuur");

        GetWalls();
        RemoveItems("groenemuur");
        GetWalls();
        print(inventory[ItemTypes.WALLS][0]);
    }

    private void AddWalls(string wallType)
    {
        inventory[ItemTypes.WALLS].Add(wallType);
    }
    private void GetWalls()
    {
        Debug.Log("Je hebt " + inventory[ItemTypes.WALLS].Count + " muren!");
    }
    private void RemoveItems(string itemname)
    {
        foreach (var value in inventory.Values)
        {
            for (int i = 0; i < value.Count; i++)
            {
                if (value[i] == itemname)
                {
                    value.Remove(itemname);
                }
            }
        }
    }
}
