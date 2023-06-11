using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class musicmanager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    private string menu;
    private void Start()
    {
        if (GameObject.FindGameObjectsWithTag("music").Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(transform.gameObject);
        menu = SceneManager.GetActiveScene().name;
    }
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name != menu)
        {
            //audioSource.volume = Mathf.Lerp(audioSource.volume, 0, Time.deltaTime);
        }
        else
        {
            audioSource.volume = Mathf.Lerp(audioSource.volume, 1, Time.deltaTime);
        }
    }
}
