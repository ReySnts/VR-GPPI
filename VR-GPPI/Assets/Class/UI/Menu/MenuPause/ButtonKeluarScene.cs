using UnityEngine.SceneManagement;

public class ButtonKeluarScene : ButtonScript
{
    public override void OnClick() => SceneManager.LoadScene(sceneName: SceneName.MAIN_MENU);
}