using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void openCloseMenu(Animator anim)
    {
        if (anim.GetBool("OpenMenu") == false)
        {
            anim.SetBool("OpenMenu", true);

        } else
        {
            anim.SetBool("OpenMenu", false);
        }
    }
}
