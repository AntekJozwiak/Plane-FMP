using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cutsomize : MonoBehaviour
{
    public string[] planenames;
    public int currentmodel;
    int unlockedmount;
    public Text txt;
    // Update is called once per frame
    private void Start()
    {
        currentmodel = PlayerPrefs.GetInt("planeint", 0);
        unlockedmount = PlayerPrefs.GetInt("unlockedmount", 0);
    }
    void Update()
    {
        txt.text = planenames[currentmodel];
        PlayerPrefs.SetString("planemodel", planenames[currentmodel]);
        PlayerPrefs.SetInt("planeint", currentmodel);
    }

    public void nextlevel()
    {
        if (currentmodel + 1 <= unlockedmount) currentmodel++;
    }
    public void prevlevel()
    {
        if (currentmodel - 1 >= 0) currentmodel--;
    }
    public void upgrade()
    {
        if(PlayerPrefs.GetInt("creds", 0) >= 10 * (unlockedmount + 1))
        {
            unlockedmount++;
            PlayerPrefs.SetInt("creds", PlayerPrefs.GetInt("creds", 0)- 10 * (unlockedmount + 1));
        }
        
        PlayerPrefs.SetInt("unlockedmount", unlockedmount);
    }
}
