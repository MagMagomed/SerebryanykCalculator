using SerebryanykCalculator.StateMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerebryanykCalculator.StateMachine.Classes
{
    internal class SerebryanykToRubleState : State
    {
        public override string Name => "Перевод серебрянников в вымышленные рубли";
        private Calculator _calculator { get; set; } = new Calculator();

        public override decimal Calculate(IStatable statable, decimal value)
        {
            return _calculator.SerebryanykToRuble(value);
        }

        
    }
}
