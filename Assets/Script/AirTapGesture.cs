using System;
using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

public class AirTapGesture : MonoBehaviour,IInputClickHandler{

    // Use this for initialization
    void Start(){

    }

    // Update is called once per frame
    void Update(){

    }

    void IInputClickHandler.OnInputClicked(InputClickedEventData eventData)
    {
        gameObject.AddComponent<Rigidbody>();
    }

}
