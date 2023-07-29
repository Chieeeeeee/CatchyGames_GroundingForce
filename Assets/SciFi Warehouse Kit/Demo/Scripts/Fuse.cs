using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
    FuseCounterUI FuseCtrUI;
    // Start is called before the first frame update
    void Start()
    {
        FuseCtrUI = GameObject.FindGameObjectWithTag("FuseCounter").GetComponent<FuseCounterUI>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))

        {
            //GetComponent<CapsuleCollider>().enabled = false;Z
            FuseCtrUI.EarnPoint();
            Destroy(gameObject);
        }
    }
}
