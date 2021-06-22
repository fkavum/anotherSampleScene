using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuidoScript : MonoBehaviour
{
    public AudioSource aus;
    void Start()
    {
        aus = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            aus.Stop();
            StopAllCoroutines();
            aus.time = 9;
            aus.Play();
            StartCoroutine(StopWithDelay());
        }
    }

    IEnumerator StopWithDelay()
    {
        yield return new WaitForSeconds(0.42f);
        aus.Stop();
    }
}
