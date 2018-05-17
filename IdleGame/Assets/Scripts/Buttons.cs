using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{

    Animator anim;
    GameObject menuPanel;
    float aikaLahna;
    public float lahna = 0, sushi = 0, muikku = 0, peruna = 0, rae = 0, nauta = 0, rape = 0, kana = 0;

    // Use this for initialization
    void Start()
    {
        menuPanel = GameObject.Find("MenuPanel").GetComponent<GameObject>();
        aikaLahna = GameObject.Find("Functionality").GetComponent<Functionality>().aikaLahna;
        anim = GetComponent<Animator>();
    }

    public void onLahnaPress()
    {
        if (aikaLahna >= lahna)
        {
            anim.SetTrigger("RomiEats");
            lahna = 0;
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
