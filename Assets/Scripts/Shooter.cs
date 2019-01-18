﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;
    [SerializeField] Projectile projectile2;

    public void Shoot()
    {
        Instantiate(projectile, gun.transform.position, transform.rotation);

        return;
    }
}
