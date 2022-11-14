using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pickups;
    // Start is called before the first frame update
    void Start()
    {
        spawnPickup();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnPickup()
    {
        // Instantiate a random pickup
        GameObject pickup = Instantiate(pickups[Random.Range(0,
       pickups.Length)]);
        pickup.transform.position = transform.position;
        pickup.transform.parent = transform;
    }
    // 2
    IEnumerator respawnPickup()
    {
        yield return new WaitForSeconds(20);
        spawnPickup();

    }
    public void PickupWasPickedUp()
    {
        StartCoroutine("respawnPickup");
    }
}
