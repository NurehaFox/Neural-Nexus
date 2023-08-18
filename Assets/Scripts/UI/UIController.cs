using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    private void Awake()
    {
        instance = this;
    }

    public TMP_Text moneyText;
    public GameObject notEnoughMoneyWarning;

    public GameObject gameOver;

    public GameObject towerButtons;

    public string  mainMenuScene;

    public GameObject pauseScreen;

    public TowerUpgradePanel towerUpgradePanel;

    public TMP_Text waveText;

    public TMP_Text scoreText;
    public float scoreAmount;
    public float pointIncreasePerSecond;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasePerSecond = .5f;    
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Survial Time : " + scoreAmount.ToString("1") + "Seconds";
        scoreAmount += pointIncreasePerSecond * Time.fixedDeltaTime;

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();
        }
    }

    public void PauseUnpause()
    {
        if(pauseScreen.activeSelf == false)
        {
            pauseScreen.SetActive(true);

            Time.timeScale = 0f;
        } else
        {
            pauseScreen.SetActive(false);

            Time.timeScale = 1f;
        }
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(mainMenuScene);
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void OpenTowerUpgradePanel()
    {
        if (LevelManager.instance.levelActive)
        {
            towerUpgradePanel.gameObject.SetActive(true);
            towerUpgradePanel.SetupPanel();
        }
    }

    public void CloseTowerUpgradePanel()
    {
        towerUpgradePanel.gameObject.SetActive(false);

        if (TowerManager.instance.selectedTower != null)
        {
            TowerManager.instance.selectedTower.rangeModel.SetActive(false);
            TowerManager.instance.selectedTower = null;
        }

        TowerManager.instance.selectedTowerEffect.SetActive(false);

        notEnoughMoneyWarning.SetActive(false);
    }
}
