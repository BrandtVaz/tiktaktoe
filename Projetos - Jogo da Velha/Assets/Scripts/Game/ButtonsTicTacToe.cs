using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsTicTacToe : MonoBehaviour
{
    public GameObject star;
    public GameObject heart;
    
    public Button button;

    private void Awake()
    {
        button.onClick.AddListener(DisableAfterClick);
    }

    void DisableAfterClick()
    {
        TicTacToe.WinCondition();

        TicTacToe.drew++;
        TicTacToe.turn++;
        button.interactable = false;
    }

    public void SelectedTeam()
    {
        if (TicTacToe.turn == 0 || TicTacToe.turn == 2 || TicTacToe.turn == 4 || TicTacToe.turn == 6 || TicTacToe.turn == 8)
        {
            TicTacToe.xTurn = true;
            TicTacToe.oTurn = false;

            star.SetActive(true);

            Debug.Log("X: " + TicTacToe.xTurn + " -- " + "O: " + TicTacToe.oTurn);
        }

        if (TicTacToe.turn == 1 || TicTacToe.turn == 3 || TicTacToe.turn == 5 || TicTacToe.turn == 7)
        {
            TicTacToe.oTurn = true;
            TicTacToe.xTurn = false;

            heart.SetActive(true);

            Debug.Log("X: " + TicTacToe.xTurn + " -- " + "O: " + TicTacToe.oTurn);
        }
    }

    #region Add to List.

    public void Horizontal01()
    {
        if (TicTacToe.xTurn)
        {
            TicTacToe.horizontalX01.Add(1);
        }

        if (TicTacToe.oTurn)
        {
            TicTacToe.horizontalO01.Add(1);
        }
    }

    public void Horizontal02()
    {
        if (TicTacToe.xTurn)
        {
            TicTacToe.horizontalX02.Add(1);
        }

        if (TicTacToe.oTurn)
        {
            TicTacToe.horizontalO02.Add(1);
        }
    }

    public void Horizontal03()
    {
        if (TicTacToe.xTurn)
        {
            TicTacToe.horizontalX03.Add(1);
        }

        if (TicTacToe.oTurn)
        {
            TicTacToe.horizontalO03.Add(1);
        }
    }

    public void Vertical01()
    {
        if (TicTacToe.xTurn)
        {
            TicTacToe.verticalX01.Add(1);
        }

        if (TicTacToe.oTurn)
        {
            TicTacToe.verticalO01.Add(1);
        }
    }

    public void Vertical02()
    {
        if (TicTacToe.xTurn)
        {
            TicTacToe.verticalX02.Add(1);
        }

        if (TicTacToe.oTurn)
        {
            TicTacToe.verticalO02.Add(1);
        }
    }

    public void Vertical03()
    {
        if (TicTacToe.xTurn)
        {
            TicTacToe.verticalX03.Add(1);
        }

        if (TicTacToe.oTurn)
        {
            TicTacToe.verticalO03.Add(1);
        }
    }

    public void TransversalR()
    {
        if (TicTacToe.xTurn)
        {
            TicTacToe.transversalRX.Add(1);
        }

        if (TicTacToe.oTurn)
        {
            TicTacToe.transversalRO.Add(1);
        }
    }

    public void TransversalL()
    {
        if (TicTacToe.xTurn)
        {
            TicTacToe.transversalLX.Add(1);
        }

        if (TicTacToe.oTurn)
        {
            TicTacToe.transversalLO.Add(1);
        }
    }

    #endregion
}
