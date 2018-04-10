using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{

    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void onLahnaPress()
    {
        anim.SetTrigger("RomiEats");
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
