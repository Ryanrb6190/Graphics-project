using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLensFlare : MonoBehaviour
{

    public float rotateSpeed;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(player.transform.position, Vector3.down, rotateSpeed * Time.deltaTime);
    }
}
