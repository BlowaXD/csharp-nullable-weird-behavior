using System;
using System.Threading.Tasks;
using ProjectB;
using ProjectReferencingA;

namespace TestLul
{
    public class Class1
    {
        private readonly ITestDao _testClass;

        public Class1(ITestDao testClass)
        {
            _testClass = testClass;
        }

        public async Task Test()
        {
            await _testClass.SaveAsync(new TestDto());
        }
    }
}