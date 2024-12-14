using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{

    public string nameOfPlayer;
    public string saveName;

    public TMP_Text inputText;
    public TMP_Text loadedName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Reset the value of "name" to "your_name" at the start of the game
        PlayerPrefs.SetString("name", "your_name");
        PlayerPrefs.Save(); // Ensure the change is saved immediately
    }

    // Update is called once per frame
    void Update()
    {
        nameOfPlayer = PlayerPrefs.GetString("name", "your_name");
        loadedName.text = nameOfPlayer;
    }
    public void SetName()
    {
        saveName = inputText.text;
        PlayerPrefs.SetString("name", saveName);
        PlayerPrefs.Save(); // Ensure the change is saved immediately
    }
}
