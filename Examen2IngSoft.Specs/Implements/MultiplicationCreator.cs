using Examen2IngSoft.Specs.Interfaces;

namespace Examen2IngSoft.Specs.Implements
{
    public class MultiplicationCreator : ICreator
    {
        public IOperation FactoryMethod(ILog log)
        {
            return new Multiplication(log);
        }
    }
}