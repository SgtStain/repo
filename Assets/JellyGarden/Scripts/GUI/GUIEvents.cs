using UnityEngine;
using System.Collections;


public class GUIEvents : MonoBehaviour {

    void Update()
    {
        if (name == "FaceBook" || name == "Share")
        {
            if (LevelManager.THIS.FacebookDisable)
                gameObject.SetActive(false);
        }
    }

    public void Settings()
    {
        SoundBase.Instance.GetComponent<AudioSource>().PlayOneShot(SoundBase.Instance.click);

        GameObject.Find("CanvasGlobal").transform.Find("Settings").gameObject.SetActive(true);

    }
    public void Play()
    {
        SoundBase.Instance.GetComponent<AudioSource>().PlayOneShot(SoundBase.Instance.click);

        transform.Find("Loading").gameObject.SetActive(true);
        Application.LoadLevel("game");
    }

    public void Pause()
    {
        SoundBase.Instance.GetComponent<AudioSource>().PlayOneShot(SoundBase.Instance.click);

        if(LevelManager.THIS.gameStatus == GameState.Playing)
            GameObject.Find("CanvasGlobal").transform.Find("MenuPause").gameObject.SetActive(true);

    }

    public void FaceBookLogin()
    {
        InitScript.Instance.CallFBLogin();
    }
    public void Share()
    {
        InitScript.Instance.Share();
    }

}
