using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
    public GameObject pm;
    Vector2 lastPos;
    float timeInAir;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!pm.GetComponent<PlayerMovement>().CanJump)
        { 
            timeInAir = timeInAir + 1 * Time.deltaTime;
            timeInAir.ToString("0.0");
           // Debug.Log(timeInAir);
        } else
        {
            if(timeInAir >= 0.4 && timeInAir <= 0.8)
            {
                TakeDamage(1);
            } else if (timeInAir >= 0.8 && timeInAir <= 1.2)
            {
                TakeDamage(2);
            } else if (timeInAir >= 1.2 && timeInAir <= 1.6)
            {
                TakeDamage(3);
            } else if (timeInAir >= 1.6 && timeInAir <= 2.0)
            {
                TakeDamage(4);
            } else if (timeInAir >= 2.0 && timeInAir <= 2.4)
            {
                TakeDamage(5);
            } else if (timeInAir >= 2.8 && timeInAir <= 3.2)
            {
                TakeDamage(6);
            } else if (timeInAir >= 3.2 && timeInAir <= 3.4)
            {
                TakeDamage(7);
            } else if (timeInAir >= 3.4 && timeInAir <= 3.8)
            {
                TakeDamage(8);
            } else if (timeInAir >= 3.8 && timeInAir <= 4.2)
            {
                TakeDamage(9);
            } else if (timeInAir >= 4.2)
            {
                TakeDamage(10);
            }
                lastPos = pm.transform.position; 
        }
    }
    void TakeDamage(int damage_amount)
    {
        Debug.Log(damage_amount);
    }
}
