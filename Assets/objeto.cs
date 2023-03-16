using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeto : MonoBehaviour
{
    public Object bullet;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bullet);
        Instantiate(bullet);
        Instantiate(bullet);
       
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
