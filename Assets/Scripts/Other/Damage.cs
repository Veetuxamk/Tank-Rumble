using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public LayerMask m_TankMask;
    public float damage = 100f;
    public float m_MaxLifeTime = 3f;

   public float m_ExplosionRadius = 5f;

    private void start()
    {
        Destroy(gameObject, m_MaxLifeTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, m_ExplosionRadius, m_TankMask);
        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();

            TankHealth targetHealth = targetRigidbody.GetComponent<TankHealth>();

            targetHealth.TakeDamage(damage);

           
        }
    }
}
