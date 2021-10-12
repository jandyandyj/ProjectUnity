using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPj : MonoBehaviour
{
    public float StartingHealth = 100f;

    [SerializeField]
    private float _HealthPoints;
    public float HealthPoints
    {
        get { return _HealthPoints; }
        set {
            _HealthPoints = Mathf.Clamp (value, 0f, 100f);
            if (_HealthPoints <= 0f) 
            { //dead
            }
            
         }

    }


    // Start is called before the first frame update
    void Start()
    {
        HealthPoints = StartingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
