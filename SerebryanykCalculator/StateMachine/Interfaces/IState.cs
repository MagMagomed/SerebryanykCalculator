using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerebryanykCalculator.StateMachine.Interfaces
{
    internal interface IState
    {
        string Name { get; }
        StateMachine.Classes.StateMachine stateMachine { get; }
        void Next(IStatable statable);
        void Previous(IStatable statable);
        decimal Calculate(IStatable statable, decimal value);
    }
}
