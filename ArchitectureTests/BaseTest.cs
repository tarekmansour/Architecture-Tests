using AppSample.Application;
using AppSample.Domain.Abstractions;
using System.Reflection;

namespace ArchitectureTests
{
    public abstract class BaseTest
    {
        protected static readonly Assembly DomainAssembly = typeof(Entity).Assembly;
        protected static readonly Assembly ApplicationAssembly = typeof(ApplicationMember).Assembly;
    }
}
