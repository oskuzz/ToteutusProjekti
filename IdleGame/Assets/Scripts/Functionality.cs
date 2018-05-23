using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Functionality : MonoBehaviour
{

    Animator anime;

    public float kassa = 10000;

    public float hintaLahna = 4, hintaSushi = 10, hintaMuikku = 50, hintaPeruna = 200, hintaRae = 1000, hintaNauta = 10000, hintaRape = 500000, hintaKana = 2000000;
    public static float aikaLahna = 200, aikaSushi = 8, aikaMuikku = 24, aikaPeruna = 60, aikaRae = 150, aikaNauta = 300, aikaRape = 480, aikaKana = 660;
    public int Lahna, Sushi, Muikku, Peruna, Rae, Nauta, Rape, Kana;
    public static double lahna = 0, sushi = 0, muikku = 0, peruna = 0, rae = 0, nauta = 0, rape = 0, kana = 0;


    public float hintaMult = 1.25f;
    public float aikaMult = 0.8f;

    public Text timerText;
    public Text massilaatikko;
    // Use this for initialization
    void Start()
    {
        timerText = GameObject.Find("TimerTest").GetComponent<Text>();
        massilaatikko = GameObject.Find("Massit").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerUI();
        massilaatikko.text = "" + kassa;
    }

    public void UpdateTimerUI()
    {
        lahna += Time.deltaTime * 1000;
        /*sushi = Time.deltaTime * 1000;
        muikku = Time.deltaTime * 1000;
        rae = Time.deltaTime * 1000;
        rape = Time.deltaTime * 1000;
        peruna = Time.deltaTime * 1000;
        nauta = Time.deltaTime * 1000;
        kana = Time.deltaTime * 1000;
        */
        timerText.text = "" + lahna;
    }

    public bool Kassa(float hinta)
    {
        if(kassa >= kassa-hinta)
        {
            kassa -= hinta;
            return true;
        }
        else
        {
            return false;
        }

    }

    public void NappulanPainanta(int id)
    {
        switch (id)
        {
            case 1:
                if (Kassa(hintaLahna))
                {
                    hintaLahna *= hintaMult;
                    aikaLahna *= aikaMult;
                    Lahna++;
                }
                break;
            case 2:
                if (Kassa(hintaSushi))
                {
                    hintaSushi *= hintaMult;
                    aikaSushi *= aikaMult;
                    Sushi++;
                }
                break;
            case 3:
                if (Kassa(hintaMuikku))
                {
                    hintaMuikku *= hintaMult;
                    aikaMuikku *= aikaMult;
                    Muikku++;
                }
                break;
            case 4:
                if (Kassa(hintaPeruna))
                {
                    hintaPeruna *= hintaMult;
                    aikaPeruna *= aikaMult;
                    Peruna++;
                }
                break;
            case 5:
                if (Kassa(hintaRae))
                {
                    hintaRae *= hintaMult;
                    aikaRae *= aikaMult;
                    Rae++;
                }
                break;
            case 6:
                if (Kassa(hintaNauta))
                {
                    hintaNauta *= hintaMult;
                    aikaNauta *= aikaMult;
                    Nauta++;
                }
                break;
            case 7:
                if (Kassa(hintaRape))
                {
                    hintaRape *= hintaMult;
                    aikaRape *= aikaMult;
                    Rape++;
                }
                break;
            case 8:
                if (Kassa(hintaKana))
                {
                    hintaKana *= hintaMult;
                    aikaKana *= aikaMult;
                    Kana++;
                }
                break;
        }
    }
}
