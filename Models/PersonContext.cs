namespace PercobaanApi1.Models
{
    public class PersonContext
    {
        public List<Person> ListPerson()
        {
            List<Person> list1 = new List<Person>();
            Object[,] arrayPerson = new Object[,]{
                {1, "Ulul", "Gresik", "lullll@gmail.com" },
                {2, "Yusril", "Warlok Jember", "yusss@gmail.com" },
                {3, "Ave", "Lumajang", "veee@gmail.com" }
            };
            for (int i = 0; i < arrayPerson.GetLength(0); i++)
            {
                list1.Add(new Person()
                {
                    id_person = int.Parse(arrayPerson[i, 0].ToString()),
                    nama = arrayPerson[i, 1].ToString(),
                    alamat = arrayPerson[i, 2].ToString(),
                    email = arrayPerson[i, 3].ToString()
                });
            }
            return list1;
        }
    }
}