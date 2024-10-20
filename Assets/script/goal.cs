using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class goal : MonoBehaviour
{
    public TextMeshProUGUI player1Text;
    public TextMeshProUGUI player2Text;

    public bool isPlayer1 = true;

    private int player1 = 0;
    private int player2 = 0;

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("puk"))
        {
            if (isPlayer1)
            {
                player2Text.text = (++player2).ToString();
            }
            else
            {
                player1Text.text = (++player1).ToString();

            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
