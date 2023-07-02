// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program{
    static void Main(string[]args){
    Console.Clear();
    Console.WriteLine("Input sentence");
    string [] words = SplitText(Console.ReadLine()!);
    Console.WriteLine("Words array:"); 
    PrintArray (words);
        static void PrintArray (string [] array){
        foreach (string word in array){
        Console.WriteLine(word);
        }
    }
    static string [] SplitText(string sentence){
        string [] arr = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return arr;
    }
    }
}
