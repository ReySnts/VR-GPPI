using UnityEngine.SceneManagement;

public class ButtonPelatihan : ButtonScript
{
    public override void OnClick() => SceneManager.LoadScene(sceneName: SceneName.PLAY);
}