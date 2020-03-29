using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ParticlesAnimation : MonoBehaviour
{
    private bool playParticles = false;
    private ParticleSystem particleObject;

    void Start()
    {
        particleObject = GetComponent<ParticleSystem>();
        particleObject.Stop();
    }


    void Update()
    { 
     if (playParticles)
    {
        Debug.Log("Running");
        particleObject.Play();
        playParticles = false;
    }
}

}