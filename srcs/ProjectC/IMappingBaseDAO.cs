// WingsEmu
// 
// Developed by NosWings Team

using ProjectB;
using ProjectWithNullableActivated;

namespace ProjectReferencingA
{
    public interface ITestDao : IGenericAsyncLongRepository<TestDto>
    {
        
    }
}