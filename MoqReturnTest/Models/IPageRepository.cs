namespace MoqReturnTest.Models
{
    public interface IPageRepository
    {
        T GetPageByUrl<T>(string url) where T : class;
    }
}
