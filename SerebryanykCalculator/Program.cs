using SerebryanykCalculator;
using SerebryanykCalculator.StateMachine.Classes;

ConsoleController consoleController = new ConsoleController(new SerebryanykToRealRubleState());
consoleController.Run();
