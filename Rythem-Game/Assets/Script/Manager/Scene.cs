using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void GoLobby()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void Exit()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;    //pc용 종료 이벤트 -> 유니티 에디터를 종료 시킴
 #else

         Application.Quit();                                //모바일용 종료 이벤트 -> 어플을 종료 시킴
#endif
    }

    public void GoGame()
    {
        SceneManager.LoadScene("Game");
    }
}
