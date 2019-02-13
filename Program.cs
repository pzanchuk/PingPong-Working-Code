using System;

class Program
{
  public static string CheckNumber(int input)
  {
    for (int i=0; i<=input; i++){
      if(i%5==0 && i%3==0){
        return "ping-pong";
      }else{
        if(i%3==0){
          return "ping";
        }else if(i%5==0){
          return "pong";
        }else{
          return Convert.ToString(i);
        }
      }
    }
  }
  public static void Main()
  {
    Console.WriteLine("Ping-Pong");
    Console.WriteLine("Enter a word number: ");
    int userInput = int.Parse(Console.ReadLine());
    Console.WriteLine(CheckNumber(userInput));
  }
}
