using System;

namespace Week7Arrays
{
    class Program
    {
      static void Main(string[] args)
        {
            //programm palub kasutajal valida, mida ta hommikusöögiks sööb

            string[] food = { "Võileib juustuga", "Banaan", "Jogurt", "Peekon", "Muna" };

            food[3] = "Viinerid friikatulitega";
            food[2] = "Piim";

            Console.WriteLine("Menüüs: ");

            for(int i = 0; i < food.Length; i++)
            {
                
                Console.WriteLine(food[i]);
            }

            Console.WriteLine("Vali toit (sisesta number 1-5): ");
            int UserChoice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Valisid hommikusöögiks {food[UserChoice]}");



        }
    }
}
