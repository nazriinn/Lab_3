// See https://aka.ms/new-console-template for more information
// Task 1
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}

// Task 2
Console.WriteLine("Eded daxil edin:");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}

// Task 3
Console.WriteLine("Gun nomresini daxil edin (1-7):");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid");
        break;
}

// Task 4
int i4 = 1;
int sum4 = 0;
while (i4 <= 10)
{
    sum4 += i4;
    i4++;
}
Console.WriteLine(sum4);

// Task 5
int[] arr5 = { 5, 8, 3, 12, 6 };
int max5 = arr5[0];
for (int i = 1; i < arr5.Length; i++)
{
    if (arr5[i] > max5)
    {
        max5 = arr5[i];
    }
}
Console.WriteLine(max5);

// Task 6
Console.WriteLine("Soz daxil edin:");
string word6 = Console.ReadLine().ToLower();
int vowels = 0;
for (int i = 0; i < word6.Length; i++)
{
    if ("aeiou".Contains(word6[i]))
    {
        vowels++;
    }
}
Console.WriteLine(vowels);

// Task 7
Console.WriteLine("Eded daxil edin:");
int n7 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i + " x " + n7 + " = " + (i * n7));
}



// Task 8
List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David", "Eva" };
Console.WriteLine("Ad daxil edin:");
string searchName = Console.ReadLine();
bool found = false;
for (int i = 0; i < names.Count; i++)
{
    if (names[i] == searchName)
    {
        found = true;
        break;
    }
}
if (found)
{
    Console.WriteLine("Found");
}
else
{
    Console.WriteLine("Not Found");
}

// Task 9
List<int> list9 = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
List<int> unique9 = new List<int>();
for (int i = 0; i < list9.Count; i++)
{
    bool exist = false;
    for (int j = 0; j < unique9.Count; j++)
    {
        if (list9[i] == unique9[j])
        {
            exist = true;
            break;
        }
    }
    if (!exist)
    {
        unique9.Add(list9[i]);
    }
}
for (int i = 0; i < unique9.Count; i++)
{
    Console.Write(unique9[i] + " ");
}
Console.WriteLine();





// Task 10
int[] arr10 = { 1, 2, 3, 4, 5, 6, 7, 8 };
int sumEven10 = 0;
for (int i = 0; i < arr10.Length; i++)
{
    if (arr10[i] % 2 == 0)
    {
        sumEven10 += arr10[i];
    }
}
Console.WriteLine(sumEven10);


// Task 11
int choice = 0;

while (choice != 4)
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Exit");

    Console.Write("Choose: ");
    choice = int.Parse(Console.ReadLine());

    if (choice == 4)
    {
        Console.WriteLine("Exiting...");
        break;
    }

    Console.Write("Enter first number: ");
    int n1 = int.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    int n2 = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        Console.WriteLine("Result: " + (n1 + n2));
    }
    else if (choice == 2)
    {
        Console.WriteLine("Result: " + (n1 - n2));
    }
    else if (choice == 3)
    {
        Console.WriteLine("Result: " + (n1 * n2));
    }
    else
    {
        Console.WriteLine("Wrong choice");
    }
}



// Task 12
int[] arr12 = { 1, -2, 0, 3, -5 };
int pos12 = 0;
int neg12 = 0;
int zero12 = 0;
for (int i = 0; i < arr12.Length; i++)
{
    if (arr12[i] > 0) pos12++;
    else if (arr12[i] < 0) neg12++;
    else zero12++;
}
Console.WriteLine("Positive: " + pos12 + " Negative: " + neg12 + " Zero: " + zero12);


// Task 13
int[] arr13 = { 3, 6, 2, 7, 5 };
int max13 = arr13[0];
int second13 = arr13[0];
for (int i = 0; i < arr13.Length; i++)
{
    if (arr13[i] > max13)
    {
        second13 = max13;
        max13 = arr13[i];
    }
    else if (arr13[i] > second13 && arr13[i] != max13)
    {
        second13 = arr13[i];
    }
}
Console.WriteLine(second13);

// Task 14
int[] arr14 = { 1, 2, 3, 5, 7 };
bool sorted14 = true;
for (int i = 1; i < arr14.Length; i++)
{
    if (arr14[i] < arr14[i - 1])
    {
        sorted14 = false;
        break;
    }
}
Console.WriteLine(sorted14);

// Task 15
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

// Task 16
Random rnd16 = new Random();
int secret16 = rnd16.Next(1, 21);
int guess16 = 0;
while (guess16 != secret16)
{
    guess16 = Convert.ToInt32(Console.ReadLine());
    if (guess16 != secret16)
    {
        Console.WriteLine("Duz deyil");
    }
}
Console.WriteLine("Tapdiniz!");




// Task 17
List<string> list17 = new List<string> { "hello", "world", "programming" };
for (int i = 0; i < list17.Count; i++)
{
    list17[i] = list17[i].ToUpper();
}
foreach (var x in list17)
{
    Console.WriteLine(x);
}

// Task 18
int[] arr18 = { 1, 3, 3, 5, 3, 1 };
int count18 = 0;
for (int i = 0; i < arr18.Length; i++)
{
    if (arr18[i] == 3)
    {
        count18++;
    }
}
Console.WriteLine(count18);

