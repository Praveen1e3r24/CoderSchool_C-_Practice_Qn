///*
//My Telephone Directory

//Instructions:
//1. Create a csv file called PhoneDirectory.csv with comma delimiter that contains your friends’ names and phone numbers.
//2. Write a C# program that prompts the user for names and phone numbers for an additional list of people and append them to the same csv file.
//3. Terminate the loop when the name entered is “Exit”.
//4. Display the number of records appended to the file.
//5. Open PhoneDirectory.csv in Notepad to ensure that the new data are added.
//6. Determine the difference between “copy always” and “copy if newer”.

//Note:
//- You may use Notepad to create the file and save it as the given file name (change the “Save as type” to “All Files”).
//- Add the data file to your project in Visual Studio.
//- Set the property of the file to “copy always” or “copy if newer”. This allows the file to be copied from the project folder into the bin/Debug/net6.0 folder at runtime.

//*/




//        // Step 1: Define the file path for PhoneDirectory.csv
//        string filePath = "PhoneDirectory.csv";

//        // Step 2: Check if the file exists, if not, create it and add header
//        if (!File.Exists(filePath))
//        {
//            using (StreamWriter sw = File.CreateText(filePath))
//            {
//                sw.WriteLine("Name,Phone Number");
//            }
//        }

//        // Step 3: Prompt the user to enter names and phone numbers
//        //         Append them to the CSV file until "Exit" is entered
//        int recordCount = 0;
//        string inputName, inputPhoneNumber;
//        do
//        {
//            Console.Write("Enter name (or 'Exit' to quit): ");
//            inputName = Console.ReadLine();
//            if (inputName.ToLower() == "exit")
//                break;

//            Console.Write("Enter phone number: ");
//            inputPhoneNumber = Console.ReadLine();

//            // Step 4: Append the input to the CSV file
//            using (StreamWriter sw = File.AppendText(filePath))
//            {
//                sw.WriteLine($"{inputName},{inputPhoneNumber}");
//            }

//            recordCount++;
//        } while (true);

//        // Step 5: Display the number of records appended to the file
//        Console.WriteLine($"Number of records appended: {recordCount}");

//        // Note: To see the changes in the file, open it in Notepad




/*
Library Loan

Instructions:
- The file loaninfo.csv contains the loan information of the library books as follows:
  Book ID, Borrower ID, Date Borrowed, Date Returned
- Assume that the maximum loan duration for each book is 14 days.
- There will be a charge of 50 cents for each day overdue.
- Write a C# program to read the data from the file and display them together with the number of days the books were loaned out.
- Display the number of days overdue and fine if the loan duration exceeds 14 days.
- Create an output file overdueinfo.csv with book id, borrower id, days overdue, and fine amount for books overdue.

Sample Output:
Book ID  Borrower ID  Date Borrowed  Date Returned  Days Loaned  Days Overdue  Fine
123456   789012       2023-03-15     2023-03-25     10           0             $0.00
789012   345678       2023-03-20     2023-04-05     16           2             $1.00

Output file overdueinfo.csv:
Book ID, Borrower ID, Days Overdue, Fine
789012,    345678,       2       , $1.00


*/

// Step 1: Import necessary namespaces

//using System.Globalization;

/////*
//string inputFile = "loaninfo.csv";
//string outputFile = "overdueinfo.csv";

//// Step 3: Read data from loaninfo.csv and process
//try
//{
//    // Read all lines from the file, skipping the header line
//    string[] lines = File.ReadAllLines(inputFile);

//    // Open the output file for writing
//    using (StreamWriter sw = new StreamWriter(outputFile))
//    {

//        // Print header to console
//        Console.WriteLine("{0,-10} {1,-12} {2,-14} {3,-14} {4,-12} {5,-13} {6,-8}", "Book ID", "Borrower ID", "Date Borrowed", "Date Returned", "Days Loaned", "Days Overdue", "Fine");

//        // Write header to output file
//        sw.WriteLine("Book ID, Borrower ID, Days Overdue, Fine");

//        // Process each line
//        for (int i = 1; i < lines.Length; i++)
//        {
//            // Split line by comma
//            string[] parts = lines[i].Split(',');

//            // Extract relevant data
//            string bookID = parts[0];
//            string borrowerID = parts[1];

//            // Update the format string for parsing the date
//            // Update the format string for parsing the date
//            DateTime dateBorrowed = DateTime.ParseExact(parts[2], "d/M/yyyy", CultureInfo.InvariantCulture);
//            DateTime dateReturned = DateTime.ParseExact(parts[3], "d/M/yyyy", CultureInfo.InvariantCulture);



//            // Calculate days loaned
//            int daysLoaned = (int)(dateReturned - dateBorrowed).TotalDays;

//            // Calculate days overdue and fine
//            int daysOverdue = Math.Max(daysLoaned - 14, 0);
//            double fine = daysOverdue * 0.5;

//            // Write data to console
//            Console.WriteLine($"{bookID,-10} {borrowerID,-12} {dateBorrowed,-14:yyyy-MM-dd} {dateReturned,-14:yyyy-MM-dd} {daysLoaned,-12} {daysOverdue,-13} ${fine,-8:F2}");


//            // Write data to output file if overdue
//            if (daysOverdue > 0)
//            {
//                sw.WriteLine($"{bookID}, {borrowerID}, {daysOverdue}, ${fine:F2}");
//            }
//        }
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine($"An error occurred: {e.Message}");
//}



