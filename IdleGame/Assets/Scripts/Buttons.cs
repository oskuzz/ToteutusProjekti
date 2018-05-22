using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    Animator anim;
    GameObject menuPanel;

    public Text timerText;
    // Use this for initialization
    void Start()
    {
        menuPanel = GameObject.Find("MenuPanel").GetComponent<GameObject>();
        anim = GetComponent<Animator>();
        timerText = GameObject.Find("TimerTest").GetComponent<Text>();

    }

    public void onLahnaPress()
    {
        if (Functionality.aikaLahna <= Functionality.lahna)
        {
            anim.SetTrigger("RomiEats");
            Functionality.lahna = 0;
        }
    }
    public void onSushiPress()
    {
        anim.SetTrigger("RomiEats");
    }
    public void onMuikkuPress()
    {
        anim.SetTrigger("RomiEats");
    }
    public void onPerunaPress()
    {
        anim.SetTrigger("RomiEats");
    }
    public void onRaejuustoPress()
    {
        anim.SetTrigger("RomiEats");
    }
    public void onNautaPress()
    {
        anim.SetTrigger("RomiEats");
    }
    public void onRapepalatPress()
    {
        anim.SetTrigger("RomiEats");
    }
    public void onKanaPress()
    {
        anim.SetTrigger("RomiEats");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
