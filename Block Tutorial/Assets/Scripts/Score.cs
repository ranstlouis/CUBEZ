using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    
    // Update is called once per frame
    void Update()
    {
        float zpos = player.position.z + 4999;
        scoreText.text = zpos.ToString("0");
    }
}
