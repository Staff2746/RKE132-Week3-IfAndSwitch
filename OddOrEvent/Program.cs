Console.WriteLine("Enter a nuber");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu?


int result = userNum % 2;

Console.WriteLine(result);

if(result != 0) //ei ole eitus

{
    Console.WriteLine(  "user number is odd.");
}
else
{
    Console.WriteLine("User number is even.");
}


