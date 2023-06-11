using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Planemodels : MonoBehaviour
{
    private void Update()
    {
        foreach(Transform t in transform)
        {
            if(PlayerPrefs.GetString("planemodel", "Crop Duster") == t.name)
            {
                t.gameObject.SetActive(true);
            }
            else
            {
                t.gameObject.SetActive(false);
            }
        }
    }
}
