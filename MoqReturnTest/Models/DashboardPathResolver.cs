namespace MoqReturnTest.Models
{
   public class DashboardPathResolver
    {
        private readonly IPathData _pathData;
        private readonly IPageRepository _repository;
        private readonly IControllerMapper _mapper;
        private readonly IContainer _container;

        public DashboardPathResolver(IPathData pathData, IPageRepository repository, IControllerMapper mapper, IContainer container)
        {
            _pathData = pathData;
            _repository = repository;
            _mapper = mapper;
            _container = container;
        }

        public IPathData ResolvePath(string url)
        {
            var page = _repository.GetPageByUrl<IPageModel>(url);
            if (page != null)
            {
                // Configure the pathData properties if page is found
                return _pathData;
            }
            return null;
        }
    }
}
