namespace mvc.Repository
{
    
    public class PeopleRepository : IPeopleRepository
    {
        public PeopleRepository(string connectionString)
        {

        }

        public string GetNameById(int id)
        {
            return "Joserf Abrah";
        }
    }
}