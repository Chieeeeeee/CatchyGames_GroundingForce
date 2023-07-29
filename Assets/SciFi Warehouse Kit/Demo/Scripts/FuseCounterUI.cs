using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class FuseCounterUI : MonoBehaviour
{

    TMP_Text FuseCtrText;
    int FuseCtr;

    // Start is called before the first frame update
    void Start()
    {
        FuseCtrText = transform.GetChild(1).GetComponent<TMP_Text>();
        FuseCtr = 0;
    }

    public void EarnPoint()
    {
        FuseCtr++;
        if (SceneManager.GetActiveScene().name == "SciFi_Warehouse" && FuseCtr == 10)
        {
            SceneManager.LoadScene("Win");
        }
        UpdateCounter();
    }

    private void UpdateCounter()
    {
        FuseCtrText.text = FuseCtr.ToString() + " / 10";
    }
}
