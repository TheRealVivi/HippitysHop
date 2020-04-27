using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject item;
    public int itemNumber;

    public class Items
    {
        static bool orb = false;
        static bool key = false;
        public static List<bool> items = new List<bool>() { orb, key };
    }
    // Start is called before the first frame update
    void Start()
    {
        if (Player.Instance.inventory[itemNumber])
            item.SetActive(false);
        else
            item.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player.Instance.inventory[itemNumber] = true;
            item.SetActive(false);
        }
    }
}
