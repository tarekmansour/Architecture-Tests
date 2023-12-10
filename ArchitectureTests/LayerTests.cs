using FluentAssertions;
using NetArchTest.Rules;

namespace ArchitectureTests;

public class LayerTests: BaseTest
{
    [Fact]
    public void Domain_Shoud_NotReferenceApplication()
    {
        //Arrange
        var types = Types.InAssembly(DomainAssembly);

        //Act
        var result = types
            .ShouldNot()
            .HaveDependencyOn(ApplicationAssembly.FullName)
            .GetResult();

        //Assert
        result.IsSuccessful.Should().BeTrue();
    }
}
