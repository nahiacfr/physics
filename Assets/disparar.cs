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
