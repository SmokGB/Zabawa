namespace ChallengeApp
{
    public interface IEmployee
    {
        delegate void GradeAddedDelegate(object sender, EventArgs args);
        event GradeAddedDelegate GradeAdded;

        string Name { get; }
        string Surname { get; }
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        Statistics GetStatistics();

    }
}
