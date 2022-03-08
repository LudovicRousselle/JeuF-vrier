using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputRotation : MonoBehaviour
{

    [Header("Touches")]
    [SerializeField] GameObject toucheDo;
    [SerializeField] GameObject toucheRe;
    [SerializeField] GameObject toucheMi;
    [SerializeField] GameObject toucheFa;
    [SerializeField] GameObject toucheSol;
    [SerializeField] GameObject toucheLa;
    [SerializeField] GameObject toucheSi;
    [SerializeField] GameObject toucheDo2;


    // Update is called once per frame
    void Update()
    {
        //première main
        if (Input.GetKey(KeyCode.A))
        {
            toucheDo.transform.rotation = Quaternion.Euler(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            toucheRe.transform.rotation = Quaternion.Euler(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.E))
        {
            toucheMi.transform.rotation = Quaternion.Euler(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.F))
        {
            toucheFa.transform.rotation = Quaternion.Euler(-1, 0, 0);
        }

        //seconde main
        if (Input.GetKey(KeyCode.J))
        {
            toucheSol.transform.rotation = Quaternion.Euler(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.I))
        {
            toucheLa.transform.rotation = Quaternion.Euler(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.O))
        {
            toucheSi.transform.rotation = Quaternion.Euler(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.P))
        {
            toucheDo2.transform.rotation = Quaternion.Euler(-1, 0, 0);
        }
    }
}
