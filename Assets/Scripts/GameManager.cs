using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public Text countText;
    public Text winText;
    public PlayerController playerController;

    private int count;

	void Start()
    {
        count = 0;
        SetCountText();
        playerController.OnCollisionEvent += IncreaseScore;
    }

    void Update()
    {

    	float moveHorizontal = Input.GetAxis("Horizontal");
    	float moveVertical = Input.GetAxis("Vertical");

    	playerController.Move(moveHorizontal, moveVertical);
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 5) {
            winText.text = "You win!";
        }
    }

    public void IncreaseScore()
    {
    	count = count + 1;

        SetCountText();
    }
}
