using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renederer;
    Rigidbody rigidBody;
    [SerializeField] float timeToWait=3f;
    // Start is called before the first frame update
    void Start()
    {
        renederer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        renederer.enabled = false;
        rigidBody.useGravity=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>timeToWait)
        {
            renederer.enabled = true;
            rigidBody.useGravity=true;
            
        }
    }
}
