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
        //inventoryID = Item.Items.orbIDs;
        orbsInPossession = 0;
    }

    public List<bool> inventory;
    //public bool[] inventoryID;
    public int orbsInPossession;
    public PlayerMovement movement;
    public string currentLevel;
    bool jump;

    public void Inactive(bool active)
    {
        this.enabled = active;
    }

    void LateUpdate()
    {
        float x;
        float z;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            x = Input.GetAxis("Horizontal") * sprintSpeed;
            z = Input.GetAxis("Vertical") * sprintSpeed;
        }
        else 
        {
            x = Input.GetAxis("Horizontal") * walkSpeed;
            z = Input.GetAxis("Vertical") * walkSpeed;
        }

        if (Input.GetButtonDown("Jump"))
            jump = true;

        movement.Move(x, z, jump);

        jump = false;
    }

    public void NewGame() 
    {
        currentLevel = "HubScene";
        orbsInPossession = 0;
        inventory[0] = false;
    }
}
