using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Abstractions;

   
    
        public class JcConsole : IConsole
        {
            public void Log(string message)
            {
                Console.WriteLine(message);
            }
        }
    

