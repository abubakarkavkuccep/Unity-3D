using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotFire : MonoBehaviour
{
    float timer;

    [SerializeField]
    bool autoFire;

    [SerializeField]
    GameObject bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (autoFire==true)
        {
            if (timer < 0)
            {
                timer = 1;

                Instantiate(bullet, transform.position, transform.rotation)
                    .GetComponent<Rigidbody>()
                    .velocity = transform.forward * 5;
            }
            else
                timer -= Time.deltaTime;
        }
        else
            if (Input.GetKeyDown(KeyCode.LeftControl))
            Instantiate(bullet, transform.position, transform.rotation)
                .GetComponent<Rigidbody>().velocity = transform.forward * 10;
                
    }
}
