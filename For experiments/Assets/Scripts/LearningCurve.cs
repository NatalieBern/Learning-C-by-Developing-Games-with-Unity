using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private Transform camTransform;

    public GameObject directionalLight;
    private Transform lightTransform;


    // Start is called before the first frame update
    void Start()
    {
        
        camTransform = this.GetComponent<Transform>();
        Debug.Log(camTransform.localPosition);

        //directionalLight = GameObject.Find("Directional Light");
        
        lightTransform = directionalLight.GetComponent<Transform>();
            Debug.Log(lightTransform.localPosition);
    }
}