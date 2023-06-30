// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program{
    static void Main(string[]args){
    Console.Clear();
    Console.WriteLine("Input sentence");
    string [] words = SplitText(Console.ReadLine()!);
    string [] reverseWords = Reverse(words);
    Console.WriteLine("Words array:"); 
    PrintArray (reverseWords);
    static void PrintArray (string [] array){
        foreach (string word in array){
        Console.WriteLine(word);
        }
    }
    static string [] SplitText(string sentence){
        string [] arr = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return arr;
    }
    static string [] Reverse(string [] arr){
        string [] reverseArr = new string [arr.Length];
        for (int i = 0; i<arr.Length; i++){
            reverseArr[i] = arr[arr.Length-1-i];
        }
        return reverseArr;

    } 
    }
}