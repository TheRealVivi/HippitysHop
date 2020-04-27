using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    private static Player instance;
    public static Player Instance { get { return instance; } }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        inventory = Item.Items.items;
        inventoryID = Item.Items.orbIDs;
    }

    public List<bool> inventory;
    public bool[] inventoryID;
}
