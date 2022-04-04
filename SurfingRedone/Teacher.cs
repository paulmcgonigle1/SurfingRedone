﻿using System;
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

        public double Balance { get; set; }
        public string ProfilePic { get; set; }

        public virtual List<Lesson> Lessons { get; set; }

        public virtual List<Board> Boards { get; set; }

        public User()
        {
            Lessons = new List<Lesson>();

            Boards = new List<Board>();
        }
        
    }
    public class Lesson//creating a class for Lesson
    {
        public Lesson(string lessonLength, string lessonDate, string lessonBoard, string lessonBeach)
        {
            LessonLength = lessonLength;
            LessonDate = lessonDate;
            LessonBoard = lessonBoard;
            LessonBeach = lessonBeach;
        }

        public int LessonID { get; set; }
        public string Length { get; set; }

        public DateTime Date { get; set; }

        public virtual Teacher Teacher { get; set; }

        public string ProfilePic { get; set; }

        public virtual Board board { get; set; }

        public virtual Beach Beach { get; set; }
        public string LessonLength { get; }
        public string LessonDate { get; }
        public string LessonBoard { get; }
        public string LessonBeach { get; }
    }
    public class Board//creating a class for Boards
    {
        public int BoardID { get; set; }

        public string BoardName { get; set; }
        public string Type { get; set; }

        public int Weight { get; set; }

        public string ImageURL { get; set; }

        public string Colour { get; set; }

        public double Price { get; set; }

        public virtual List<User> Users { get; set; }
         


    }




    public class SurfsUp4 : DbContext //class for database
    {
        public SurfsUp4() : base("SurfsUp4") { }//constructor of Data for creating db

        public DbSet<Teacher> Teachers { get; set; }//this will create a table in the db called players, modelled on the player class

        public DbSet<Beach> Beaches { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Board> Boards { get; set; }

        public DbSet<Lesson> Lessons { get; set; }
 

    }
}
