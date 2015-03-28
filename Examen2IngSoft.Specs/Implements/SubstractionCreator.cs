using Examen2IngSoft.Specs.Interfaces;

namespace Examen2IngSoft.Specs.Implements
{
    public class SubstractionCreator : ICreator
    {
        public IOperation FactoryMethod(ILog log)
        {
            return new Substraction(log);
        }
    }
}