using SerebryanykCalculator.StateMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerebryanykCalculator.StateMachine.Classes
{
    internal class StateMachine
    {
        private static List<IState> StateList { get; set; }
        public StateMachine() 
        {
            if(StateList == null)
            {
                StateList = new List<IState>();
                StateList.Add(new SerebryanykToRealRubleState());
                StateList.Add(new RealRubleToSerebryanykState());
                StateList.Add(new SerebryanykToRubleState());
            }
        }
        public IState Next(IState state)
        {
            for(int i = 0; i < StateList.Count; i++)
            {
                if(state.Name == StateList[i].Name)
                {
                    if(i == StateList.Count - 1)
                    {
                        return StateList[0];
                    }
                    else
                    {
                        return StateList[i + 1];
                    }
                }
            }
            return state;
        }
        public IState Previous(IState state)
        {
            for (int i = 0; i < StateList.Count; i++)
            {
                if (state.Name == StateList[i].Name)
                {
                    if (i != 0)
                    {
                        return StateList[i - 1];
                    }
                    else
                    {
                        return StateList[StateList.Count - 1];
                    }
                }
            }
            return state;
        }
    }
}
