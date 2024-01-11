using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminationScript : MonoBehaviour
{
    public float gameDuration;
    public float decisionTime;
    private int round = 1;
    private float gameTime;
    public List<GameObject> lights;
    public List<GameObject> players;
    public List<GameObject> scenes;

    private float maxAlpha;
    private float minAlpha;

    private float interval = 1;
    private float lightTimer;

    private bool roundOver = false;


    // Update is called once per frame
    void Update()
    {

        gameTime += Time.deltaTime;
        if (gameTime < round * gameDuration)
        {
            ;
        }
        else
        {
            if (!roundOver)
            {
                if(gameTime < gameDuration + decisionTime)
                    foreach (var light in lights)
                    {
                        FlickerLight(light);
                    }
                else
                {
                    foreach (var light in lights)
                    {
                        light.GetComponent<SpriteRenderer>().color =
                            new(1, 1, 1, 0.5f);
                    }

                    if (gameTime > (gameDuration + decisionTime + 1.1f) * round)
                    {
                        var loser = Random.Range(0, players.Count);
                        Lose(players[loser], lights[loser]);
                        players.RemoveAt(loser);
                        lights.RemoveAt(loser);
                        scenes[round-1].GetComponent<SpriteRenderer>().sortingOrder = -2;
                        round += 1;
                        scenes[round-1].GetComponent<SpriteRenderer>().sortingOrder = -1;
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

    void Lose(GameObject player, GameObject light)
    {
        light.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        player.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 0);
        //TODO play sounds, progress to next scene
    }
}
