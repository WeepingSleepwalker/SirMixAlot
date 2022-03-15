

string newString;
int newInt;

Console.WriteLine("Please enter your message and press enter");

newString = Console.ReadLine();

Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter.");

newInt = int.Parse(Console.ReadLine());

char newChar;

Console.WriteLine("For which character should I search in your original message?");

newChar = char.Parse(Console.ReadLine());

int charcounter = 0;
for(int i =0; i <=newString.Length-1; i++ ){
    if (newString[i] == newChar){
        charcounter++;
    }
}

Console.WriteLine("I found" + newChar + " " + charcounter + "times");

Console.WriteLine("What is your first name");
string first = Console.ReadLine();

Console.WriteLine("What is your lastname");

string last = Console.ReadLine();

Console.WriteLine(first + last);

Console.WriteLine(first[0]);

Console.WriteLine(first[0]+last[0].ToString());

Console.WriteLine(last[0]+ last[1] +" ");
Console.WriteLine(first + " " + last.Substring(0,2));
Console.WriteLine(last.Length);