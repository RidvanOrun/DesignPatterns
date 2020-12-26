using BuilderPattern.Lab1.Delegate;

namespace BuilderPattern.Lab1.Concretes
{
    public abstract class BaseProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();

        public abstract ProductModel GetModel();
    }
}