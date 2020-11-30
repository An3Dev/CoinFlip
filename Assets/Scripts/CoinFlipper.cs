using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFlipper : MonoBehaviour
{

    public Rigidbody rb;

    public float minRotationalForce = 50, maxRotationalForce = 200;

    public Transform headsTransform, tailsTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.useGravity = true;

            float randomForce = Random.Range(minRotationalForce, maxRotationalForce);
            rb.AddTorque(new Vector3(0, 0, randomForce));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (headsTransform.up.y > 0) 
        {
            // heads is up.
            print("we got heads");
        } else if (tailsTransform.up.y > 0)
        {
            // tails is up.
            print("we got tails");
        }
        else
        {
            // landed on side
            print("landed on the side");
        }
    }
}
