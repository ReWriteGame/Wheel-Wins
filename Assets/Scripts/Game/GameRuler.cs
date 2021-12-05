using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;
    [SerializeField] private ScoreCounter scoreCounter;
    [SerializeField] private int numberOfStart = 5;

    public UnityEvent winEvent;
    public UnityEvent loseEvent;



    public void StartGame()
    {
      
     
    }

    public void StopGame()
    {

        if(arrow1.collidedObject.GetComponent<Cell>().Value > 0)
            scoreCounter.Add(arrow1.collidedObject.GetComponent<Cell>().Value);
        else scoreCounter.TakeAway(Mathf.Abs(arrow1.collidedObject.GetComponent<Cell>().Value));

    }

    private IEnumerator StopMachineCor()
    {
        yield break;
    }
}
