using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int scoretext;
    public int livestext;
    public Text score;
    public Text lives;
    void Start()
    {
        score.text = "score :: " + scoretext;
        lives.text = "lives :: " + livestext;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void updatelives(int livesupdate){
        livestext +=livesupdate;

        if (livestext <= 0)
        {
            livestext = 0;
            gameover();
        }



        lives.text = "lives :: " + livestext;

        if(livestext<=0){
            lives.text = "DED";
        }
    }

    public void updatescore(int scoreupdate){
        scoretext += scoreupdate;

        score.text = "score :: " + scoretext;
    }
    public void gameover(){

    }
}
