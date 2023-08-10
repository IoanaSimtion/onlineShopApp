using onlineShop.user.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.user.service
{
    public class UserService
    {
        private List<User> users;

        public UserService()
        {

            users = new List<User>();

            this.load();

        }

        public void load()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo parentDirectory = Directory.GetParent(currentDirectory);


            StreamReader streamReader = new StreamReader(parentDirectory.FullName + @"/data/users.txt");

            string line = "";

            while ((line = streamReader.ReadLine()) != null)
            {

                //Debug.WriteLine("Aici");
                switch (line.Split(",")[0])
                {

                    case "client":
                        users.Add(new Client(line));
                        break;
                    case "admin":
                        users.Add(new Admin(line));
                        break;

                }
            }


            streamReader.Close();
        }

        public void afisare()
        {

            for (int i = 0; i < users.Count; i++)
            {
                Debug.WriteLine(users[i]);

            }
        }

        public string saveUsers()
        {
            string text = "";

            for (int i = 0; i < users.Count; i++)
            {
                text += users[i].returnSave();
                text += "\n";
            }

            return text;
        }

        public void save()
        {

            string data = saveUsers();

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo parentDirectory = Directory.GetParent(currentDirectory);

            StreamWriter streamWriter = new StreamWriter(parentDirectory.FullName + @"/data/users.txt");

            streamWriter.Write(data);

            streamWriter.Close();

            //Debug.WriteLine(data);

        }

        public List<User> Users { get { return users; } }
    }
}
