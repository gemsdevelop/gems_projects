using Gemsdev_Task0.interfaces;
using Gemsdev_Task0.model;

namespace Gemsdev_Task0;

public class Handler
{
    private IDataInput _dataInput;
    private IDataOutput _dataOutput;

    public Handler(IDataInput dataInput, IDataOutput dataOutput)
    {
        _dataInput = dataInput;
        _dataOutput = dataOutput;
    }

    public void Handle()
    {
        List<SquareEquation> squareEquations = _dataInput.input();
        List<Answer> answers = SquareEquationSolver.SolveSquareEquations(squareEquations);
        _dataOutput.output(answers);
    }
}