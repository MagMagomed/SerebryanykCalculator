using SerebryanykCalculator.StateMachine.Interfaces;

namespace SerebryanykCalculator.StateMachine.Classes
{
    internal class SerebryanykToRealRubleState : IState
    {
        public string Name => "Перевод серебрянников в настоящие рубли";

        public StateMachine stateMachine => new StateMachine();

        private Calculator _calculator { get; set; } = new Calculator();

        public string Calculate(IStatable statable, decimal value)
        {
            return _calculator.SerebryanykToRealRuble(value).ToString();
        }

        public void Next(IStatable statable)
        {
            statable.SetState(stateMachine.Next(this));
        }

        public void Previous(IStatable statable)
        {
            statable.SetState(stateMachine.Previous(this));
        }
    }
}