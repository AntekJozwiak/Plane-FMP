using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEADCAM : MonoBehaviour
{
    [SerializeField] private float force=100;
    private void Start()
    {
        GetComponent<Rigidbody>().AddExplosionForce(force, transform.parent.position,100000);
    }
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene("menu");
        }
    }
}
