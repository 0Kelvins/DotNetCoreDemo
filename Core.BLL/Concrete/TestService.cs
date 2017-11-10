using Core.BLL.Abstract;
using Core.DAL.Abstract;
using Core.Model.Entity;

namespace Core.BLL.Concrete {
    public class TestService : ITestService
    {
        private readonly ITestRepository repository;

        public TestService(ITestRepository repository)
        {
            this.repository = repository;
        }

        public User GetUser()
        {
            return repository.GetUser();
        }
    }
}