// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program{
    static void Main(string[]args){
    Console.Clear();
    Console.WriteLine("Input sentence");
    string [] reverseWords = ReversWords(Console.ReadLine()!);
    Console.WriteLine("Reversed sentence:"); 
    PrintArray (reverseWords);
    static void PrintArray (string [] array){
        foreach (string word in array){
        Console.Write($"{word} ");
        }
    }
    Console.WriteLine();
    static string [] Reverse(string sentence){
        string [] arr = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return arr;
    }
    static string [] ReversWords(string sentence){
        string [] arr = Reverse(sentence);
        string [] reverseArr = new string [arr.Length];
        for (int i = 0; i<arr.Length; i++){
            reverseArr[i] = arr[arr.Length-1-i];
        }
        return reverseArr;
    } 
    }
}