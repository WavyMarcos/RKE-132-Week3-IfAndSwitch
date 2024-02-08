Console.WriteLine("Enter a number:");
int userNum  = Convert.ToInt32(Console.ReadLine());

// Kas kasutaja arv on paaris või paaritu?
int result = userNum % 2;

if (result != 0)
{
    Console.WriteLine("User's number is odd.");
}
else
{
    Console.WriteLine("User's number is even.");
}