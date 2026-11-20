using UnityEngine;
using UnityEngine.SceneManagement;
 
public class SceneLoader : MonoBehaviour
{
    public string sceneName;   // 20261014
 
    public void Load()
    {
    SceneFader.Go(sceneName);
    }
}
