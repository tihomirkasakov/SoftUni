using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var doctors = 7;
            var ostatykOtPregleda = 0.0;
            var pregledaniPacienti = 0.0;
            for (int patientsPerDay = 1; patientsPerDay <= period; patientsPerDay++)
            {
                var numberOfPatients = int.Parse(Console.ReadLine());
                if (patientsPerDay%3==0&&ostatykOtPregleda>pregledaniPacienti)
                {
                    doctors += 1;
                }
                var a = numberOfPatients - doctors;
                if (a<0)
                {
                    a = 0;
                }
                ostatykOtPregleda = ostatykOtPregleda + (a);
                if (numberOfPatients<doctors)
                {
                    pregledaniPacienti = pregledaniPacienti + numberOfPatients;
                }
                else
                {
                    pregledaniPacienti = pregledaniPacienti + doctors;
                }
            }
            Console.WriteLine($"Treated patients: {pregledaniPacienti}.");
            Console.WriteLine($"Untreated patients: {ostatykOtPregleda}.");
        }
    }
}
