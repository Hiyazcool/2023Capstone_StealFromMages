using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputW : MonoBehaviourSingleton<InputW> {
    // Update is called once per frame
    public Gamepad gpad;
    public void Awake() {
        base.Awake();
        gpad = Gamepad.current;
    }
    void Update() {
        gpad = Gamepad.current;
    }
}
