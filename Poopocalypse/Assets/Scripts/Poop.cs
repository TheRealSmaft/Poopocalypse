using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poop : MonoBehaviour {

    private bool _isSquished = false;
    public bool isSquished
    {
        get
        {
            return _isSquished;
        }
    }

    public void Squish()
    {
        _isSquished = true;
        transform.localScale = new Vector3(.5f, .01f, .2f);
        transform.eulerAngles = new Vector3(0f, transform.eulerAngles.y, 0f);
        GetComponent<CapsuleCollider>().radius = .05f;
    }
}
