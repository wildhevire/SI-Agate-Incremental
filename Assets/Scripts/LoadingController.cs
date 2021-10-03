using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingController : MonoBehaviour
{
    private void Start()
    {
        UserDataManager.LoadFromLocal();
        SceneManager.LoadScene(1);

    }
}