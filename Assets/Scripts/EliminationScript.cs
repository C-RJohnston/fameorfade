using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using Random = UnityEngine.Random;

public class EliminationScript : MonoBehaviour
{

    public AudioClip[] songs;
    public AudioClip roll;
    private AudioSource audioSource;
    public float gameDuration;
    public float decisionTime;
    private int round = 0;
    private float gameTime;
    public List<GameObject> lights;
    public List<GameObject> players;
    public GameObject globalLight;
    public GameObject background;
    public List<Sprite> backgroundSprites;
    private float maxAlpha;
    private float minAlpha;

    private float interval = 1;
    private float lightTimer;

    private bool roundOver = false;
    private bool gameOver;

    public GameObject cdScreen;
    public GameObject cdGuy;


    
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver) return;
        gameTime += Time.deltaTime;
        if (gameTime < gameDuration)
        {
            ;
        }
        else
        {
            audioSource.Pause();
            audioSource.clip = roll;
            //audioSource.volume += 20;
            audioSource.Play();
            GetComponent<GameController>().inputEnabled = false;
            globalLight.GetComponent<Light2D>().intensity = 0.3f;
            if (gameTime < gameDuration + decisionTime)
                foreach (var light in lights)
                {
                    FlickerLight(light);
                }
            else
            {
                audioSource.Stop();
                foreach (var light in lights)
                {
                    light.GetComponent<Light2D>().enabled = true;
                }

                if (gameTime > gameDuration + decisionTime + 1.1f && !roundOver)
                {
                    
                    //audioSource.volume -= 20;
                    var loser = Random.Range(0, players.Count());
                    Lose(players[loser], lights[loser]);
                    players.RemoveAt(loser);
                    lights.RemoveAt(loser);
                    roundOver = true;
                }

                if (gameTime > gameDuration + decisionTime + 2.5f && round < 3)
                {
                    background.GetComponent<SpriteRenderer>().sprite = backgroundSprites[round];
                    audioSource.clip = songs[round];
                    gameTime = 0;
                    GetComponent<GameController>().inputEnabled = true;
                    foreach (var light in lights)
                    {
                        light.GetComponent<Light2D>().enabled = false;
                    }
                    globalLight.GetComponent<Light2D>().intensity = 1f;
                    roundOver = false;
                    audioSource.Play();
                }

                if (round == 3)
                {
                    gameOver = true;
                    // TODO play game over
                    foreach (var light in lights)
                    {
                        light.GetComponent<Light2D>().enabled = false;
                    }
                    globalLight.GetComponent<Light2D>().intensity = 1f;
                    cdScreen.SetActive(true);
                    cdGuy.SetActive(true);
                    cdGuy.GetComponent<SpriteRenderer>().color = players[0].GetComponent<SpriteRenderer>().color;
                }
                
            }

        }

    }

    void FlickerLight(GameObject spotlight)
    {
        lightTimer += Time.deltaTime;
        if (lightTimer > interval)
        {
            var _light = spotlight.GetComponent<Light2D>();
            _light.enabled = !_light.enabled;
            interval = Random.Range(0.1f, 1.5f);
            lightTimer = 0;
        }
    }

    void Lose(GameObject player, GameObject spotlight)
    {
        var light = spotlight.GetComponent<Light2D>();
        light.enabled = false;
        player.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        //TODO play sounds, progress to next scene
        round++;
        player.SetActive(false);
        spotlight.SetActive(false);

    }
    
    
}
