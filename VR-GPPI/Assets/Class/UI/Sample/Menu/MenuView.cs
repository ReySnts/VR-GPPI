using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    [SerializeField] private Button mainMenuButton;

    private void Awake() => mainMenuButton.onClick.AddListener(GoToMainMenu);

    private void GoToMainMenu() => SceneManager.LoadScene(sceneName: SceneName.MAIN_MENU);

    private void OnDestroy() => mainMenuButton.onClick.RemoveAllListeners();
}