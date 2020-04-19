using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public abstract class Damageable_Target : MonoBehaviour
{
    public float health = 50f;
    Animator anim;

    public void TakeDamage(float dmg) {
        health -= dmg;

        if (health <= 0f)
        {
            anim.SetBool("isDead", true);
        }
    }

    void Die() {
        Destroy(gameObject);
    }
}
