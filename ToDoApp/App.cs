using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp
{
    class App : Utils
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.start();
            
            
        }

        public void start(){
            printMenu();
        }

    }
}
