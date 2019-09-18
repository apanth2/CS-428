using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vuf : MonoBehaviour , IVirtualButtonEventHandler 
{
    public GameObject model;

    public GameObject Vend;

    public AudioClip MusicClip;
    public AudioSource MusicSource;


    public GameObject gm;
    Animator otherAnimator;
    void Awake()
    {
        otherAnimator = gm.GetComponent<Animator>();

    }




    // Start is called before the first frame update
    void Start()
    {
        model = GameObject.Find("Laciebtn");
        model.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        
        Vend = GameObject.Find("V");
        model.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        Vend.SetActive(false);



        MusicSource.clip = MusicClip;

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        
        Vend.SetActive(true);

        MusicSource.Play();

    }


    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("released");
        
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
            Vend.transform.position = new Vector3(0,0,0);

    }
}
