using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    //All the audio sources

    [Header("Audio Sources")]

    [Header("Piano Octave 4/5")]
    [SerializeField] AudioSource _c4;
    [SerializeField] AudioSource _d4;
    [SerializeField] AudioSource _e4;
    [SerializeField] AudioSource _f4;
    [SerializeField] AudioSource _g4;
    [SerializeField] AudioSource _a4;
    [SerializeField] AudioSource _b4;
    [SerializeField] AudioSource _c5;

    [Header("Percu")]
    [SerializeField] AudioSource _kick;
    [SerializeField] AudioSource _kick2;
    [SerializeField] AudioSource _yeah;
    [SerializeField] AudioSource _snare;
    [SerializeField] AudioSource _snare2;
    [SerializeField] AudioSource _hH;
    [SerializeField] AudioSource _hH2;
    [SerializeField] AudioSource _shaker;


    // Update is called once per frame
    void Update()
    {



        //PIANO

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


        //PERCU

        //première main
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _kick.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _kick2.Play();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _yeah.Play();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            _shaker.Play();
        }

        //seconde main
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            _snare.Play();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            _snare2.Play();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            _hH.Play();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            _hH2.Play();
        }
    }
}
