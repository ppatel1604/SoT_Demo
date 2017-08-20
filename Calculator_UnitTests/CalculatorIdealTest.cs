using System;
using FluentAssertions;
using FsCheck.Xunit;
using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Xunit;

namespace Calculator_UnitTests
{
    public class CalculatorIdealTest
    {
        private readonly Fixture _fixture;

        public CalculatorIdealTest()
        {
            _fixture = new Fixture();
            _fixture.Customize(new AutoConfiguredMoqCustomization());
        }

        [Property]
        public void add_should_add_two_numbers(int x, int y)
        {
            var subject = _fixture.Create<Calculator_Ideal.Calculator>();
            int result = subject.Add(x, y);
            result.Should().Be(x + y, "because the addition of two number is the sum of the two numbers");
        }

        [Fact]
        public void add_should_throw_when_adding_two_numbers_with_overflow()
        {
            var subject = _fixture.Create<Calculator_Ideal.Calculator>();
            Action addAction = () => subject.Add(int.MaxValue, int.MaxValue);
            addAction.ShouldThrow<OverflowException>().WithMessage($"Cannot add {int.MaxValue} and {int.MaxValue} as its result is large");
        }

        [Fact]
        public void add_should_log_operation()
        {
            var loggerMock = new Mock<Calculator_Ideal.ILogger>();

            _fixture.Inject(loggerMock);

            var subject = _fixture.Create<Calculator_Ideal.Calculator>();
            var x = 5;
            var y = 6;
            subject.Add(x, y);
            
            loggerMock.Verify(l => l.Log($"Adding two values <{x}> and <{y}>"), Times.Once);
        }
    }
}
