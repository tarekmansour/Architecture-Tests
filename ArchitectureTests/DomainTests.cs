using AppSample.Domain.Abstractions;
using FluentAssertions;
using NetArchTest.Rules;
using System.Reflection;

namespace ArchitectureTests;

public class DomainTests: BaseTest
{
    [Fact]
    public void DomainClasses_Should_BeSeald()
    {
        //Arrange
        var types = Types.InAssembly(DomainAssembly);

        //Act
        var result = types
            .That()
            .Inherit(typeof(Entity))
            .Should()
            .BeSealed()
            .GetResult();

        //Assert
        result.IsSuccessful.Should().BeTrue();
    }

    [Fact]
    public void Entities_Should_HavePrivateParameterlessConstructor()
    {
        // Arrange
        var entityTypes = Types.InAssembly(Assembly.Load("AppSample.Domain"))
            .That()
            .Inherit(typeof(Entity))
            .GetTypes();

        var failingTypes = new List<Type>();

        // Act
        foreach (var entityType in entityTypes)
        {
            var constructors = entityType.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);

            if (!constructors.Any(c => c.IsPrivate && c.GetParameters().Length == 0))
            {
                failingTypes.Add(entityType);
            }
        }

        // Assert
        failingTypes.Should().BeEmpty();
    }
}
