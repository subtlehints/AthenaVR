using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    public string stage;

	// Use this for initialization
	public void Start () {
        if (stage == "CyclistRoad")
        {
            SceneManager.LoadScene("CyclistPark");
        }
        else if (stage == "CyclistPark")
        {
            SceneManager.LoadScene("PedestrainScene");
        }
        else if (stage == "ToTutorial")
        {
            SceneManager.LoadScene("CyclistRoad");
        }
        else if (stage == "ToSTM")
        {
            SceneManager.LoadScene("SpotTheMistake");
        }
        else if (stage == "UserSelect")
        {
            SceneManager.LoadScene("MainMenu");
        }
        else if (stage == "BacktoSelection")
        {
            SceneManager.LoadScene("UserSelection");
        }
        else if (stage == "AdminSelect")
        {
            SceneManager.LoadScene("LoginScene");
        }
        else if (stage == "AdminScene")
        {
            SceneManager.LoadScene("AdminScene");
        }
        else if (stage == "preview")
        {
            SceneManager.LoadScene("UpdatedChangesScene");
        }
        else if (stage == "ToPedesStage")
        {
            SceneManager.LoadScene("PedestrainStage");
        }
        else if (stage == "ToCyclistStage")
        {
            SceneManager.LoadScene("CyclistStage");
        }
    }
	
}
