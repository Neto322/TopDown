using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    float movespeed;

    Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }

   
    void Update()
    {
        transform.Translate(axis.normalized.magnitude * Vector3.forward * movespeed * Time.deltaTime);

        if(axis != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(axis.normalized);
        }

        anim.SetFloat("Move", Mathf.Abs(axis.normalized.magnitude));
    }

    Vector3 axis
    {
        get => new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
    }
}
