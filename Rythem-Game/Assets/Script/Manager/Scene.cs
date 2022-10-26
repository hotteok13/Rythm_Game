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

        UnityEditor.EditorApplication.isPlaying = false;    //pc�� ���� �̺�Ʈ -> ����Ƽ �����͸� ���� ��Ŵ
 #else

         Application.Quit();                                //����Ͽ� ���� �̺�Ʈ -> ������ ���� ��Ŵ
#endif
    }

    public void GoGame()
    {
        SceneManager.LoadScene("Game");
    }
}
