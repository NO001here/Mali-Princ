using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    private Inventory inventory;
    public GameObject itemImage;
    

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="Player")
        {
            Debug.Log("Works1");

            for (int i = 0; i < inventory.items.Length; i++)
            {
                Debug.Log("Works2");
                if (inventory.items[i] == 0)
                {
                    inventory.items[i] = 1;
                    Instantiate(itemImage, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }

    }
}
