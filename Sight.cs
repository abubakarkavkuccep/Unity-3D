using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : MonoBehaviour
{

    [SerializeField]
    BotFire botFire;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
            botFire.enabled = true;
    }

    private void OnTriggerExıt(Collider other)
    {
        if (other.name == "Player")
            botFire.enabled = false;
    }
}
