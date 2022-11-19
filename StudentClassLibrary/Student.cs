namespace StudentClassLibrary
{
    public interface IStudent
    {
        
        public int StudentId { get; set; }
        public int Standard { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public char Gender { get; set; }
        public char Section { get; set; }
        void StudentInfo();
        void MarksCalculation();

    }
}