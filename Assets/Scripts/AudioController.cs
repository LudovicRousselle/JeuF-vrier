using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    //All the audio sources

    [Header("Audio Sources")]
    [Header("Octave 4/5")]
    [SerializeField] AudioSource _c4;
    [SerializeField] AudioSource _d4;
    [SerializeField] AudioSource _e4;
    [SerializeField] AudioSource _f4;
    [SerializeField] AudioSource _g4;
    [SerializeField] AudioSource _a4;
    [SerializeField] AudioSource _b4;
    [SerializeField] AudioSource _c5;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //première main
        if (Input.GetKeyDown(KeyCode.A))
        {
            _c4.Play();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            _d4.Play();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _e4.Play();
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            _f4.Play();
        }

        //seconde main
        if (Input.GetKeyDown(KeyCode.J))
        {
            _g4.Play();
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            _a4.Play();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            _b4.Play();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            _c5.Play();
        }
    }
}
