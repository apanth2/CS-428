using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour , IVirtualButtonEventHandler
{

    public GameObject vbBtnObj;
    public GameObject vendetta;
    // public Anima cubeAni;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("Laciebtn");
        vendetta = GameObject.Find("V");
        vendetta.SetActive(false);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        vb.gameObject.SetActive(true);
        Debug.Log("Amit");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Released");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
