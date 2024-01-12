using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameController : MonoBehaviour
{
    [HideInInspector] public bool inputEnabled;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public Sprite dance1;
    public Sprite dance2;
    public Sprite dance3;
    public Sprite dance4;

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
    
    public GameObject[] particles;
    public Sprite[] particlemats;
    public float spawnChance;
    
    // Start is called before the first frame update
    void Start()
    {
        inputEnabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        #region input
        
        if (inputEnabled)
        {
            //PLAYER 1
            //
            if (Input.GetKey(KeyCode.W) && wKeyReleased)
            {
                Debug.Log("W key pressed");
                player1.GetComponent<SpriteRenderer>().sprite = dance1;
                StartCoroutine(ChangePopUp(particles[0]));
                wKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.W))
            {
                wKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.A) && aKeyReleased)
            {
                Debug.Log("A key pressed");
                player1.GetComponent<SpriteRenderer>().sprite = dance2;
                StartCoroutine(ChangePopUp(particles[0]));
                aKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                aKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.S) && sKeyReleased)
            {
                Debug.Log("S key pressed");
                player1.GetComponent<SpriteRenderer>().sprite = dance3;
                StartCoroutine(ChangePopUp(particles[0]));
                sKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.S))
            {
                sKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.D) && dKeyReleased)
            {
                Debug.Log("D key pressed");
                player1.GetComponent<SpriteRenderer>().sprite = dance4;
                StartCoroutine(ChangePopUp(particles[0]));
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
                player2.GetComponent<SpriteRenderer>().sprite = dance1;
                StartCoroutine(ChangePopUp(particles[1]));
                tKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.T))
            {
                tKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.F) && fKeyReleased)
            {
                Debug.Log("F key pressed");
                player2.GetComponent<SpriteRenderer>().sprite = dance2;
                StartCoroutine(ChangePopUp(particles[1]));
                fKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.F))
            {
                fKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.G) && gKeyReleased)
            {
                Debug.Log("G key pressed");
                player2.GetComponent<SpriteRenderer>().sprite = dance3;
                StartCoroutine(ChangePopUp(particles[1]));
                gKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.G))
            {
                gKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.H) && hKeyReleased)
            {
                Debug.Log("H key pressed");
                player2.GetComponent<SpriteRenderer>().sprite = dance4;
                StartCoroutine(ChangePopUp(particles[1]));
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
                player3.GetComponent<SpriteRenderer>().sprite = dance1;
                StartCoroutine(ChangePopUp(particles[2]));
                iKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.I))
            {
                iKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.J) && jKeyReleased)
            {
                Debug.Log("J key pressed");
                player3.GetComponent<SpriteRenderer>().sprite = dance2;
                StartCoroutine(ChangePopUp(particles[2]));
                jKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.J))
            {
                jKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.K) && kKeyReleased)
            {
                Debug.Log("K key pressed");
                player3.GetComponent<SpriteRenderer>().sprite = dance3;
                StartCoroutine(ChangePopUp(particles[2]));
                kKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.K))
            {
                kKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.L) && lKeyReleased)
            {
                Debug.Log("L key pressed");
                player3.GetComponent<SpriteRenderer>().sprite = dance4;
                StartCoroutine(ChangePopUp(particles[2]));
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
                player4.GetComponent<SpriteRenderer>().sprite = dance1;
                StartCoroutine(ChangePopUp(particles[3]));
                openBracketKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.LeftBracket))
            {
                openBracketKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.Semicolon) && semicolonKeyReleased)
            {
                Debug.Log("; key pressed");
                player4.GetComponent<SpriteRenderer>().sprite = dance2;
                StartCoroutine(ChangePopUp(particles[3]));
                semicolonKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.Semicolon))
            {
                semicolonKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.Quote) && apostropheKeyReleased)
            {
                Debug.Log("' key pressed");
                player4.GetComponent<SpriteRenderer>().sprite = dance3;
                StartCoroutine(ChangePopUp(particles[3]));
                apostropheKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.Quote))
            {
                apostropheKeyReleased = true;
            }

            if (Input.GetKey(KeyCode.Backslash) && backslashKeyReleased)
            {
                Debug.Log("\\ key pressed");
                player4.GetComponent<SpriteRenderer>().sprite = dance4;
                StartCoroutine(ChangePopUp(particles[3]));
                backslashKeyReleased = false;
            }

            if (Input.GetKeyUp(KeyCode.Backslash))
            {
                backslashKeyReleased = true;
            }
        }
        
        #endregion


    }

    IEnumerator ChangePopUp(GameObject particle)
    {
        if (Random.Range(0f, 1f) < spawnChance)
        {
            particle.SetActive(true);
            particle.GetComponent<SpriteRenderer>().sprite = particlemats[Random.Range(0, particlemats.Length)];
            yield return new WaitForSeconds(3f);
            particle.SetActive(false);
        }
    }
}

