using SerebryanykCalculator.StateMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerebryanykCalculator.StateMachine.Classes
{
    internal abstract class State : IState
    {
        public abstract string Name { get; }
        public abstract decimal Calculate(IStatable statable, decimal value);
        public StateMachine stateMachine => new StateMachine();
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