// Task 19
int[] arr19a = { 1, 2, 3 };
int[] arr19b = { 4, 5, 6 };
int[] merged19 = new int[arr19a.Length + arr19b.Length];
int k19 = 0;
for (int i = 0; i < arr19a.Length; i++)
{
    merged19[k19++] = arr19a[i];
}
for (int i = 0; i < arr19b.Length; i++)
{
    merged19[k19++] = arr19b[i];
}
for (int i = 0; i < merged19.Length; i++)
{
    Console.Write(merged19[i] + " ");
}
Console.WriteLine();


// Task 20
string s20 = "I love programming in C#";
string[] words20 = s20.Split(' ');
Console.WriteLine(words20.Length);

// Task 21
Console.WriteLine("N daxil edin:");
int n21 = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= n21; i++)
{
    bool prime = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            prime = false;
            break;
        }
    }
    if (prime)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();

// Task 22
int[] arr22 = { 3, -2, 5, -7, 8 };
for (int i = 0; i < arr22.Length; i++)
{
    if (arr22[i] < 0)
    {
        arr22[i] = 0;
    }
}
for (int i = 0; i < arr22.Length; i++)
{
    Console.Write(arr22[i] + " ");
}
Console.WriteLine();




// Task 23
List<int> list23 = new List<int> { 5, 3, 8, 1, 2 };
for (int i = 0; i < list23.Count; i++)
{
    for (int j = i + 1; j < list23.Count; j++)
    {
        if (list23[j] < list23[i])
        {
            int t = list23[i];
            list23[i] = list23[j];
            list23[j] = t;
        }
    }
}
for (int i = 0; i < list23.Count; i++)
{
    Console.Write(list23[i] + " ");
}
Console.WriteLine();

// Task 24
Console.WriteLine("Eded daxil edin:");
int num24 = Convert.ToInt32(Console.ReadLine());
int sum24 = 0;
int temp24 = num24;
while (temp24 > 0)
{
    sum24 += temp24 % 10;
    temp24 /= 10;
}
Console.WriteLine("Reqemlerin cemi: " + sum24);

// Task 25
List<int> list25 = new List<int> { 1, 2, 3, 4, 5, 6 };
int even25 = 0;
int odd25 = 0;
for (int i = 0; i < list25.Count; i++)
{
    if (list25[i] % 2 == 0)
    {
        even25++;
    }
    else
    {
        odd25++;
    }
}
Console.WriteLine("Even: " + even25 + " Odd: " + odd25);


// Task 26
int[] arr26 = { 1, 2, 3, 4, 5 };
int left26 = 0;
int right26 = arr26.Length - 1;
while (left26 < right26)
{
    int t = arr26[left26];
    arr26[left26] = arr26[right26];
    arr26[right26] = t;
    left26++;
    right26--;
}
Console.WriteLine("Ters array: " + string.Join(",", arr26));



// Task 27
int[] grades = new int[5];
int sum = 0;

for (int i = 0; i < 5; i++)
{
    grades[i] = Convert.ToInt32(Console.ReadLine());
    sum += grades[i];
}

double average = (double)sum / 5;

int highest = grades[0];
int lowest = grades[0];
int above90 = 0;

for (int i = 0; i < 5; i++)
{
    if (grades[i] > highest)
        highest = grades[i];

    if (grades[i] < lowest)
        lowest = grades[i];

    if (grades[i] > 90)
        above90++;
}

Console.WriteLine("Average: " + average);
Console.WriteLine("Highest: " + highest);
Console.WriteLine("Lowest: " + lowest);
Console.WriteLine("Above 90: " + above90);



// Task 28
Console.WriteLine("Soz daxil edin:");
string word28 = Console.ReadLine();
Dictionary<char, int> freq28 = new Dictionary<char, int>();
for (int i = 0; i < word28.Length; i++)
{
    if (freq28.ContainsKey(word28[i]))
    {
        freq28[word28[i]]++;
    }
    else
    {
        freq28[word28[i]] = 1;
    }
}
foreach (var kvp in freq28)
{
    Console.WriteLine(kvp.Key + " -> " + kvp.Value);
}

// Task 29
List<int> list29 = new List<int> { 1, 2, 3, 2, 4, 2, 5 };
int removeNum29 = 2;
List<int> newList29 = new List<int>();
for (int i = 0; i < list29.Count; i++)
{
    if (list29[i] != removeNum29)
    {
        newList29.Add(list29[i]);
    }
}
for (int i = 0; i < newList29.Count; i++)
{
    Console.Write(newList29[i] + " ");
}
Console.WriteLine();



// Task 30
List<int> list30 = new List<int> { 1, 2, 3, 2, 4, 2, 5 };
int removeNum30 = 2;
List<int> newList30 = new List<int>();
for (int i = 0; i < list30.Count; i++)
{
    if (list30[i] != removeNum30)
    {
        newList30.Add(list30[i]);
    }
}
for (int i = 0; i < newList30.Count; i++)
{
    Console.Write(newList30[i] + " ");
}
Console.WriteLine();
