using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject item;
    public int itemNumber;
    public int ID;

    public class Items
    {
        static bool orb = false;
        static bool key = false;
        public static List<bool> items = new List<bool>() { orb, key };
        public static bool[] orbIDs = new bool[32];
    }
    // Start is called before the first frame update
    void Start()
    {
        if (Player.Instance.inventory[itemNumber] && Player.Instance.inventoryID[ID])
            item.SetActive(false);
        else
            item.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (itemNumber == 0)
                Player.Instance.orbsInPossession++;
            Player.Instance.inventory[itemNumber] = true;
            Player.Instance.inventoryID[ID] = true;
            item.SetActive(false);
        }
    }
}
