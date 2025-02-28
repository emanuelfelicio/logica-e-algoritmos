
// grade 0 to 100
// grade<40 == falling grade
// Rounding : se grade - o proximo multipo de 5<3 ; grade = o proximo multiplo de 5 
// se grade <38 não haverá rounding
// retornar a lista com valores arrendodados




List<int> list = [73, 67, 38, 33];
list = gradingStudents(list);
foreach (int i in list)
{
    Console.WriteLine(i);
}
List<int> gradingStudents(List<int> grades)
{
    List<int> result = [];
    for (int i = 0; i < grades.Count; i++)
    {

        if (grades[i] >= 38)
        {
            int resto5 = grades[i] % 5;
            if (resto5 > 2)
            {
                grades[i] += 5 - resto5;
            }
        }
    }
    return grades;
}
