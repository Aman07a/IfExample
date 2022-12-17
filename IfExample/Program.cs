using System;

namespace IfExample
{
	class Program
	{
		static void Main()
		{
			// Declare variable to store marks of the student
			int marks = 70;
			char gradeLetter;

			// >=85 O
			// >=60 && <85 A
			// >=50 && <50 B
			// >=35 && <50 C
			// else F

			// Show congratulations if the student has passed
			if (marks >= 35)
			{
				if (marks >= 85)
				{
					gradeLetter = 'O';
				}
				else if (marks >= 60 && marks < 85)
				{
					gradeLetter = 'A';
				}
				else if (marks >= 50 && marks < 60)
				{
					gradeLetter = 'B';
				}
				else
				{
					gradeLetter = 'C';
				}
			} else
			{
				gradeLetter = 'F';
			}

			System.Console.WriteLine("Your grade is " + gradeLetter);
			System.Console.ReadKey();
		}
	}
}
