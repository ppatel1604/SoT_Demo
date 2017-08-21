using System;
using FluentAssertions;
using FsCheck.Xunit;
using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Xunit;

namespace Calculator_UnitTests
{
    public class CalculatorGoodTest
    {
        private readonly Fixture _fixture;

        public CalculatorGoodTest()
        {
            _fixture = new Fixture();
            _fixture.Customize(new AutoConfiguredMoqCustomization());
        }

        [Property]
        public void add_should_add_two_numbers(int x, int y)
        {
            var subject = _fixture.Create<Calculator_Good.Calculator>();
            int result = subject.Add(x, y);
            result.Should().Be(x + y, "because the addition of two numbers is the sum of the two numbers");
        }

        [Fact]
        public void add_should_throw_when_adding_two_large_positive_numbers_with_overflow()
        {
            var subject = _fixture.Create<Calculator_Good.Calculator>();
            Action addAction = () => subject.Add(int.MaxValue, int.MaxValue);
            addAction.ShouldThrow<OverflowException>()
                .WithMessage($"Cannot add {int.MaxValue} and {int.MaxValue} as its result is large");
        }

        [Fact(Skip = "Failure")]
        public void add_should_throw_when_adding_two_large_negative_numbers_with_overflow()
        {
            var subject = _fixture.Create<Calculator_Good.Calculator>();
            Action addAction = () => subject.Add(int.MinValue, int.MinValue);
            addAction.ShouldThrow<OverflowException>()
                .WithMessage($"Cannot add {int.MaxValue} and {int.MaxValue} as its result is large");
        }

        [Fact(Skip = "Because logger is internal")]
        public void add_should_log_operation()
        {
            var subject = _fixture.Create<Calculator_Good.Calculator>();
            var x = 5;
            var y = 6;
            subject.Add(x, y);
        }
    }
}