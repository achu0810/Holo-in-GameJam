using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// AirTapされる側のオブジェクトにつける
/// </summary>
public class AirTapGesture : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnInputClicked(InputClickedEventData eventData) {
        gameObject.AddComponent<Rigidbody>();
    }

}

