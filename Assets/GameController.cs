using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject player1;
    public Sprite player1dance1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
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
        //PLAYER 1
        //
        if (Input.GetKey(KeyCode.W) && wKeyReleased)
        {
            Debug.Log("W key pressed");
            player1.GetComponent<SpriteRenderer>().sprite = player1dance1;
            wKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            wKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.A) && aKeyReleased)
        {
            Debug.Log("A key pressed");
            aKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            aKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.S) && sKeyReleased)
        {
            Debug.Log("S key pressed");
            sKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            sKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.D) && dKeyReleased)
        {
            Debug.Log("D key pressed");
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
            tKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            tKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.F) && fKeyReleased)
        {
            Debug.Log("F key pressed");
            fKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            fKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.G) && gKeyReleased)
        {
            Debug.Log("G key pressed");
            gKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.G))
        {
            gKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.H) && hKeyReleased)
        {
            Debug.Log("H key pressed");
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
            iKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.I))
        {
            iKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.J) && jKeyReleased)
        {
            Debug.Log("J key pressed");
            jKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            jKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.K) && kKeyReleased)
        {
            Debug.Log("K key pressed");
            kKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            kKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.L) && lKeyReleased)
        {
            Debug.Log("L key pressed");
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
            openBracketKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.LeftBracket))
        {
            openBracketKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.Semicolon) && semicolonKeyReleased)
        {
            Debug.Log("; key pressed");
            semicolonKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            semicolonKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.Quote) && apostropheKeyReleased)
        {
            Debug.Log("' key pressed");
            apostropheKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.Quote))
        {
            apostropheKeyReleased = true;
        }

        if (Input.GetKey(KeyCode.Backslash) && backslashKeyReleased)
        {
            Debug.Log("\\ key pressed");
            backslashKeyReleased = false;
        }

        if (Input.GetKeyUp(KeyCode.Backslash))
        {
            backslashKeyReleased = true;
        }
    }
}

