using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    public Text Text;
    public int price = 1;
    private int amount = 1;
    private int counter = 0;


    // Use this for initialization
    void Start () {
        Text = GetComponent<Text>();
	}
	
    public void onPress()
    {
        price *=2;
        GameObject.Find("Button").GetComponentInChildren<Text>().text = price.ToString();
        Text.text = amount.ToString();
    }

	// Update is called once per frame
	void Update () {
        counter += 1;

        
        if (counter == 100)
        {
            amount += price * 2;
            Text.text = amount.ToString();
            counter = 0;
        }
        

    }
}
