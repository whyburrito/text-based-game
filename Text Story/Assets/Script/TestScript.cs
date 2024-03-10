using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TestScript : MonoBehaviour
{
    public string helloWorld;
    private int x;
    public GameObject Cube;
    public bool isOn;
    public GameObject stats;
    public TextMeshProUGUI movementValue;
    public int movementPoints;

    public GameObject[] Scenes;
    public int activeScene;

    public GameObject[] TextBox;
    public int activeTextBox;

    // Start is called before the first frame update
    void Start()
    {
        Scenes[0].SetActive(true);
        for (int i = 1; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(i == activeScene); 
        }

        TextBox[0].SetActive(true);
        for (int i = 0; i < TextBox.Length; i++)
        {
            TextBox[i].SetActive(i == activeTextBox);
        }
    }

    // Update is called once per frame
    void Update()
    {
        SceneChanger();
        TextChanger();
    }

    public void SceneChanger()
    {
        for (int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(i == activeScene);
        }
    }

    public void TextChanger()
    {
        for (int i = 0; i < TextBox.Length; i++)
        {
            TextBox[i].SetActive(i == activeTextBox);
        }
    }

    public void BackToTitleScreen()
    {
        activeScene = 0;
        activeTextBox = 0;
    }

    public void BackToScene1()
    {
        activeScene = 1;
        activeTextBox = 0;
    }

    public void EnterButton()
    {
        activeScene = 1;
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void NextTextButton()
    {
        activeTextBox =+ 1;
    }

    public void JurassicSceneButton()
    { 
        activeScene = 2;
        activeTextBox = 2;
    }

    public void NextJurassicTextButton()
    {
        activeTextBox = 3;
    }

    public void JurasicBadEnd()
    {
        activeScene = 3;
    }

    public void BloonsSceneButton()
    {
        activeScene = 4;
        activeTextBox = 4;
    }

    public void BloonsText2()
    {
        activeTextBox = 5;
    }

    public void BloonsText3()
    {
        activeTextBox = 6;
    }

    public void BloonsText4()
    {
        activeTextBox = 7;
    }

    public void BloonsText5()
    {
        activeTextBox = 8;
    }

    public void BloonsText6()
    {
        activeTextBox = 9;
    }

    public void BloonsText7()
    {
        activeTextBox = 10;
    }

    public void BloonsBadEnd()
    {
        activeScene = 5;
    }

    public void OceanSceneButton()
    {
        activeScene = 6;
        activeTextBox = 11;
    }

    public void OceanText2()
    {
        activeTextBox = 12;
    }

    public void OceanText3()
    {
        activeTextBox = 13;
    }

    public void OceanText4()
    {
        activeTextBox = 14;
    }

    public void OceanText5()
    {
        activeTextBox = 15;
    }

    public void BedroomBadEnd()
    {
        activeScene = 7;
        activeTextBox = 16;
    }

    public void BedroomGoodEnd()
    {
        activeScene = 7;
        activeTextBox = 17;
    }

    public void TheEndScene()
    {
        activeScene = 8;
    }

    //void CubeOnAndOff()
    //{
    //    if (isOn)
    //    {
    //        Cube.SetActive(true);
    //    }
    //    else
    //    {
    //        Cube.SetActive(false);
    //    }
    //}
}
