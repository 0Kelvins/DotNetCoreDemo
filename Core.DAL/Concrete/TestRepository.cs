using Core.DAL.Abstract;
using Core.Model.Entity;

namespace Core.DAL.Concrete {
    public class TestRepository : ITestRepository {
        
        public User GetUser()
        {
            return new User(1001, "用户A", "123456");
        }
    }
}