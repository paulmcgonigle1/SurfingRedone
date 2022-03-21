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
        public string UserName { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string ProfilePic { get; set; }

        public virtual List<Lesson> Lessons { get; set; }

        public virtual List<Board> Boards { get; set; }


    }
    public class Lesson//creating a class for Lesson
    {
        public int LessonID { get; set; }
        public string Length { get; set; }

        public DateTime Date { get; set; }

        public virtual Teacher Teacher { get; set; }

        public string ProfilePic { get; set; }

        public virtual List<Board> Board { get; set; }


    }
    public class Board//creating a class for Boards
    {
        public int BoardID { get; set; }
        public string Type { get; set; }

        public int Weight { get; set; }

        public string ImageURL { get; set; }

        public string Colour { get; set; }

        


    }




    public class SurfData : DbContext //class for database
    {
        public SurfData() : base("MySurfData2") { }//constructor of Data for creating db

        public DbSet<Teacher> Teachers { get; set; }//this will create a table in the db called players, modelled on the player class

        public DbSet<Beach> Beaches { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Board> Boards { get; set; }

        public DbSet<Lesson> Lessons { get; set; }
 

    }
}
