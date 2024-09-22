namespace HashSet {
    class Program {
        static void Main() { 
            HashSet<int> a = new HashSet<int>();

            a.Add(1);
            a.Add(2);
            a.Add(1);

            Console.WriteLine(a.Count);

            // HashSet são quase iguais a lista, porem ele é uma lista de numero unicos, então ele ignora a segunda vez que tentei adicionar o numero 1
        }
    }
}
