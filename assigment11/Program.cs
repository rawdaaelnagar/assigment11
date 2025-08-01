

int smallcarpet = 25;
int largecarpet = 35;
float tax = 0.06f;
Console.WriteLine("enter the num of smallcarpet u wanna to wash");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the num of  large carpet u wanna to wash");
int num2 = Convert.ToInt32(Console.ReadLine());
float total = smallcarpet * num1 + largecarpet * num2 + tax;
Console.WriteLine($"total={total}");