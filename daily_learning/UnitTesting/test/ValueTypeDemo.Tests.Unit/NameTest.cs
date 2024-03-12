using FluentAssertions;


namespace ValueTypeDemo.Tests.Unit
{
    public class NameTest
    {
        Person _sut = new Person();
        
        [Fact]
        
        public void AssertionTestExample()
        {
            var name = _sut.name;
            //name.Should().Be("maria");
            name.Should().StartWith("maria");
        }
        [Fact]
        public void AssertionTestExample2() 
        {
            //var _sut= new Persons();
            var expected = new Person

            {

                name = "maria b augustine"
            };
            _sut.Should().BeEquivalentTo(expected);
        }
    }
}