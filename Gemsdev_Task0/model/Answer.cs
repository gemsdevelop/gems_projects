using System.Text;

namespace Gemsdev_Task0;

public class Answer
{
    private static double _eps = 0.000001;
    
    private double _x1, _x2;
    private string _message;

    public Answer()
    {
        _x1 = 0;
        _x2 = 0;
        _message = "";
    }
    public Answer(double x1, double x2)
    {
        _x1 = x1;
        _x2 = x2;
        _message = "";
    }

    public double X1
    {
        get => _x1;
        set => _x1 = value;
    }

    public double X2
    {
        get => _x2;
        set => _x2 = value;
    }
    
    public string Message
    {
        get => _message;
        set => _message = value;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder("");
        if (Math.Abs(_x1 - _x2) > _eps && _message == "")
        {
            stringBuilder.Append("x1 = ");
            stringBuilder.Append(_x1);
            stringBuilder.Append(" x2 = ");
            stringBuilder.Append(_x2);
            return stringBuilder.ToString();
        }
        
        if (Math.Abs(_x1 - _x2) <= _eps && _message == "")
        {
            stringBuilder.Append("x1 = ");
            stringBuilder.Append(_x1);
            return stringBuilder.ToString();
        }
        return _message;
    }
}