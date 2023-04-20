using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBehaviour : MonoBehaviour
{
    [SerializeField] GameObject Projectile;
    [SerializeField] GameObject target;
    [SerializeField] Collider AttackRadius;
    float FireRate;
    float Damage;
    float RotationSpeed;
    float Timestamp;
    // Start is called before the first frame update
    void Start()
    {
        Timestamp = Time.time;
        FireRate = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.LookAt(target.transform.position,Vector3.up);
            if(Timestamp+FireRate < Time.time)
            {
                Timestamp = Time.time;
                Instantiate(Projectile,transform.position,transform.rotation);
            }
        }
    }
}
