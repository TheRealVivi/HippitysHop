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
        orbsInPossession = 0;
    }

    public List<bool> inventory;
    public bool[] inventoryID;
    public int orbsInPossession;

    public void Inactive(bool active)
    {
        this.enabled = active;
    }
}
