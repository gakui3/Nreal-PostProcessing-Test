using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NRKernal.NRExamples;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    VideoCapture2LocalExample controller;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(VideoCapture());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator VideoCapture()
    {
        yield return new WaitForSeconds(5f);
        controller.StartVideoCapture();
        yield return new WaitForSeconds(10f);
        controller.StopVideoCapture();
        yield return null;
    }
}
