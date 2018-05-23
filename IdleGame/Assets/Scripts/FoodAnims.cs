using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodAnims : MonoBehaviour {

    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    public void onLahnaPress()
    {
        anim.SetTrigger("EatLahna");
    }
    public void onSushiPress()
    {
        anim.SetTrigger("EatSushi");
    }
    public void onMuikkuPress()
    {
        anim.SetTrigger("EatMuikku");
    }
    public void onPerunaPress()
    {
        anim.SetTrigger("EatPeruna");
    }
    public void onRaejuustoPress()
    {
        anim.SetTrigger("EatRae");
    }
    public void onNautaPress()
    {
        anim.SetTrigger("EatNauta");
    }
    public void onRapepalatPress()
    {
        anim.SetTrigger("EatRape");
    }
    public void onKanaPress()
    {
        anim.SetTrigger("EatKana");
    }

    // Update is called once per frame
    void Update () {

	}
}
