using System.Diagnostics.CodeAnalysis;

namespace LINQR3DotNetMNFD02
{
    public class EmpComp : IEqualityComparer<Employee>
    {
        /*-------------------------------------------------------------------------*/
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Id == y.Id;
        }
        /*-------------------------------------------------------------------------*/
        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id;
        }
        /*-------------------------------------------------------------------------*/
    }
}
