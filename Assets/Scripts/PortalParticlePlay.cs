using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalParticlePlay : MonoBehaviour
{
    public ParticleSystem Portal;
    // Start is called before the first frame update
    void Start()
    {
        Portal = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Portal.Play();
        }
    }
}
