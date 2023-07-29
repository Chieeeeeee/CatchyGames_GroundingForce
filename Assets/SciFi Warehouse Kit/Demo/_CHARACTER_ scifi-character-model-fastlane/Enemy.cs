using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool lootable = false, shot = false, hasKey = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet") && !shot)
        {
            shot = true;
            lootable = true;
            Destroy(gameObject);
        }
    }
}
