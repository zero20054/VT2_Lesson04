using UnityEngine;

public class SceneManager : MonoBehaviour
{
    private IState _currentSceneState;          // 現在実行中の画面
    void Start()
    {
        _currentSceneState = new TitleSceneState();     // タイトル画面の状態を生成
        _currentSceneState.Enter();                     // タイトル画面を開始する
    }


    void Update()
    {

    }
}
