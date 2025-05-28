using System;
class NoteTaker{
    public string note;
    public string subject;
    public DateTime Date;
    public void AddNote(string note){
        Console.WriteLine("The notes are : " + note);
    }
    public void AddNote(string subject ,string note){
        Console.WriteLine("The subject is : "+subject);
        Console.WriteLine("The notes are : "+note);
    }
    public void AddNote(string subject,string note,DateTime Date){
        Console.WriteLine("Subject is "+subject);
        Console.WriteLine("The Notes are " +note);
        Console.WriteLine("The date and time is "+Date);
    }
}
class Program{
        public static void Main(string[] args) {
            NoteTaker noteTaker= new NoteTaker();
            DateTime date = new DateTime(2025,2,12,22,21,50);
            noteTaker.AddNote("Take care of yourself ");
            noteTaker.AddNote("Maths","Take Care");
            noteTaker.AddNote("Physics","Self love is much needed",date);
        }
}