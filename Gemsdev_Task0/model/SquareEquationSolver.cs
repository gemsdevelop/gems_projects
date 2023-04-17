namespace Gemsdev_Task0.model
{
    public class SquareEquationSolver
    {
        // Вызов данного метода решит переданное квадратное уравнение и присвоит корни полям _x1 и _x2 объекта answer.
        // (если корень один, то он будет в одоих полях) Так же в случае отсутствия корней будет брошено исключение
        // ArgumentException.
        public static Answer SolveSquareEquation(SquareEquation squareEquation)
        {
            double D = squareEquation.B * squareEquation.B - 4 * squareEquation.A * squareEquation.C;
            Answer answer = new Answer();
            if (D > 0) 
            {
                answer.X1 = (-squareEquation.B - Math.Sqrt(D)) / (2 * squareEquation.A);
                answer.X2 = (-squareEquation.B + Math.Sqrt(D)) / (2 * squareEquation.A);
                return answer;
            }
        
            if (D == 0) 
            {
                answer.X1 = (-squareEquation.B) / (2 * squareEquation.A);
                answer.X2 = answer.X1;
                return answer;
            }

            answer.Message = "У данного квадратного уравнения нет корней!";
            return answer;
        }

        public static List<Answer> SolveSquareEquations(List<SquareEquation> squareEquations)
        {
            if (squareEquations == null || squareEquations.Count == 0)
            {
                throw new ArgumentException("Список уравнений null или пуст.");
            }

            List<Answer> answers = new List<Answer>();
            foreach (SquareEquation squareEquation in squareEquations)
            {
                answers.Add(SolveSquareEquation(squareEquation));
            }

            return answers;
        }
    }
}