using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfBite : MonoBehaviour
{
    public float DamagePoints = 10f;
    private void OnTriggerEnter(Collider other)
    {
        healthPj H = other.GetComponent<healthPj>();

        if (H == null) return;
        H.HealthPoints -= DamagePoints;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
