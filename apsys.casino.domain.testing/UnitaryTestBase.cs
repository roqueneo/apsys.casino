using Ninject;
using Ninject.MockingKernel.Moq;
using NUnit.Framework;

namespace apsys.casino.domain.testing
{
    public class UnitaryTestBase<T> where T : ITesteable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public UnitaryTestBase()
        {
            _moqMockingKernel = new MoqMockingKernel();
        }

        private MoqMockingKernel _moqMockingKernel;

        internal T ClassUnderTest { get; set; }

        [SetUp]
        public void SetUp()
        {
            ClassUnderTest = _moqMockingKernel.Get<T>();
            ClassUnderTest.SetMockData();
        }
    }
}
