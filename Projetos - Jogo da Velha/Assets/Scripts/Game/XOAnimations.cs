using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class XOAnimations : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (TicTacToe.winX)
        {
            anim.SetBool("LoseHeart", true);
        }

        if (TicTacToe.winO)
        {
            anim.SetBool("LoseStar", true);
        }
    }
}
