using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NrRational
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Tipul de date Rational definit de utilizator
            //Sa se implementeze un tip de date pentru lucrul cu numere rationale(numarator / numitor).Sa se defineasca pentru acest tip operatiile de adunare, scadere, inmultire, impartire, ridicarea la putere, operatorii relationali, precum si o operatie pentru aducerea fractiei la forma ireductibila(simplificarea fractiei). Un astfel de obiect va putea fi initializat in 3 moduri: Rational(), Rational(numarator), Rational(numarator, numitor).

            //Se poate utiliza supraincarcarea constructorului sau un singur constructor cu parametri optionali, avand valori implicite.
            //Operatiile aritmetice si operatorii relationali(<, <=, >, >=, ==, !=) vor fi implementati ca si operatori in clasa.
            //Numitorul comun este c.m.m.m.c.(numitor1, numitor2).
            //Fractia se poate simplifica cu c.m.m.d.c.(numarator, numitor).


            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(3, 4);

            Rational r3 = r1.Sum(r2);
            Console.WriteLine($"{r1} + {r2} = {r3}");

            Rational r4 = r1.Subtract(r2);
            Console.WriteLine($"{r1} - {r2} = {r4}");

            Rational r5 = r1.Multiply(r2);
            Console.WriteLine($"{r1} * {r2} = {r5}");

            Rational r6 = r1.Divide(r2);
            Console.WriteLine($"{r1} / {r2} = {r6}");

            int k = 3;
            Rational r7 = r1.Power(k);
            Console.WriteLine($"{r1} ^ {k} = {r7}");

            Console.ReadKey();
        }
    }
}
