using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRun : MonoBehaviour
{
    void Start()    
    {
        Debug.Log(AudioOlayerSingleton.Instance.gameObject);
    }

}
