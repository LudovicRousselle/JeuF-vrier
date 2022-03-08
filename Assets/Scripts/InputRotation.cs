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
        if (Input.GetKeyDown(KeyCode.A))
        {
            toucheDo.transform.Rotate(3f, 0, 0, Space.Self);
            Invoke("ResetRotation", 1f);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            toucheRe.transform.Rotate(3f, 0, 0, Space.Self);
            Invoke("ResetRotation", 1f);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            toucheMi.transform.Rotate(3f, 0, 0, Space.Self);
            Invoke("ResetRotation", 1f);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            toucheFa.transform.Rotate(3f, 0, 0, Space.Self);
            Invoke("ResetRotation", 1f);
        }

        //seconde main
        if (Input.GetKeyDown(KeyCode.J))
        {
            toucheSol.transform.Rotate(3f, 0, 0, Space.Self);
            Invoke("ResetRotation", 1f);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            toucheLa.transform.Rotate(3f, 0, 0, Space.Self);
            Invoke("ResetRotation", 1f);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            toucheSi.transform.Rotate(3f, 0, 0, Space.Self);
            Invoke("ResetRotation", 1f);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            toucheDo2.transform.Rotate(3f, 0, 0, Space.Self);
            Invoke("ResetRotation", 1f);
        }
    }

    private void ResetRotation()
    {
        toucheDo.transform.eulerAngles = new Vector3(-90, 0, 0);
        toucheRe.transform.eulerAngles = new Vector3(-90, 0, 0);
        toucheMi.transform.eulerAngles = new Vector3(-90, 0, 0);
        toucheFa.transform.eulerAngles = new Vector3(-90, 0, 0);
        toucheSol.transform.eulerAngles = new Vector3(-90, 0, 0);
        toucheLa.transform.eulerAngles = new Vector3(-90, 0, 0);
        toucheSi.transform.eulerAngles = new Vector3(-90, 0, 0);
        toucheDo2.transform.eulerAngles = new Vector3(-90, 0, 0);
    }
}
