using SerebryanykCalculator.StateMachine.Interfaces;

namespace SerebryanykCalculator.StateMachine.Classes
{
    internal class SerebryanykToRealRubleState : State
    {
        public override string Name => "Перевод серебрянников в настоящие рубли";
        private Calculator _calculator { get; set; } = new Calculator();

        public override decimal Calculate(IStatable statable, decimal value)
        {
            return _calculator.SerebryanykToRealRuble(value);
        }
    }
}