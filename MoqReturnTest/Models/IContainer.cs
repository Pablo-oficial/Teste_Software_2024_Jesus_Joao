namespace MoqReturnTest.Models
{
    public interface IContainer
    {
        T GetInstance<T>();
    }
}
