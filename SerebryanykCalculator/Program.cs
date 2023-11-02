using SerebryanykCalculator;
using SerebryanykCalculator.StateMachine.Classes;

CalculatorController consoleController = new CalculatorController(new SerebryanykToRealRubleState());
consoleController.Run();
