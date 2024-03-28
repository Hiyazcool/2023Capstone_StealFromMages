using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInitialize {

    private static bool isInitialized;
    public virtual void Initialize() {
        if (!isInitialized) {
            InitializeMain();
            isInitialized = true;
        }
    }
    public abstract void InitializeMain();
}
