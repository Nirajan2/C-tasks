namespace OperatorsAndControlFlow
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: College Reward Points ----
            int points = 10;                 // TODO 1: start with 10 reward points
            points += 5;                     // TODO 2: add 5 with +=
            points *= 2;                     // TODO 2: double the total with *=
            Console.WriteLine($"Final points: {points}");

            bool atLeast25 = points >= 25;   // TODO 3: comparison operator
            Console.WriteLine($"At least 25 points: {atLeast25}");

            int afterPost = points++;        // TODO 4: use 30 first, then store 31
            Console.WriteLine($"points++ returned {afterPost}; points is now {points}");

            int afterPre = ++points;         // TODO 4: store 32 first, then return 32
            Console.WriteLine($"++points returned {afterPre}; points is now {points}");

            Console.WriteLine();

            // ---- Task 2: Student Exam Result ----
            int marks = 72;                  // TODO 1: change these values to test
            int attendance = 80;

            string grade;                    // TODO 2: if / else if / else grade ladder
            if (marks >= 80)
            {
                grade = "A";
            }
            else if (marks >= 65)
            {
                grade = "B";
            }
            else if (marks >= 50)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }

            bool isEligible = marks >= 50 && attendance >= 75; // TODO 3: logical AND
            Console.WriteLine($"Marks: {marks}, Attendance: {attendance}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Pass eligible: {isEligible}");

            Console.WriteLine();

            // ---- Task 3: Library Menu ----
            int choice = 2;                  // TODO 1: test with 1, 3 and 9
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Borrow   2. Return   3. Renew");
            Console.WriteLine($"Selected choice: {choice}");

            switch (choice)                  // TODO 2: switch with a default case
            {
                case 1:
                    Console.WriteLine("You selected Borrow.");
                    break;
                case 2:
                    Console.WriteLine("You selected Return.");
                    break;
                case 3:
                    Console.WriteLine("You selected Renew.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            string? userName = null;         // TODO 3: nullable string with no value
            string displayName = userName ?? "Guest"; // TODO 3: ?? supplies a default
            Console.WriteLine($"Display name: {displayName}");

            userName ??= "Guest";            // TODO 4: ??= assigns only when null
            Console.WriteLine($"userName after ??=: {userName}");

            Console.WriteLine();

            // ---- Task 4: Weekly Attendance ----
            int[] dailyAttendance = { 20, 22, 21, 24, 23 }; // TODO 1: Monday to Friday
            int total = 0;

            Console.WriteLine("Daily attendance:");          // TODO 2: foreach
            foreach (int present in dailyAttendance)
            {
                Console.WriteLine($"  {present}");
                total += present;
            }
            Console.WriteLine($"Total attendance: {total}");

            for (int i = 0; i < dailyAttendance.Length; i++) // TODO 3: for with an index
            {
                Console.WriteLine($"Day {i + 1}: {dailyAttendance[i]}");
            }

            int countdown = 3;                               // TODO 4: while
            while (countdown >= 1)
            {
                Console.WriteLine(countdown);
                countdown--;
            }

            bool runAgain = false;                           // TODO 5: do-while runs once
            do
            {
                Console.WriteLine("Attendance recorded");
            }
            while (runAgain);

            Console.WriteLine();

            // ---- Task 5: Exam Hall Seat Labels ----
            int seatCount = 0;
            for (int row = 1; row <= 3; row++)               // TODO 1: nested for loops
            {
                for (int seat = 1; seat <= 4; seat++)
                {
                    Console.WriteLine($"Row {row} - Seat {seat}");
                    seatCount++;
                }
            }
            Console.WriteLine($"Total seats: {seatCount}");

            Console.Write("Loop values: ");                  // TODO 2: continue skips 5, break stops at 8
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                if (i == 8)
                {
                    break;
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            Console.WriteLine();

            // ---- Task 6: Simple Division Calculator ----
            Console.Write("Enter the first integer: ");       // TODO 1: read two strings
            string firstInput = Console.ReadLine() ?? "";
            Console.Write("Enter the second integer: ");
            string secondInput = Console.ReadLine() ?? "";

            try                                             // TODO 2: parse and divide
            {
                int first = int.Parse(firstInput);
                int second = int.Parse(secondInput);
                int result = first / second;
                Console.WriteLine($"Result: {result}");
            }
            catch (FormatException)                          // TODO 3: bad number text
            {
                Console.WriteLine("Error: please enter whole numbers only.");
            }
            catch (DivideByZeroException)                     // TODO 3: division by zero
            {
                Console.WriteLine("Error: cannot divide by zero.");
            }
            finally                                           // TODO 4: always runs
            {
                Console.WriteLine("Calculation complete");
            }
        }
    }
}
