//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Enter number");
int NumberA = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(NumberA);
int result = 0;

for (int i = 0; i < stringNumber.Length; i++) 
{
    result = result + Convert.ToInt32(stringNumber[i].ToString());

}

Console.WriteLine(result);




