## Asp.Net Core 2.0 Demo

SDK: .Net Core 2.0
IDE: VSCode

### 记录
1. 部分命令，其他``dotnet --help``
```bash
dotnet new mvc -n "Core.Web" # 新建MVC工程
dotnet new classlib -n "Core.Model" # 新建类库
dotnet build # 编译
dotnet run # 运行
```

2. `*.csproj`文件内配置类库引用
```xml
  <ItemGroup>
    <PackageReference Include="Microsoft.AspNetCore.All" Version="2.0.0" />
  </ItemGroup>
  <!-- 新加一个ItemGroup配置工程引用 -->
  <ItemGroup>
    <ProjectReference Include="..\Core.Model\Core.Model.csproj" />
    <!-- …… -->
  </ItemGroup>
```

3. 默认依赖注入
在Web项目里的`Startup.cs`中`ConfigureServices`方法内配置
```c#
public void ConfigureServices(IServiceCollection services)
{
    services.AddMvc();

    // 自己的依赖注入可选AddSingleton（始终单例）、AddScoped（一次请求内单例）、AddTransient（瞬态）
    services.AddSingleton<ITestRepository, TestRepository>();
    services.AddSingleton<ITestService, TestService>();
}
```
在使用时，要注意被注入的类型，这里是接口，就不要直接类做成员属性了，不然注入不正确
如下，是`ITestRepository`，而不是`TestRepository`
```c#
    public class TestService : ITestService
    {
        private readonly ITestRepository repository;

        public TestService(ITestRepository repository)
        {
            this.repository = repository;
        }
    ... ...
```

### 小结
环境正常的情况下，构建体验很轻松
(之前的系统有问题，就怎么也运行不了)