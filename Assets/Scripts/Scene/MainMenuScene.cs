using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MainMenuScene : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Button btnPlay;

    private void Awake()
    {
        btnPlay.onClick.AddListener(onClickBtnPlay);
    }
    void Start()
    {
        init();
    }

    private void OnEnable()
    {
        SoundManager.I.StopMusic();
        SoundManager.I.PlayMusic(Global.SoundName.Hardest_BGM81);
    }

    private void init()
    {

    }

    private void onClickBtnPlay()
    {
        SoundManager.I.PlaySFX(Global.SoundName.Hardest_btn_pop);
        SceneManager.LoadScene(Global.SceneName.s_gamePlay);
    }
}
