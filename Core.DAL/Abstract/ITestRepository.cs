using Core.Model.Entity;

namespace Core.DAL.Abstract {
    public interface ITestRepository {
        // 获取用户信息
        User GetUser();
    }
}