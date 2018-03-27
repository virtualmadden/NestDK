using FluentAssertions;
using NUnit.Framework;

namespace NestDK.Tests
{
    [TestFixture]
    public class TruthyTests
    {
        [SetUp]
        public void SetUp()
        {
            _theTruth = true;
        }

        private bool _theTruth;

        [Test]
        public void ShouldBeTrue()
        {
            _theTruth.Should().BeTrue();
        }
    }
}