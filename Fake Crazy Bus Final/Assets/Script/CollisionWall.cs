using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWall : MonoBehaviour
{
    [SerializeField]
    private GameObject bus;

    private Vector3 busInitalVector = new Vector3(-11.23f,-4.1f,0);

    private Vector3 busFinalVector = new Vector3(11.23f, -4.1f, 0);
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(bus.transform.position.x > 0)
        {
            bus.transform.position = busInitalVector;
        }
        else if (bus.transform.position.x<0)
        {
            bus.transform.position = busFinalVector;
        }

    }
}
