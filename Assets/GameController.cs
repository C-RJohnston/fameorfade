using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    
    public GameObject[] players;
    public Sprite[] sprites;
    private bool wKeyReleased = true;
    private bool aKeyReleased = true;
    private bool sKeyReleased = true;
    private bool dKeyReleased = true;

    private bool tKeyReleased = true;
    private bool fKeyReleased = true;
    private bool gKeyReleased = true;
    private bool hKeyReleased = true;

    private bool iKeyReleased = true;
    private bool jKeyReleased = true;
    private bool kKeyReleased = true;
    private bool lKeyReleased = true;

    private bool openBracketKeyReleased = true;
    private bool semicolonKeyReleased = true;
    private bool apostropheKeyReleased = true;
    private bool backslashKeyReleased = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region input
        //PLAYER 1
        //
        if (Input.GetKey(KeyCode.W) && wKeyReleased)
        {
            Debug.Log("W key pressed");
            players[0].GetComponent<SpriteRenderer>().sprite = sprites[0];
            wKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            wKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.A) && aKeyReleased)
        {
            Debug.Log("A key pressed");
            players[0].GetComponent<SpriteRenderer>().sprite = sprites[1];
            aKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            aKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.S) && sKeyReleased)
        {
            Debug.Log("S key pressed");
            players[0].GetComponent<SpriteRenderer>().sprite = sprites[2];
            sKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            sKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.D) && dKeyReleased)
        {
            Debug.Log("D key pressed");
            players[0].GetComponent<SpriteRenderer>().sprite = sprites[3];
            dKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            dKeyReleased = true;
        }


        // PLAYER 2
        //
        if (Input.GetKey(KeyCode.T) && tKeyReleased)
        {
            Debug.Log("T key pressed");
            players[1].GetComponent<SpriteRenderer>().sprite = sprites[0];
            tKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            tKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.F) && fKeyReleased)
        {
            Debug.Log("F key pressed");
            players[1].GetComponent<SpriteRenderer>().sprite = sprites[1];
            fKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            fKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.G) && gKeyReleased)
        {
            Debug.Log("G key pressed");
            players[1].GetComponent<SpriteRenderer>().sprite = sprites[2];
            gKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            gKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.H) && hKeyReleased)
        {
            Debug.Log("H key pressed");
            players[1].GetComponent<SpriteRenderer>().sprite = sprites[3];
            hKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.H))
        {
            hKeyReleased = true;
        }


        // PLAYER 3
        //
        if (Input.GetKey(KeyCode.I) && iKeyReleased)
        {
            Debug.Log("I key pressed");
            players[2].GetComponent<SpriteRenderer>().sprite = sprites[0];
            iKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            iKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.J) && jKeyReleased)
        {
            Debug.Log("J key pressed");
            players[2].GetComponent<SpriteRenderer>().sprite = sprites[1];
            jKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            jKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.K) && kKeyReleased)
        {
            Debug.Log("K key pressed");
            players[2].GetComponent<SpriteRenderer>().sprite = sprites[2];
            kKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            kKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.L) && lKeyReleased)
        {
            Debug.Log("L key pressed");
            players[2].GetComponent<SpriteRenderer>().sprite = sprites[3];
            lKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.L))
        {
            lKeyReleased = true;
        }


        // PLAYER 4
        //
        if (Input.GetKey(KeyCode.LeftBracket) && openBracketKeyReleased)
        {
            Debug.Log("[ key pressed");
            players[3].GetComponent<SpriteRenderer>().sprite = sprites[0];
            openBracketKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftBracket))
        {
            openBracketKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.Semicolon) && semicolonKeyReleased)
        {
            Debug.Log("; key pressed");
            players[3].GetComponent<SpriteRenderer>().sprite = sprites[1];
            semicolonKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            semicolonKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.Quote) && apostropheKeyReleased)
        {
            Debug.Log("' key pressed");
            players[3].GetComponent<SpriteRenderer>().sprite = sprites[2];
            apostropheKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.Quote))
        {
            apostropheKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.Backslash) && backslashKeyReleased)
        {
            Debug.Log("\\ key pressed");
            players[3].GetComponent<SpriteRenderer>().sprite = sprites[3];
            backslashKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.Backslash))
        {
            backslashKeyReleased = true;
        }
        #endregion


    }
}

