// See https://aka.ms/new-console-template for more information

// Define integer variables to represent birthdate components

// Assign the birth month as an integer value (e.g., 12 for December)
int myBirthMonth = (int)Months.Dec;
// Assign the birth day as 23
int myBirthDay = 23;
// Assign the birth year as 1997
int myBirthYear = 1997;

// Create a string to represent the birthdate using string interpolation
string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}";

// Write a line of text to a file called "myFile.txt"
File.WriteAllText("myFile.txt", "This is my text file!\n");

// Read and display the contents of "myFile.txt" to the console
Console.WriteLine(File.ReadAllText("myFile.txt"));

// Append additional text to "myFile.txt"
File.AppendAllText("myFile.txt", "WooHoo more text added to file!\n");
// Read and display the updated contents of "myFile.txt"
Console.WriteLine(File.ReadAllText("myFile.txt"));

// Check if a file called "newFile.txt" exists
if (!File.Exists("newFile.txt"))
{
// If it doesn't exist, copy "myFile.txt" to create "newFile.txt"
File.Copy("myFile.txt", "newFile.txt");
}
else
{
// If "newFile.txt" already exists, replace it with "myFile.txt" and create a backup as "backupFile.txt"
File.Replace("myFile.txt", "newFile.txt", "backupFile.txt");
}

// Append the formatted birthdate string to "newFile.txt"
File.AppendAllText("newFile.txt", myBirthDate);

// Read and display the updated contents of "newFile.txt"
Console.WriteLine(File.ReadAllText("newFile.txt"));

// Define an enumeration named "Months" to represent the months of the year
enum Months
{
    Jan = 1,
    Feb,
    Mar,
    Apr,
    May,
    Jun,
    Jul,
    Aug,
    Sep,
    Oct,
    Nov,
    Dec
}