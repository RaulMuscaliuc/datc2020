using Microsoft.WindowsAzure.Storage.Table;

namespace students_api
{
    public class Student : TableEntity
    {
        public Student(string universitate, string cnp)
        {
            this.PartitionKey = universitate;
            this.RowKey = cnp;
        }
        public Student() { }
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int AnStudiu { get; set; }
        public string Facultate { get; set; }
        public string NumarTelefon { get; set; }
        public string Adresa { get;}
    }   
}
