﻿using SerebryanykCalculator.StateMachine.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerebryanykCalculator.StateMachine.Classes
{
    internal class ConsoleController : IStatable
    {
        private IState State { get; set; }
        public ConsoleController(IState state) {
            State = state;
        }
        public void ReadLine()
        {
            Console.ForegroundColor = ConsoleColor.White;
            var command = Console.ReadLine();
            if (command == null) throw new ArgumentNullException(nameof(command));
            if (command == "Next")
            {
                State.Next(this);
            }
            else if (command == "Previous")
            {
                State.Previous(this);
            }
            else if (Decimal.TryParse(command, out var value))
            {
                WriteLine(State.Calculate(this, value));
            }
        }
        public void WriteLine(object value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
        }

        public void SetState(IState newState)
        {
            State = newState;
        }

        public void Run()
        {
            while (true)
            {
                WriteLine($"You are in {State.Name} state. Next, Previous Or Number");
                ReadLine();
            }
        }
    }
}