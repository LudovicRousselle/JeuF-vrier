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


    // Update is called once per frame
    void Update()
    {
        Material gm = GetComponent<Renderer>().material;

        //première main
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gm.SetColor("_color", Color.red);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gm.SetColor("_color", Color.red);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gm.SetColor("_color", Color.red);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            gm.SetColor("_color", Color.red);
        }

        //seconde main
        if (Input.GetKeyDown(KeyCode.Comma))
        {

        }
        if (Input.GetKeyDown(KeyCode.K))
        {

        }
        if (Input.GetKeyDown(KeyCode.L))
        {

        }
        if (Input.GetKeyDown(KeyCode.M))
        {

        }
    }
}
