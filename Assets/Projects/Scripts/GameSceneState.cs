using UnityEngine;

public class GameSceneState : IState
{
    public void Enter()
    {
        Debug.Log($"{GetType().Name} が始まります。");
    }

    public void Execute()
    {

    }

    public void Exit()
    {
        Debug.Log($"{GetType().Name} が終了します。");
    }
}
