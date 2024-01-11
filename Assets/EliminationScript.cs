using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EliminationScript : MonoBehaviour
{
    public float gameDuration;
    public float decisionTime;
    private float gameTime;
    public GameObject[] lights;
    public GameObject[] players;
    public GameObject globalLight;

    private float maxAlpha;
    private float minAlpha;

    private float interval = 1;
    private float lightTimer;

    private bool roundOver = false;


    // Update is called once per frame
    void Update()
    {

        gameTime += Time.deltaTime;
        if (gameTime < gameDuration)
        {
            ;
        }
        else
        {
            if (!roundOver)
            {
                globalLight.GetComponent<Light2D>().intensity = 0.3f;
                if(gameTime < gameDuration + decisionTime)
                    foreach (var light in lights)
                    {
                        FlickerLight(light);
                    }
                else
                {
                    foreach (var light in lights)
                    {
                        light.GetComponent<Light2D>().enabled = true;
                    }

                    if (gameTime > gameDuration + decisionTime + 1.1f)
                    {
                        var loser = Random.Range(0, 4);
                        Lose(players[loser], lights[loser]);
                    }
                    
                }
                
            }
            
        }
    }

    void FlickerLight(GameObject spotlight)
    {
        lightTimer += Time.deltaTime;
        if (lightTimer > interval)
        {

            //var sprite = spotlight.GetComponent<SpriteRenderer>();
            //var alpha = sprite.color.a == 0.5f ? 0 : 0.5f;
            //sprite.color = new Color(1, 1, 1, alpha);
            var light = spotlight.GetComponent<Light2D>();
            light.enabled = !light.enabled;
            interval = Random.Range(0.1f, 1.5f);
            lightTimer = 0;
        }
    }

    void Lose(GameObject player, GameObject spotlight)
    {
        //light.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        var light = spotlight.GetComponent<Light2D>();
        light.enabled = false;
        player.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        //TODO play sounds, progress to next scene
        roundOver = true;
    }
}
