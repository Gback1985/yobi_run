using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
    public GameUI gameUI;

    public static GameRoot Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCoin()
    {
        GlobaleData.coinCount++;
        gameUI.updateView();
    }

    public void addDistance(float x)
    {
        GlobaleData.distance += x;
        gameUI.updateView();
    }

    public void gameover()
    {
        gameUI.showGameover();
    }
}
