using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CasseBrique.Model;
namespace CasseBrique.ViewModel
{
    public class ViewModel_User
    {
        public void AddUser(string pseudo, string password)
        {
            Dal dal = new Dal();
            dal.AddUser(new Model_User { Pseudo = pseudo, Password = password, HighScore = 0 });
        }

        public List<Model_User> GetUsers()
        {
            Dal dal = new Dal();
            return dal.GetUsers();
        }
        

        
        /// <summary>
        /// retourne vrai si le pseudo est déjà présent dans la base de données
        /// faux sinon
        /// </summary>
        /// <returns></returns>
        public bool IsInBdd(string pseudo)
        {
            Dal dal = new Dal();
            List<Model_User> users = new List<Model_User>();
            users = dal.GetUsers();
            foreach (Model_User user in users)
            {
                if (user.Pseudo == pseudo)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsInBdd(string pseudo, string password)
        {
            Dal dal = new Dal();
            List<Model_User> users = new List<Model_User>();
            users = dal.GetUsers();
            foreach (Model_User user in users)
            {
                if (user.Pseudo == pseudo && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public int getHighscore(string name)
        {
            Dal dal = new Dal();
            List<Model_User> users = new List<Model_User>();
            users = dal.GetUsers();
            foreach (Model_User user in users)
            {
                if (user.Pseudo == name)
                {
                    return user.HighScore;
                }
            }
            return 0;
        }

        public void setHighscore(string name, int score)
        {
            Dal dal = new Dal();
            List<Model_User> users = new List<Model_User>();
            users = dal.GetUsers();
            foreach (Model_User user in users)
            {
                if (user.Pseudo == name)
                {
                    Console.WriteLine("il est dedans" + name + " s:"+score +"hs :" + user.HighScore +" pseudo "+ user.Pseudo);
                    user.HighScore = score;
                    dal.setScore();
                }
            }
        }


    }
}
