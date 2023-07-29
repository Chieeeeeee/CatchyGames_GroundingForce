using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField]
    GameObject bullet, b;
    [SerializeField]
    Transform shootPoint;
    bool isShooting = false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isShooting)
        {
            b = Instantiate(bullet, shootPoint.position, Quaternion.identity);
            StartCoroutine(BulletCooldown());
        }

    }
    IEnumerator BulletCooldown()
    {
        isShooting = true;
        yield return new WaitForSeconds(0.1f);
        isShooting = false;
    }
}
