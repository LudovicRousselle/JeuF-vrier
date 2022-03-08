using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    [Header("Fun")]
    [SerializeField] AudioSource _do;
    [SerializeField] AudioSource _re;
    [SerializeField] AudioSource _mi;
    [SerializeField] AudioSource _fa;
    [SerializeField] AudioSource _sol;
    [SerializeField] AudioSource _la;
    [SerializeField] AudioSource _si;
    [SerializeField] AudioSource _meow;

    [Header("Feedbacks")]
    [SerializeField] Image keyboardImage1;
    [SerializeField] Image keyboardImage2;

    private bool keyboard = false;


    private void Start()
    {
        keyboardImage1.color = new Color(100, 100, 100, 100);
        keyboardImage2.color = new Color(100, 100, 100, 100);
    }


    // Update is called once per frame
    void Update()
    {
        //Active le second keyboard

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            keyboard = true;
            keyboardImage1.color = new Color(200, 200, 200, 100);
            keyboardImage2.color = new Color(100, 100, 100, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            keyboard = false;
            keyboardImage2.color = new Color(200, 200, 200, 100);
            keyboardImage1.color = new Color(100, 100, 100, 0);
        }


        //PIANO

        //première main
        if ((Input.GetKeyDown(KeyCode.A)) && (keyboard == false))
        {
            _c4.Play();
        }
        if ((Input.GetKeyDown(KeyCode.Z)) && (keyboard == false))
        {
            _d4.Play();
        }
        if ((Input.GetKeyDown(KeyCode.E)) && (keyboard == false))
        {
            _e4.Play();
        }
        if ((Input.GetKeyDown(KeyCode.F)) && (keyboard == false))
        {
            _f4.Play();
        }

        //seconde main
        if ((Input.GetKeyDown(KeyCode.J)) && (keyboard == false))
        {
            _g4.Play();
        }
        if ((Input.GetKeyDown(KeyCode.I)) && (keyboard == false))
        {
            _a4.Play();
        }
        if ((Input.GetKeyDown(KeyCode.O)) && (keyboard == false))
        {
            _b4.Play();
        }
        if ((Input.GetKeyDown(KeyCode.P)) && (keyboard == false))
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



        //FUN

        //première main
        if ((Input.GetKeyDown(KeyCode.A)) && (keyboard == true))
        {
            _do.Play();
        }
        if ((Input.GetKeyDown(KeyCode.Z)) && (keyboard == true))
        {
            _re.Play();
        }
        if ((Input.GetKeyDown(KeyCode.E)) && (keyboard == true))
        {
            _mi.Play();
        }
        if ((Input.GetKeyDown(KeyCode.F)) && (keyboard == true))
        {
            _fa.Play();
        }

        //seconde main
        if ((Input.GetKeyDown(KeyCode.J)) && (keyboard == true))
        {
            _sol.Play();
        }
        if ((Input.GetKeyDown(KeyCode.I)) && (keyboard == true))
        {
            _la.Play();
        }
        if ((Input.GetKeyDown(KeyCode.O)) && (keyboard == true))
        {
            _si.Play();
        }
        if ((Input.GetKeyDown(KeyCode.P)) && (keyboard == true))
        {
            _meow.Play();
        }
    }
}
