using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]
    ParticleSystem explosionParticles;

    [SerializeField]
    AudioSource explosionSound;

    [SerializeField]
    Slider life;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (life == null)
        {
            Destroy(gameObject, 2);
            explosionParticles.Play();
            explosionSound.Play();
        }
        else
        {
            life.value -= 1;

            if (life.value < 1)
            {
                Destroy(gameObject, 2);

                // act particles
                explosionParticles.Play();

                // act snd
                explosionSound.Play();
            }
        }
            





    }
}
