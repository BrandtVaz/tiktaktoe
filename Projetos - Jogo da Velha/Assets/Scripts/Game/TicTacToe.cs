using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TicTacToe : MonoBehaviour
{
    #region X's Variables.

    public static List<int> horizontalX01 = new List<int>();
    public static List<int> horizontalX02 = new List<int>();
    public static List<int> horizontalX03 = new List<int>();

    public static List<int> verticalX01 = new List<int>();
    public static List<int> verticalX02 = new List<int>();
    public static List<int> verticalX03 = new List<int>();

    public static List<int> transversalRX = new List<int>();
    public static List<int> transversalLX = new List<int>();

    public static bool xTurn, horizontalWin1X, horizontalWin2X, horizontalWin3X, verticalWin1X, verticalWin2X, verticalWin3X, transversalRWinX, transversalLWinX, winX;

    #endregion

    #region O's Variables.
    public static List<int> horizontalO01 = new List<int>();
    public static List<int> horizontalO02 = new List<int>();
    public static List<int> horizontalO03 = new List<int>();

    public static List<int> verticalO01 = new List<int>();
    public static List<int> verticalO02 = new List<int>();
    public static List<int> verticalO03 = new List<int>();

    public static List<int> transversalRO = new List<int>();
    public static List<int> transversalLO = new List<int>();

    public static bool oTurn, horizontalWin1O, horizontalWin2O, horizontalWin3O, verticalWin1O, verticalWin2O, verticalWin3O, transversalRWinO, transversalLWinO, winO;

    #endregion

    public static int turn;
    public static int drew;

    public GameObject[] winLines;

    public TMP_Text victory;
    public GameObject disableBtns;

    private void Start()
    {

        xTurn = true;
        oTurn = false;

        winX = false;
        winO = false;
    }

    private void Update()
    {
        WinLines();

        if (winX)
        {
            victory.text = "O 'X' venceu!";
            disableBtns.SetActive(true);
        }

        if (winO)
        {
            victory.text = "O 'O' venceu!";
            disableBtns.SetActive(true);
        }

        if (drew >= 9)
        {
            if (!winX && !winO)
            {
                victory.text = "Um empate!";
                disableBtns.SetActive(true);
            }
        }
    }

    void WinLines()
    {
        #region Horizontal
        if (horizontalWin1X || horizontalWin1O)
        {
            winLines[0].SetActive(true);
        }

        if (horizontalWin2X || horizontalWin2O)
        {
            winLines[1].SetActive(true);
        }

        if (horizontalWin3X || horizontalWin3O)
        {
            winLines[2].SetActive(true);
        }
        #endregion

        #region Vertical
        if (verticalWin1X || verticalWin1O)
        {
            winLines[3].SetActive(true);
        }

        if (verticalWin2X || verticalWin2O)
        {
            winLines[4].SetActive(true);
        }

        if (verticalWin3X || verticalWin3O)
        {
            winLines[5].SetActive(true);
        }
        #endregion
        
        #region Transversal
        if (transversalRWinX || transversalRWinO)
        {
            winLines[6].SetActive(true);
        }

        if (transversalLWinX || transversalLWinO)
        {
            winLines[7].SetActive(true);
        }
        #endregion
    }

    public static void WinX()
    {
        // Win Condition: X
        #region Horizontal X
        if (horizontalX01.Count >= 3)
        {
            horizontalWin1X = true;
            winX = true;
        }

        if (horizontalX02.Count >= 3)
        {
            horizontalWin2X = true;
            winX = true;
        }

        if (horizontalX03.Count >= 3)
        {
            horizontalWin3X = true;
            winX = true;
        }
        #endregion

        #region Vertical X
        if (verticalX01.Count >= 3)
        {
            verticalWin1X = true;
            winX = true;
        }

        if (verticalX02.Count >= 3)
        {
            verticalWin2X = true;
            winX = true;
        }

        if (verticalX03.Count >= 3)
        {
            verticalWin3X = true;
            winX = true;
        }
        #endregion

        #region Transversal X
        if (transversalRX.Count >= 3)
        {
            transversalRWinX = true;
            winX = true;
        }

        if (transversalLX.Count >= 3)
        {
            transversalLWinX = true;
            winX = true;
        }
        #endregion
    }

    public static void WinO()
    {
        // Win Condition: O
        #region Horizontal O
        if (horizontalO01.Count >= 3)
        {
            horizontalWin1O = true;
            winO = true;
        }

        if (horizontalO02.Count >= 3)
        {
            horizontalWin2O = true;
            winO = true;
        }

        if (horizontalO03.Count >= 3)
        {
            horizontalWin3O = true;
            winO = true;
        }
        #endregion

        #region Vertical O
        if (verticalO01.Count >= 3)
        {
            verticalWin1O = true;
            winO = true;
        }

        if (verticalO02.Count >= 3)
        {
            verticalWin2O = true;
            winO = true;
        }

        if (verticalO03.Count >= 3)
        {
            verticalWin3O = true;
            winO = true;

        }
        #endregion

        #region Transversal O
        if (transversalRO.Count >= 3)
        {
            transversalRWinO = true;
            winO = true;
        }

        if (transversalLO.Count >= 3)
        {
            transversalLWinO = true;
            winO = true;
        }
        #endregion
    }

    public static void WinCondition()
    {
        WinX();
        WinO();
    }
}
