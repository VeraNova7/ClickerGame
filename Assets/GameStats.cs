using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStats : MonoBehaviour
{
    public string resource;

    [SerializeField] Text woodText;
    [SerializeField] Text stoneText;
    [SerializeField] Text foodText;
    // move these to their own button scripts
    [SerializeField] Button woodUpgradeBtn;
    [SerializeField] Button stoneUpgradeBtn;
    [SerializeField] Button foodUpgradeBtn;



    private int _wood = 0;
    private int _woodIncrement = 1;
    private int _stone = 0;
    private int _stoneIncrement = 1;
    private int _food = 0;
    private int _foodIncrement = 1;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (resource.Equals("wood"))
            {
                _wood += _woodIncrement;
                woodText.GetComponent<Text>().text = "Wood: " + _wood;
            }
            if (resource.Equals("stone"))
            {
                _stone += _stoneIncrement;
                stoneText.GetComponent<Text>().text = "Stone: " + _stone;
            }
            if (resource.Equals("wood"))
            {
                _food += _foodIncrement;
                foodText.GetComponent<Text>().text = "Food: " + _food;
            }
        }

        if (woodUpgradeBtn.clicked)
    }
}
