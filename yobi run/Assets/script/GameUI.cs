using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public Text coinLabel;
    public Text distanceLable;
    public Animator gameoverAnima;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateView()
    {
        coinLabel.text = GlobaleData.coinCount.ToString();
        distanceLable.text = GlobaleData.distance.ToString("F1") + "m";
    }

    public void showGameover()
    {
        gameoverAnima.SetTrigger("gameover");
    }

    public void onTapGameoverButton()
    {
        GlobaleData.init();
        SceneManager.LoadScene("game");
    }
}
