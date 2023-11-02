namespace SerebryanykCalculator.StateMachine.Interfaces
{
    internal interface IStatable
    {
        void SetState(IState newState); 
    }
}