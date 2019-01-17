using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float currentMovementSpeed = 1f;

    void Update()
    {
        transform.Translate(Vector2.left * currentMovementSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        currentMovementSpeed = speed;
    }
}
