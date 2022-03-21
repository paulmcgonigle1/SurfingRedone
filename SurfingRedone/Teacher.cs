using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace SurfingRedone
{
    //Creating classes for objects
    public class Teacher
    {
        public int TeacherID { get; set; }

        public string TName { get; set; }

        //image property which will be used in conjunction with DataTemplate to diplay image
        public string Image { get; set; }
    }

    //beach class
    public class Beach
    {
        public int BeachID { get; set; }

        public string BName { get; set; }

        public string Image { get; set; }
    }

    public class User//creating a class for User
    {
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string ProfilePic { get; set; }


    }



    public class SurfData : DbContext //class for database
    {
        public SurfData() : base("MySurfData2") { }//constructor of Data for creating db

        public DbSet<Teacher> Teachers { get; set; }//this will create a table in the db called players, modelled on the player class

        public DbSet<Beach> Beaches { get; set; }


    }
}
