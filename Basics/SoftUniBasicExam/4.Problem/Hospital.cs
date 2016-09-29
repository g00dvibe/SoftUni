using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Problem
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var daysInMind = int.Parse(Console.ReadLine());
            int doctors = 7, patientsToGo =0, patientsPassed =0, patientsInput, patentsLeft , daysPassed=0;

            for (int i=1; i <= daysInMind; i++)
            {
                patientsInput = int.Parse(Console.ReadLine());
                daysPassed++;
                if (daysPassed % 3 ==0 && patientsPassed < patientsToGo)
                {
                    doctors += 1;
                }

                if (patientsInput <= doctors)
                {
                    patientsPassed += patientsInput;
                }
                else if (patientsInput > doctors)
                {
                    patientsPassed = patientsPassed + doctors;              
                    patientsToGo = patientsToGo + (patientsInput - doctors);
                }

                //patientsToGo = patientsToGo + Math.Abs(patientsInput - doctors);
                //patientsPassed = patientsPassed + Math.Abs(patientsInput - patientsToGo);
                Console.WriteLine("patient to go {0} \n patients passed {1}", patientsToGo, patientsPassed);

            }
            Console.WriteLine("Treated patients: {0}.", patientsPassed);
            Console.WriteLine("Untreated patients: {0}.", patientsToGo);
            /// > !!!
        }
    }
}
