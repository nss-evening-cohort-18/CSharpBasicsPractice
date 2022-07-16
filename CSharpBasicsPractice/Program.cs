namespace CSharpBasicsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {//instance/instantiate vs initialize

            //string[] animals = new string[4];
            List<string> animals = new List<string>();

            string name = "Brian";
            name = name + 1;
            Console.WriteLine(name);
            var myListOfStuff = new List<List<List<string>>>();

            int number = 12435;
            
            List<string> varNameGoesHere = new List<string> ();
            int length = animals.Count;
            //animals.Add("Toucan");
            //animals.Add("Toucan");
            //animals.Add("Toucan");
            //animals.Add("Toucan");
            //animals.Add("Toucan");
            //animals.Add("Toucan");
            //animals.Add("Toucan");
            length = animals.Count;

            //, "Gorilla", "Corgi", "Toucan" };
            //animals.Append("T-Rex");
            length = animals.Count;

            //List<string> newAnimals = animals.Select( animal => animal + "!").ToList();

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }



            Console.ReadKey(); // What happens if you run the app without this line?
            
        }
    }
}