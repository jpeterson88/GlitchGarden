using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVfx;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVfx)
        {
            Debug.Log("no death VFX");
            return;
        }

        GameObject deathVfxObject = Instantiate(deathVfx, transform.position, transform.rotation);
        Destroy(deathVfxObject, 2f);
    }
}
