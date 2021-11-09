using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    float speed,fuel=50;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    } 

   

    void Update()
    {
        if(fuel>0)
        {
            fuel -= Time.deltaTime/10;

            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(0, Time.deltaTime * -45, 0);

            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(0, Time.deltaTime * 45, 0);


            if (Input.GetKey(KeyCode.F2))

                transform.position += transform.forward * 8 * Time.deltaTime * speed;



            if (Input.GetKey(KeyCode.F1))

                transform.position += transform.forward * Time.deltaTime * speed;

            if (Input.GetKey(KeyCode.DownArrow))
                transform.Rotate(1, 0, 0);

            if (Input.GetKey(KeyCode.UpArrow))
                transform.Rotate(-1, 0, 0);
        }



        if (Input.GetKey(KeyCode.F3))

            transform.position += transform.forward * 25 * Time.deltaTime * speed;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "fuel")
        {
            Destroy(collision.gameObject);
            fuel += 30;
        }
    }
}
