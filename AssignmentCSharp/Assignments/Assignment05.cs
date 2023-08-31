using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignments.Common;

namespace Assignments
{
    //Question 5: Create a CRUD based App for developing a Movie Database software where the user can add, remove and update movies of his Video library. It should be a menu driven program that has 4 use cases for add, removing, finding and updating movie info in the application.
    class Assignment05
    {   
        static void Main(string[] args)
        {
            MovieDatabase.MovieMenuDriven();
        }
    }
}
