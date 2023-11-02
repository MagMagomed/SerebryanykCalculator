using SerebryanykCalculator.StateMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerebryanykCalculator.StateMachine.Classes
{
    internal class RealRubleToSerebryanykState : IState
    {
        public string Name => "Перевод настоящих рублей в серебряники";

        public StateMachine stateMachine => new StateMachine();

        private Calculator _calculator { get; set; } = new Calculator();

        public string Calculate(IStatable statable, decimal value)
        {
            return _calculator.RealRubleToSerebryanyk(value).ToString();
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
