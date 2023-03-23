using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    public GameObject bullet;
    [SerializeField]
    public float force = 1000;
    public Transform point;
    private bool collisiontrue;
    void Start()
    {

    }
    void FixedUpdate()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 6;

        // This would cast rays only against colliders in layer 8.
        // But instead we want to collide against everything except layer 8. The ~ operator does this, it inverts a bitmask.

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            Debug.Log("Did Hit" + hit.collider.gameObject.name);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject rbullet = Instantiate(bullet, point.position, point.rotation);

            rbullet.GetComponent<Rigidbody>().AddForce(new Vector3(force, 0, 0));


        }
        if (collisiontrue)
        {

            Destroy(gameObject);

        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("diana"))
        {
            collisiontrue = true;
        }


    }
}

    
