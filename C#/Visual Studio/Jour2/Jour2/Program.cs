using System;

namespace Jour2
{
    class Program
    {
        public struct StructEmployee
        {
            public String Name;
            public int Age;
        }

        public enum Color { Rouge, Bleu , Orange, Vert }
        static void Main(string[] args)
        {
            /*String UserColor = "Orange";*/
            Color UserColor = Color.Bleu;

            if (UserColor.Equals(Color.Bleu)) // On compare avec .Equals pour une chaîne de caractères
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else
            {

            }

            switch (UserColor)
            {
                case Color.Rouge: 
                    Console.WriteLine("Rouge");
                    break;         
                case Color.Bleu: 
                    Console.WriteLine("Bleu");
                    break;
            }

            /*
             
            Animal Animal1 = new Animal();
            // Animal Animal2 = new Animal("Panda");
            Animal Animal2 = Animal1;

            Console.WriteLine(Animal1.GetEspece());
            Console.WriteLine(Animal2.ToString());
            
            */

            // char Patate = 'j'; // '' pour char, à l'inverse de string qui lui utilise les "".

            /*  

            int Test = 1;

            Console.WriteLine(Test++); // Affichera 1 car le ++ est après la variable
            Console.WriteLine(++Test); // Permet en console d'incrémenter pour l'affichage

            */

            /*

            for (int i = 0, i <= 10, i++) ;µ

            */

            /*  EXEMPLE ENUM (Enumération -> Liste fixe)
             *  
            enum Color { Rouge, Bleu, Vert, Orange };
            Color CouleurVoiture = Color.Rouge;
            Color CouleurVelo = Color.Vert;

            */

            /* EXEMPLE STRUCT (Structure -> Squelette d'un objet) 
              
            StructEmployee Employee1;
            Employee1.Name = "Paul";
            Employee1.Age = 19;
            
            Employee Employee2 = new Employee(Employee1.Name, Employee1.Age);

            */

            Boolean Flag = true;
            string Test = Flag ? "True" : "False"; // opérateur ternaire ( ? : )
            Console.WriteLine(Test);

            // Instruction de sélection if
/*
            if (true)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }      
*/
            // if en cascade -> Plutôt faire un switch, case, break.
/*
            if (Flag)
            {
                Console.WriteLine("True");
            }
            else if (Flag)
            {
                Console.WriteLine("False");
            }
            else if (Flag)
            {

            }
*/
            
        }


    }
}
