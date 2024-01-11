using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminationScript : MonoBehaviour
{
    public float gameDuration;
    public float decisionTime;
    private float gameTime;
    public GameObject[] players;

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
                if(gameTime < gameDuration + decisionTime)
                    foreach (var player in players)
                    {
                        FlickerLight(player.transform.GetChild(0).gameObject);
                    }
                else
                {
                    foreach (var player in players)
                    {
                        player.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color =
                            new(1, 1, 1, 0.5f);
                    }

                    if (gameTime > gameDuration + decisionTime + 1.1f)
                    {
                        var loser = Random.Range(0, 4);
                        Lose(players[loser]);
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

            var sprite = spotlight.GetComponent<SpriteRenderer>();
            var alpha = sprite.color.a == 0.5f ? 0 : 0.5f;
            sprite.color = new Color(1, 1, 1, alpha);
            interval = Random.Range(0.1f, 1.5f);
            lightTimer = 0;
        }
    }

    void Lose(GameObject player)
    {
        var spotlight = player.transform.GetChild(0).gameObject;
        spotlight.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        player.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        //TODO play sounds, progress to next scene
        roundOver = true;
    }
}
