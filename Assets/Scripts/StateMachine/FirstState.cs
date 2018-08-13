using UnityEngine;
using StateStuff;


public class FirstState : State<AI> 
{
    private static FirstState _instance;

private void Start()
    {
        
    }

    private FirstState()
    {
        if(_instance != null)
        {
            return;
        }

        _instance = this;
    }

    public static FirstState Instance
    {
        get 
        {
            if(_instance == null)
            {
                new FirstState();
            }
            return _instance;
        }
    }

    public override void EnterState(AI _Owner)
    {
        Camera.main.backgroundColor = Color.grey;

    }

    public override void ExitState(AI _Owner)
    {
        
    }

    public override void UpdateState(AI _Owner)
    {
        if(_Owner.switchState)
        {
            _Owner.stateMachine.ChangeState(SecondState.Instance);
        }


    }


}
