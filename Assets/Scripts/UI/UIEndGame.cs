using UnityEngine;

public class UIEndGame : MonoBehaviour
{
    [SerializeField] private GameObject UIEndGamePanel;
    [SerializeField] private GameObject gamePlay, enemy;
    [SerializeField] private GameObject[] UIToHide;
    

    public void ShowPanel()
    {
        UIEndGamePanel.SetActive(true);
    }

    public void HideObjects()
    {
        gamePlay.SetActive(false);
        enemy.SetActive(false);
        
        foreach (var UI in UIToHide)
        {
            UI.SetActive(false);
        }
    }
}
