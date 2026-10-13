PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader() {
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("0_0");
}

void PrintFooter() {
    Console.WriteLine(">_<");
    Console.WriteLine("   Конец программы");
    Console.WriteLine("X_X");
    Console.WriteLine("Дата формирования отчёта: 13.10.2026");
}


void PrintStudentCard(string name, int age, string group) {
    Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {group}");
}

PrintStudentCard("Егор", 18, "252");
PrintStudentCard("Валерия", 17, "251");


double averageGrade = 4.6; 
double result; 

if (IsEligibleForBonus(averageGrade)) {
    result = CalculateScholarship(2000, 15);
} else {
    result = CalculateScholarship(2000, 0);
}

Console.WriteLine(result);

double CalculateScholarship(double baseAmount, double bonusPercent) {
    return baseAmount + baseAmount * bonusPercent / 100;
}

bool IsEligibleForBonus(double averageGrade) {
    return averageGrade >= 4.5;
}


using System.Dynamic;

double CalculateAverageGrade(int[] grades) {
    int sum = 0;
    foreach (int grade in grades) {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades){
    int count = 0;
    foreach (int grade in grades) {
        if (grade == 5) {
            count++;
        }
    }
    return count;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int fives = CountFives(grades);
Console.WriteLine(average);
Console.WriteLine(fives);
