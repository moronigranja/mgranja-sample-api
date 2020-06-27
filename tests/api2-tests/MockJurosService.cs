using Mgranja.api2;

namespace api1_tests
{
    internal class MockJurosService : IJurosService
    {
        public double GetJuros()
        {
            return 0.01;
        }
    }
}