using Examen2IngSoft.Specs.Interfaces;

namespace Examen2IngSoft.Specs.Implements
{
    public class AdditionCreator:ICreator
    {
        public IOperation FactoryMethod(ILog log)
        {
           return new Addition(log);
        }
    }
}
