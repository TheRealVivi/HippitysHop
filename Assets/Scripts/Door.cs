using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public int goingToIndex;
    bool collided = false;
    Collider collider;
    public List<string> scenes = new List<string>()
    {
        "HubScene", "Level01", "FinalLevel", "House", "Credits"
    };
    public class Coordinates
    {
        public static Vector3 hubScene = new Vector3(299.771f, 0f, 299.1484f);
        public static Vector3 level01 = new Vector3(0.0235f, 2.1f, 10.3711f);
        public static Vector3 finalLevel = new Vector3(11.18f, 1.67f, -21.7f);
        public static Vector3 credits = new Vector3(0f, 0f, 0f);

        public static List<Vector3> cooridnates = new List<Vector3>()
        {
            hubScene, level01, finalLevel, credits
        };
    }

    private void OnRenderObject()
    {
        if (collided)
        {
            Open(collider, scenes[goingToIndex], Coordinates.cooridnates[goingToIndex]);
            collided = false;
        }
    }

    public void Open(Collider collision, string goingTo, Vector3 goingToVec)
    {
        Player player = collision.GetComponent<Player>();
        if (player != null)
        {
            SceneManager.LoadScene(goingTo);
            Player.Instance.transform.position = goingToVec;
            Player.Instance.currentLevelInt = goingToIndex;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        collided = true;
        collider = collision;
    }
}