using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public GameObject shipPrefab = null;
    public float moveSpeed;
    public float deathDistance = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(0,0, moveSpeed) * Time.deltaTime;
        if(transform.position.z == deathDistance)
        {
            shipPrefab.SetActive(false);
        }
    }
}
