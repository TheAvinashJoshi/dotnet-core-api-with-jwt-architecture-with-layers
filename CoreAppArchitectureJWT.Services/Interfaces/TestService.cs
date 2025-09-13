using CoreAppArchitectureJWT.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAppArchitectureJWT.Services.Interfaces
{
    public class TestService : ITestInterface
    {
        public void PrintHello()
        {
            Console.WriteLine("Hello from TestService!");
        }
    }
}
