using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorChange : MonoBehaviour
{
    [Header("Materials")]
    [SerializeField] Material _m1;
    [SerializeField] Material _m2;
    [SerializeField] Material _m3;
    [SerializeField] Material _m4;
    [SerializeField] Material _m5;
    [SerializeField] Material _m6;
    [SerializeField] Material _m7;
    [SerializeField] Material _m8;


    private void Start()
    {
        _m1.color = new Color(255, 255, 255);
        _m2.color = new Color(255, 255, 255);
        _m3.color = new Color(255, 255, 255);
        _m4.color = new Color(255, 255, 255);
        _m5.color = new Color(255, 255, 255);
        _m6.color = new Color(255, 255, 255);
        _m7.color = new Color(255, 255, 255);
        _m8.color = new Color(255, 255, 255);
    }


    // Update is called once per frame
    void Update()
    {

        //première main
        if (Input.GetKey(KeyCode.Q))
        {
            _m1.color = new Color(255, 0, 0);
            Invoke("ResetColor", 0.5f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _m2.color = new Color(255, 0, 0);
            Invoke("ResetColor", 0.5f);

        }
        if (Input.GetKey(KeyCode.D))
        {
            _m3.color = new Color(255, 0, 0);
            Invoke("ResetColor", 0.5f);
        }
        if (Input.GetKey(KeyCode.C))
        {
            _m4.color = new Color(255, 0, 0);
            Invoke("ResetColor", 0.5f);
        }

        //seconde main
        if (Input.GetKey(KeyCode.Comma))
        {
            _m5.color = new Color(255, 0, 0);
            Invoke("ResetColor", 0.5f);
        }
        if (Input.GetKey(KeyCode.K))
        {
            _m6.color = new Color(255, 0, 0);
            Invoke("ResetColor", 0.5f);
        }
        if (Input.GetKey(KeyCode.L))
        {
            _m7.color = new Color(255, 0, 0);
            Invoke("ResetColor", 0.5f);
        }
        if (Input.GetKey(KeyCode.M))
        {
            _m8.color = new Color(255, 0, 0);
            Invoke("ResetColor", 0.5f);
        }
    }



    private void ResetColor()
    {
        _m1.color = new Color(255, 255, 255);
        _m2.color = new Color(255, 255, 255);
        _m3.color = new Color(255, 255, 255);
        _m4.color = new Color(255, 255, 255);
        _m5.color = new Color(255, 255, 255);
        _m6.color = new Color(255, 255, 255);
        _m7.color = new Color(255, 255, 255);
        _m8.color = new Color(255, 255, 255);
    }
}
